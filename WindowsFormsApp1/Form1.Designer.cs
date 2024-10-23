using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace WindowsFormsApp1
{
    partial class Form1 : Form
    {
        private bool placeholderActive = true; // Флаг для отслеживания состояния подсказки
        private System.ComponentModel.IContainer components = null;

        // Объявление элементов управления
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.TextBox functionInput;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem viewMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem saveGraphMenuItem;
        private ToolStripMenuItem copyGraphMenuItem;
        private ToolStripMenuItem clearGraphMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem aboutMenuItem;

        // Освобождение ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.drawButton = new System.Windows.Forms.Button();
            this.functionInput = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGraphMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGraphMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGraphMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(400, 30);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(97, 23);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Построить";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // functionInput
            // 
            this.functionInput.Location = new System.Drawing.Point(10, 30);
            this.functionInput.Name = "functionInput";
            this.functionInput.Size = new System.Drawing.Size(384, 22);
            this.functionInput.TabIndex = 1;
            this.functionInput.Enter += new System.EventHandler(this.FunctionInput_Enter);
            this.functionInput.Leave += new System.EventHandler(this.FunctionInput_Leave);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(10, 60);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(550, 315);
            this.zedGraphControl1.TabIndex = 2;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.viewMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGraphMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileMenuItem.Text = "Файл";
            // 
            // saveGraphMenuItem
            // 
            this.saveGraphMenuItem.Name = "saveGraphMenuItem";
            this.saveGraphMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveGraphMenuItem.Text = "Сохранить график";
            this.saveGraphMenuItem.Click += new System.EventHandler(this.SaveGraphMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearGraphMenuItem,
            this.copyGraphMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(74, 24);
            this.editMenuItem.Text = "Правка";
            // 
            // clearGraphMenuItem
            // 
            this.clearGraphMenuItem.Name = "clearGraphMenuItem";
            this.clearGraphMenuItem.Size = new System.Drawing.Size(229, 26);
            this.clearGraphMenuItem.Text = "Очистить график";
            this.clearGraphMenuItem.Click += new System.EventHandler(this.ClearGraphMenuItem_Click);
            // 
            // copyGraphMenuItem
            // 
            this.copyGraphMenuItem.Name = "copyGraphMenuItem";
            this.copyGraphMenuItem.Size = new System.Drawing.Size(229, 26);
            this.copyGraphMenuItem.Text = "Копировать график";
            this.copyGraphMenuItem.Click += new System.EventHandler(this.CopyGraphMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(49, 24);
            this.viewMenuItem.Text = "Вид";
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(83, 24);
            this.helpMenuItem.Text = "Помощь";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutMenuItem.Text = "О программе";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(571, 387);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.functionInput);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graph Builder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SaveGraphMenuItem_Click(object sender, EventArgs e)
        {
            SaveGraph();
        }

        private void LoadGraphMenuItem_Click(object sender, EventArgs e)
        {
            LoadGraph();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearGraphMenuItem_Click(object sender, EventArgs e)
        {
            ClearGraph();
        }

        private void CopyGraphMenuItem_Click(object sender, EventArgs e)
        {
            CopyGraph();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Графический построитель версии 1.0\nСоздано для демонстрации возможностей.\n© 2024", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveGraph()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Image Files|*.png;*.jpg;*.bmp|All files|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Получаем изображение графика и сохраняем его
                    using (Image img = zedGraphControl1.GetImage())
                    {
                        img.Save(sfd.FileName); // Сохраняем изображение
                    }
                }
            }
        }

        private void LoadGraph()
        {
            // Реализуйте здесь код для загрузки функций из файла
            MessageBox.Show("Загрузка графика не реализована.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearGraph()
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.Title.Text = "";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "";
            zedGraphControl1.Invalidate();
            SetPlaceholder(); // Устанавливаем подсказку после очистки графика
        }

        private void CopyGraph()
        {
            using (Image img = zedGraphControl1.GetImage())
            {
                Clipboard.SetImage(img); // Копируем изображение в буфер обмена
            }
            MessageBox.Show("График скопирован в буфер обмена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetPlaceholder()
        {
            // Устанавливаем полупрозрачный текст в поле ввода
            functionInput.ForeColor = Color.Gray;
            functionInput.Text = "Введите функцию, например: x^2 + 2*x - 5";
            placeholderActive = true;
        }

        private void RemovePlaceholder()
        {
            // Удаляем текст подсказки и делаем текст нормальным
            functionInput.ForeColor = Color.Black;
            functionInput.Text = "";
            placeholderActive = false;
        }

        private void FunctionInput_Enter(object sender, EventArgs e)
        {
            // Убираем подсказку при фокусе на поле
            if (placeholderActive)
            {
                RemovePlaceholder();
            }
        }

        private void FunctionInput_Leave(object sender, EventArgs e)
        {
            // Если пользователь не ввел текст, возвращаем подсказку
            if (string.IsNullOrWhiteSpace(functionInput.Text))
            {
                SetPlaceholder();
            }
        }
    }
}
