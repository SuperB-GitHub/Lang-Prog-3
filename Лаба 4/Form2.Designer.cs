namespace Лаба_4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ToForm3 = new System.Windows.Forms.Button();
            this.ToForm1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToForm3
            // 
            this.ToForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToForm3.Location = new System.Drawing.Point(12, 116);
            this.ToForm3.Name = "ToForm3";
            this.ToForm3.Size = new System.Drawing.Size(153, 46);
            this.ToForm3.TabIndex = 6;
            this.ToForm3.Text = "Рисование примитивов";
            this.ToForm3.UseVisualStyleBackColor = true;
            this.ToForm3.Click += new System.EventHandler(this.ToForm3_Click);
            // 
            // ToForm1
            // 
            this.ToForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToForm1.Location = new System.Drawing.Point(12, 64);
            this.ToForm1.Name = "ToForm1";
            this.ToForm1.Size = new System.Drawing.Size(153, 46);
            this.ToForm1.TabIndex = 5;
            this.ToForm1.Text = "Рисование графиков";
            this.ToForm1.UseVisualStyleBackColor = true;
            this.ToForm1.Click += new System.EventHandler(this.ToForm1_Click);
            this.ToForm1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.ToForm1.Resize += new System.EventHandler(this.Form2_Resize);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ToForm3);
            this.Controls.Add(this.ToForm1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анимация графиков";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToForm3;
        private System.Windows.Forms.Button ToForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}