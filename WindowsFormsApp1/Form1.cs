using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;
using NCalc;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            AdjustLayout(); 
        }
        private void DrawButton_Click(object sender, EventArgs e) // Обработчик нажатия на кнопку "Построить"
        {
            string function = functionInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(function))
            {
                MessageBox.Show("Пожалуйста, введите функцию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CreateGraph(zedGraphControl1, function);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при построении графика: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateGraph(ZedGraphControl zgc, string function)// Функция для создания графика
        {
            GraphPane graphPane = zgc.GraphPane;
            graphPane.CurveList.Clear(); // Очищаем предыдущие графики
            graphPane.Title.Text = "График функции"; // Настройка заголовков
            graphPane.XAxis.Title.Text = "X";
            graphPane.YAxis.Title.Text = "Y";
            PointPairList points = new PointPairList(); // Данные для графика

            Expression compiledFunction;// Предварительная компиляция выражения для повышения производительности
            try
            {
                compiledFunction = new Expression(function);
                if (!compiledFunction.HasErrors())
                {
                    compiledFunction.Parameters["x"] = 0; // Инициализируем переменную "x", чтобы избежать ошибок при вычислениях
                }
                else
                {
                    throw new Exception("Ошибка в синтаксисе функции.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при компиляции функции: {ex.Message}");
            }
            for (double x = -10; x <= 10; x += 0.1) // Построение графика на основе введённой функции
            {
                try
                {
                    double y = EvaluateFunction(compiledFunction, x);

                    if (double.IsInfinity(y) || double.IsNaN(y) || y < -10000 || y > 10000)// Проверка на недопустимые значения
                    {
                        continue;  // Пропускаем значения, которые слишком большие, слишком маленькие или некорректные
                    }

                    points.Add(x, y);
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
            LineItem curve = graphPane.AddCurve("y = " + function, points, Color.Blue, SymbolType.None);// Создаем кривую
            zgc.AxisChange(); // Обновляем оси и перерисовываем график
            zgc.Invalidate();
        }
        private double EvaluateFunction(Expression compiledFunction, double xValue)// Функция для вычисления математического выражения
        {
            compiledFunction.Parameters["x"] = xValue;
            object result = compiledFunction.Evaluate();

            if (result is double yValue) // Здесь убедимся, что результат можно обработать
            {
                return yValue;
            }
            else if (result is int intValue) // Иногда результат может быть целым числом, преобразуем его в double
            {
                return (double)intValue;
            }
            else
            {
                throw new Exception("Невозможно вычислить значение функции.");
            }
        }
        private void AdjustLayout() // Метод для динамической настройки элементов интерфейса
        {
            functionInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            drawButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            zedGraphControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
        }
        protected override void OnResize(EventArgs e)// Обработчик изменения размера окна
        {
            base.OnResize(e);
            AdjustLayout(); // Перераспределение элементов при изменении размера окна
        }
    }
}
