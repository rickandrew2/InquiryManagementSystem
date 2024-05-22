namespace AdminBMS
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            toManageBtn = new Button();
            pictureBox1 = new PictureBox();
            backBtn = new PictureBox();
            closeBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            SuspendLayout();
            // 
            // toManageBtn
            // 
            toManageBtn.BackColor = Color.FromArgb(0, 130, 142);
            toManageBtn.FlatAppearance.BorderSize = 0;
            toManageBtn.FlatStyle = FlatStyle.Flat;
            toManageBtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toManageBtn.ForeColor = SystemColors.ButtonFace;
            toManageBtn.Location = new Point(898, 540);
            toManageBtn.Name = "toManageBtn";
            toManageBtn.Size = new Size(207, 29);
            toManageBtn.TabIndex = 1;
            toManageBtn.Text = "Get Started";
            toManageBtn.UseVisualStyleBackColor = false;
            toManageBtn.Click += toManageBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1209, 645);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(249, 249, 249);
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(63, 120);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(45, 46);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 9;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(249, 249, 249);
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(12, 120);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(45, 46);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 10;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 643);
            Controls.Add(closeBtn);
            Controls.Add(backBtn);
            Controls.Add(toManageBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMain";
            Load += AdminMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button toManageBtn;
        private PictureBox pictureBox1;
        private PictureBox backBtn;
        private PictureBox closeBtn;
    }
}