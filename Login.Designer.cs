namespace LeaveManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClosedLb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.UNameTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedLb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.ClosedLb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 100);
            this.panel1.TabIndex = 0;
            // 
            // ClosedLb
            // 
            this.ClosedLb.Image = ((System.Drawing.Image)(resources.GetObject("ClosedLb.Image")));
            this.ClosedLb.Location = new System.Drawing.Point(535, 12);
            this.ClosedLb.Name = "ClosedLb";
            this.ClosedLb.Size = new System.Drawing.Size(38, 34);
            this.ClosedLb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosedLb.TabIndex = 3;
            this.ClosedLb.TabStop = false;
            this.ClosedLb.Click += new System.EventHandler(this.ClosedLb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Leave Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(197)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 536);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 48);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName";
            // 
            // UNameTb
            // 
            this.UNameTb.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNameTb.Location = new System.Drawing.Point(118, 242);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.Size = new System.Drawing.Size(337, 27);
            this.UNameTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(118, 316);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(337, 27);
            this.PasswordTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(192, 464);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(165, 49);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(192, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(594, 584);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosedLb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UNameTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ClosedLb;
    }
}

