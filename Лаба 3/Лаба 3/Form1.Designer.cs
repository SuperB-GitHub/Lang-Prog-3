namespace Лаба_3
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
            this.Инфо = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Massive = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Massive)).BeginInit();
            this.SuspendLayout();
            // 
            // Инфо
            // 
            this.Инфо.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Инфо.BackColor = System.Drawing.Color.MediumPurple;
            this.Инфо.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Инфо.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Инфо.Location = new System.Drawing.Point(12, 12);
            this.Инфо.Name = "Инфо";
            this.Инфо.ReadOnly = true;
            this.Инфо.Size = new System.Drawing.Size(960, 78);
            this.Инфо.TabIndex = 1;
            this.Инфо.TabStop = false;
            this.Инфо.Text = "7. Организуйте в Windows приложении ввод и вывод матрицы - двумерного массива ари" +
    "фметического типа. Реализовать систему автоматического заполнения массива случай" +
    "ными числами.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(679, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Очистить массив";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Massive
            // 
            this.Massive.AllowUserToDeleteRows = false;
            this.Massive.AllowUserToResizeColumns = false;
            this.Massive.AllowUserToResizeRows = false;
            this.Massive.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.Massive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Massive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Massive.ColumnHeadersVisible = false;
            this.Massive.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Massive.Location = new System.Drawing.Point(12, 118);
            this.Massive.Name = "Massive";
            this.Massive.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Massive.RowHeadersVisible = false;
            this.Massive.RowHeadersWidth = 30;
            this.Massive.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Massive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Massive.Size = new System.Drawing.Size(600, 228);
            this.Massive.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(679, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "Заполнить рандомно";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Massive);
            this.Controls.Add(this.Инфо);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лаба №3 Вариант 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Massive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox Инфо;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Massive;
        private System.Windows.Forms.Button button2;
    }
}

