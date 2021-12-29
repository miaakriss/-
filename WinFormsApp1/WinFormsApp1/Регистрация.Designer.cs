
namespace WinFormsApp1
{
    partial class Регистрация
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3reg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(325, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 27);
            this.textBox3.TabIndex = 5;
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(325, 305);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(250, 27);
            this.textBox7.TabIndex = 9;
            this.textBox7.Click += new System.EventHandler(this.textBox7_Click);
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button3reg
            // 
            this.button3reg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(220)))), ((int)(((byte)(198)))));
            this.button3reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3reg.Location = new System.Drawing.Point(325, 420);
            this.button3reg.Name = "button3reg";
            this.button3reg.Size = new System.Drawing.Size(250, 29);
            this.button3reg.TabIndex = 14;
            this.button3reg.Text = "Зарегистрироваться";
            this.button3reg.UseVisualStyleBackColor = false;
            this.button3reg.Click += new System.EventHandler(this.button3reg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(334, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите ваш логин";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(334, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Придумайте пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(334, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Электронная почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(334, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Потверждение пароля";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(376, 351);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 27);
            this.textBox4.TabIndex = 19;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(385, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.icons8_стрелка__указывающая_влево_96;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3reg);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Регистрация";
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Регистрация_FormClosed);
            this.Load += new System.EventHandler(this.Регистрация_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}