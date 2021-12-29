
namespace WinFormsApp1
{
    partial class Меню
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
            this.prvtbuss = new System.Windows.Forms.Button();
            this.inform = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            // 
            // prvtbuss
            // 
            this.prvtbuss.BackColor = System.Drawing.Color.White;
            this.prvtbuss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prvtbuss.Location = new System.Drawing.Point(298, 201);
            this.prvtbuss.Name = "prvtbuss";
            this.prvtbuss.Size = new System.Drawing.Size(264, 56);
            this.prvtbuss.TabIndex = 1;
            this.prvtbuss.Text = "Личное дело абитриента";
            this.prvtbuss.UseVisualStyleBackColor = false;
            this.prvtbuss.Click += new System.EventHandler(this.prvtbuss_Click);
            // 
            // inform
            // 
            this.inform.BackColor = System.Drawing.Color.White;
            this.inform.FlatAppearance.BorderSize = 2;
            this.inform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inform.Location = new System.Drawing.Point(298, 275);
            this.inform.Name = "inform";
            this.inform.Size = new System.Drawing.Size(264, 56);
            this.inform.TabIndex = 2;
            this.inform.Text = "Информация об образовании и успеваемости";
            this.inform.UseVisualStyleBackColor = false;
            this.inform.Click += new System.EventHandler(this.inform_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.icons8_стрелка__указывающая_влево_96;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Меню
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(163)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(883, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inform);
            this.Controls.Add(this.prvtbuss);
            this.Controls.Add(this.label1);
            this.Name = "Меню";
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Меню_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prvtbuss;
        private System.Windows.Forms.Button inform;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}