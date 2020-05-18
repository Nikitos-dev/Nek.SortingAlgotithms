namespace Nek.Sortings
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CompareLabel = new System.Windows.Forms.Label();
            this.SwapLabel = new System.Windows.Forms.Label();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.SelectionSortButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.LSDRadixSortButton = new System.Windows.Forms.Button();
            this.MSDRadixSortButton = new System.Windows.Forms.Button();
            this.MergeSortButton = new System.Windows.Forms.Button();
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BaseSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить число";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(250, 39);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(12, 39);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(232, 22);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 72);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заполнить массив случайными числами";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(250, 39);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(12, 39);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(232, 22);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Location = new System.Drawing.Point(352, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(905, 200);
            this.panel3.TabIndex = 3;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(12, 208);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(102, 40);
            this.BubbleSortButton.TabIndex = 3;
            this.BubbleSortButton.Text = "BubbleSort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(9, 251);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(50, 17);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "Время";
            // 
            // CompareLabel
            // 
            this.CompareLabel.AutoSize = true;
            this.CompareLabel.Location = new System.Drawing.Point(9, 268);
            this.CompareLabel.Name = "CompareLabel";
            this.CompareLabel.Size = new System.Drawing.Size(160, 17);
            this.CompareLabel.TabIndex = 5;
            this.CompareLabel.Text = "Количество сравнений";
            // 
            // SwapLabel
            // 
            this.SwapLabel.AutoSize = true;
            this.SwapLabel.Location = new System.Drawing.Point(12, 285);
            this.SwapLabel.Name = "SwapLabel";
            this.SwapLabel.Size = new System.Drawing.Size(146, 17);
            this.SwapLabel.TabIndex = 6;
            this.SwapLabel.Text = "Количество обменов";
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.Location = new System.Drawing.Point(120, 208);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(97, 40);
            this.CocktailSortButton.TabIndex = 7;
            this.CocktailSortButton.Text = "CocktailSort";
            this.CocktailSortButton.UseVisualStyleBackColor = true;
            this.CocktailSortButton.Click += new System.EventHandler(this.CocktailSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(223, 208);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(90, 40);
            this.InsertSortButton.TabIndex = 8;
            this.InsertSortButton.Text = "InsertSort";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(319, 208);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(87, 40);
            this.ShellSortButton.TabIndex = 9;
            this.ShellSortButton.Text = "ShellSort";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // SelectionSortButton
            // 
            this.SelectionSortButton.Location = new System.Drawing.Point(412, 208);
            this.SelectionSortButton.Name = "SelectionSortButton";
            this.SelectionSortButton.Size = new System.Drawing.Size(111, 40);
            this.SelectionSortButton.TabIndex = 10;
            this.SelectionSortButton.Text = "SelectionSort";
            this.SelectionSortButton.UseVisualStyleBackColor = true;
            this.SelectionSortButton.Click += new System.EventHandler(this.SelectionSortButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(529, 208);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(89, 40);
            this.HeapSortButton.TabIndex = 12;
            this.HeapSortButton.Text = "HeapSort";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(624, 208);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(102, 40);
            this.GnomeSortButton.TabIndex = 13;
            this.GnomeSortButton.Text = "GnomeSort";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(732, 208);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(93, 40);
            this.TreeSortButton.TabIndex = 14;
            this.TreeSortButton.Text = "TreeSort";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // LSDRadixSortButton
            // 
            this.LSDRadixSortButton.Location = new System.Drawing.Point(831, 208);
            this.LSDRadixSortButton.Name = "LSDRadixSortButton";
            this.LSDRadixSortButton.Size = new System.Drawing.Size(114, 40);
            this.LSDRadixSortButton.TabIndex = 15;
            this.LSDRadixSortButton.Text = "LSDRadixSort";
            this.LSDRadixSortButton.UseVisualStyleBackColor = true;
            this.LSDRadixSortButton.Click += new System.EventHandler(this.LSDRadixSortButton_Click);
            // 
            // MSDRadixSortButton
            // 
            this.MSDRadixSortButton.Location = new System.Drawing.Point(951, 208);
            this.MSDRadixSortButton.Name = "MSDRadixSortButton";
            this.MSDRadixSortButton.Size = new System.Drawing.Size(117, 40);
            this.MSDRadixSortButton.TabIndex = 16;
            this.MSDRadixSortButton.Text = "MSDRadixSort";
            this.MSDRadixSortButton.UseVisualStyleBackColor = true;
            this.MSDRadixSortButton.Click += new System.EventHandler(this.MSDRadixSortButton_Click);
            // 
            // MergeSortButton
            // 
            this.MergeSortButton.Location = new System.Drawing.Point(1074, 208);
            this.MergeSortButton.Name = "MergeSortButton";
            this.MergeSortButton.Size = new System.Drawing.Size(90, 40);
            this.MergeSortButton.TabIndex = 17;
            this.MergeSortButton.Text = "MergeSort";
            this.MergeSortButton.UseVisualStyleBackColor = true;
            this.MergeSortButton.Click += new System.EventHandler(this.MergeSortButton_Click);
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(1170, 208);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(85, 40);
            this.QuickSortButton.TabIndex = 18;
            this.QuickSortButton.Text = "QuickSort";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 180);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Установить задержку выполнения формы";
            // 
            // BaseSortButton
            // 
            this.BaseSortButton.Location = new System.Drawing.Point(423, 265);
            this.BaseSortButton.Name = "BaseSortButton";
            this.BaseSortButton.Size = new System.Drawing.Size(75, 23);
            this.BaseSortButton.TabIndex = 21;
            this.BaseSortButton.Text = "VS Sort";
            this.BaseSortButton.UseVisualStyleBackColor = true;
            this.BaseSortButton.Click += new System.EventHandler(this.BaseSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 387);
            this.Controls.Add(this.BaseSortButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.MergeSortButton);
            this.Controls.Add(this.MSDRadixSortButton);
            this.Controls.Add(this.LSDRadixSortButton);
            this.Controls.Add(this.TreeSortButton);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SelectionSortButton);
            this.Controls.Add(this.ShellSortButton);
            this.Controls.Add(this.InsertSortButton);
            this.Controls.Add(this.CocktailSortButton);
            this.Controls.Add(this.SwapLabel);
            this.Controls.Add(this.CompareLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Label SwapLabel;
        private System.Windows.Forms.Label CompareLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button CocktailSortButton;
        private System.Windows.Forms.Button InsertSortButton;
        private System.Windows.Forms.Button ShellSortButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SelectionSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button TreeSortButton;
        private System.Windows.Forms.Button LSDRadixSortButton;
        private System.Windows.Forms.Button MSDRadixSortButton;
        private System.Windows.Forms.Button MergeSortButton;
        private System.Windows.Forms.Button QuickSortButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BaseSortButton;
    }
}

