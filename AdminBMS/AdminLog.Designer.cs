namespace AdminBMS
{
    partial class AdminLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLog));
            pictureBox1 = new PictureBox();
            usernameTb = new TextBox();
            passwordTb = new TextBox();
            button1 = new Button();
            showPass = new Guna.UI2.WinForms.Guna2CheckBox();
            closeBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1209, 645);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // usernameTb
            // 
            usernameTb.BorderStyle = BorderStyle.None;
            usernameTb.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTb.Location = new Point(535, 374);
            usernameTb.Name = "usernameTb";
            usernameTb.Size = new Size(319, 19);
            usernameTb.TabIndex = 1;
            // 
            // passwordTb
            // 
            passwordTb.BorderStyle = BorderStyle.None;
            passwordTb.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTb.Location = new Point(535, 442);
            passwordTb.Name = "passwordTb";
            passwordTb.Size = new Size(319, 19);
            passwordTb.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 67, 105);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(568, 503);
            button1.Name = "button1";
            button1.Size = new Size(206, 35);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.BackColor = Color.White;
            showPass.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            showPass.CheckedState.BorderRadius = 0;
            showPass.CheckedState.BorderThickness = 0;
            showPass.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            showPass.CheckMarkColor = Color.Black;
            showPass.Location = new Point(883, 438);
            showPass.Name = "showPass";
            showPass.Size = new Size(18, 17);
            showPass.TabIndex = 6;
            showPass.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            showPass.UncheckedState.BorderRadius = 0;
            showPass.UncheckedState.BorderThickness = 0;
            showPass.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            showPass.UseVisualStyleBackColor = false;
            showPass.CheckedChanged += guna2CheckBox1_CheckedChanged;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(140, 192, 194);
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(82, 21);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(45, 46);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 11;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // AdminLog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 643);
            Controls.Add(closeBtn);
            Controls.Add(showPass);
            Controls.Add(button1);
            Controls.Add(passwordTb);
            Controls.Add(usernameTb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLog";
            Load += AdminLog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox usernameTb;
        private TextBox passwordTb;
        private Button button1;
        private Guna.UI2.WinForms.Guna2CheckBox showPass;
        private PictureBox closeBtn;
    }
}