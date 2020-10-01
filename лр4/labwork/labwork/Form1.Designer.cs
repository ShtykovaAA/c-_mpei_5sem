namespace labwork
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
            this.label2 = new System.Windows.Forms.Label();
            this.RowCount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaxELem = new System.Windows.Forms.Button();
            this.IsMaxELemOnTheMainDiagonal = new System.Windows.Forms.Button();
            this.MaxELement = new System.Windows.Forms.TextBox();
            this.IsCorrect = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер квадратной матрицы";
            // 
            // RowCount
            // 
            this.RowCount.Location = new System.Drawing.Point(348, 33);
            this.RowCount.Name = "RowCount";
            this.RowCount.Size = new System.Drawing.Size(100, 26);
            this.RowCount.TabIndex = 4;
            this.RowCount.TextChanged += new System.EventHandler(this.RowCount_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(735, 251);
            this.dataGridView1.TabIndex = 5;
            // 
            // MaxELem
            // 
            this.MaxELem.Location = new System.Drawing.Point(81, 391);
            this.MaxELem.Name = "MaxELem";
            this.MaxELem.Size = new System.Drawing.Size(319, 70);
            this.MaxELem.TabIndex = 6;
            this.MaxELem.Text = "MaxELem";
            this.MaxELem.UseVisualStyleBackColor = true;
            this.MaxELem.Click += new System.EventHandler(this.MaxELem_Click);
            // 
            // IsMaxELemOnTheMainDiagonal
            // 
            this.IsMaxELemOnTheMainDiagonal.Location = new System.Drawing.Point(81, 498);
            this.IsMaxELemOnTheMainDiagonal.Name = "IsMaxELemOnTheMainDiagonal";
            this.IsMaxELemOnTheMainDiagonal.Size = new System.Drawing.Size(319, 72);
            this.IsMaxELemOnTheMainDiagonal.TabIndex = 7;
            this.IsMaxELemOnTheMainDiagonal.Text = "IsMaxELemOnTheMainDiagonal";
            this.IsMaxELemOnTheMainDiagonal.UseVisualStyleBackColor = true;
            this.IsMaxELemOnTheMainDiagonal.Click += new System.EventHandler(this.IsMaxELemOnTheMainDiagonal_Click);
            // 
            // MaxELement
            // 
            this.MaxELement.Location = new System.Drawing.Point(426, 413);
            this.MaxELement.Name = "MaxELement";
            this.MaxELement.Size = new System.Drawing.Size(100, 26);
            this.MaxELement.TabIndex = 8;
            // 
            // IsCorrect
            // 
            this.IsCorrect.Location = new System.Drawing.Point(426, 521);
            this.IsCorrect.Name = "IsCorrect";
            this.IsCorrect.Size = new System.Drawing.Size(100, 26);
            this.IsCorrect.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "NewMassC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(426, 647);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(434, 26);
            this.Output.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IsCorrect);
            this.Controls.Add(this.MaxELement);
            this.Controls.Add(this.IsMaxELemOnTheMainDiagonal);
            this.Controls.Add(this.MaxELem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RowCount);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RowCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MaxELem;
        private System.Windows.Forms.Button IsMaxELemOnTheMainDiagonal;
        private System.Windows.Forms.TextBox MaxELement;
        private System.Windows.Forms.TextBox IsCorrect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Output;
    }
}

