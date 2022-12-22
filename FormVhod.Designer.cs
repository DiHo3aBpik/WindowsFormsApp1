namespace WindowsFormsApp1
{
    partial class FormVhod
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
            this.bvhod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lreg = new System.Windows.Forms.Label();
            this.tlog = new System.Windows.Forms.TextBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lCapcha = new System.Windows.Forms.Label();
            this.tCapcha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bvhod
            // 
            this.bvhod.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bvhod.Location = new System.Drawing.Point(148, 250);
            this.bvhod.Name = "bvhod";
            this.bvhod.Size = new System.Drawing.Size(74, 31);
            this.bvhod.TabIndex = 0;
            this.bvhod.Text = "Войти";
            this.bvhod.UseVisualStyleBackColor = true;
            this.bvhod.Click += new System.EventHandler(this.bvhod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lreg
            // 
            this.lreg.AutoSize = true;
            this.lreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.lreg.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lreg.Location = new System.Drawing.Point(109, 292);
            this.lreg.Name = "lreg";
            this.lreg.Size = new System.Drawing.Size(160, 22);
            this.lreg.TabIndex = 3;
            this.lreg.Text = "Зарегестрироваться";
            this.lreg.Click += new System.EventHandler(this.lreg_Click);
            // 
            // tlog
            // 
            this.tlog.Location = new System.Drawing.Point(148, 68);
            this.tlog.Name = "tlog";
            this.tlog.Size = new System.Drawing.Size(99, 20);
            this.tlog.TabIndex = 4;
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(148, 96);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(99, 20);
            this.tpass.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 62);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(89)))), ((int)(((byte)(139)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 74);
            this.panel2.TabIndex = 9;
            // 
            // lCapcha
            // 
            this.lCapcha.AutoSize = true;
            this.lCapcha.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCapcha.Location = new System.Drawing.Point(180, 172);
            this.lCapcha.Name = "lCapcha";
            this.lCapcha.Size = new System.Drawing.Size(0, 22);
            this.lCapcha.TabIndex = 21;
            // 
            // tCapcha
            // 
            this.tCapcha.Location = new System.Drawing.Point(134, 214);
            this.tCapcha.Name = "tCapcha";
            this.tCapcha.Size = new System.Drawing.Size(100, 20);
            this.tCapcha.TabIndex = 20;
            this.tCapcha.TextChanged += new System.EventHandler(this.tCapcha_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormVhod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 413);
            this.Controls.Add(this.lCapcha);
            this.Controls.Add(this.tCapcha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tlog);
            this.Controls.Add(this.lreg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bvhod);
            this.Name = "FormVhod";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bvhod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lreg;
        private System.Windows.Forms.TextBox tlog;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lCapcha;
        private System.Windows.Forms.TextBox tCapcha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

