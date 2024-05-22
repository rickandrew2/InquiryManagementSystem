namespace AdminBMS
{
    partial class ManagePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePage));
            pictureBox1 = new PictureBox();
            managePSR = new Button();
            manageRC = new Button();
            manageDR = new Button();
            backBtn = new PictureBox();
            closeBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1209, 645);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // managePSR
            // 
            managePSR.BackColor = Color.FromArgb(0, 130, 142);
            managePSR.FlatAppearance.BorderSize = 0;
            managePSR.FlatStyle = FlatStyle.Flat;
            managePSR.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            managePSR.ForeColor = SystemColors.ButtonHighlight;
            managePSR.Location = new Point(549, 529);
            managePSR.Name = "managePSR";
            managePSR.Size = new Size(202, 29);
            managePSR.TabIndex = 2;
            managePSR.Text = "MANAGE";
            managePSR.UseVisualStyleBackColor = false;
            managePSR.Click += button2_Click;
            // 
            // manageRC
            // 
            manageRC.BackColor = Color.FromArgb(0, 130, 142);
            manageRC.FlatAppearance.BorderSize = 0;
            manageRC.FlatStyle = FlatStyle.Flat;
            manageRC.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            manageRC.ForeColor = SystemColors.ButtonHighlight;
            manageRC.Location = new Point(876, 529);
            manageRC.Name = "manageRC";
            manageRC.Size = new Size(207, 29);
            manageRC.TabIndex = 3;
            manageRC.Text = "MANAGE";
            manageRC.UseVisualStyleBackColor = false;
            manageRC.Click += manageRC_Click;
            // 
            // manageDR
            // 
            manageDR.BackColor = Color.FromArgb(0, 130, 142);
            manageDR.FlatAppearance.BorderSize = 0;
            manageDR.FlatStyle = FlatStyle.Flat;
            manageDR.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            manageDR.ForeColor = SystemColors.ButtonHighlight;
            manageDR.Location = new Point(213, 529);
            manageDR.Name = "manageDR";
            manageDR.Size = new Size(200, 29);
            manageDR.TabIndex = 4;
            manageDR.Text = "MANAGE";
            manageDR.UseVisualStyleBackColor = false;
            manageDR.Click += manageDR_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(249, 249, 249);
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(63, 112);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(45, 46);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 10;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(249, 249, 249);
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(12, 112);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(45, 46);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 11;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // ManagePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 643);
            Controls.Add(closeBtn);
            Controls.Add(backBtn);
            Controls.Add(manageDR);
            Controls.Add(manageRC);
            Controls.Add(managePSR);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagePage";
            Load += ManagePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button managePSR;
        private Button manageRC;
        private Button manageDR;
        private PictureBox backBtn;
        private PictureBox closeBtn;
    }
}