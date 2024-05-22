namespace AdminBMS
{
    partial class ChooseDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseDoc));
            toDRBtn = new Button();
            toBRBtn = new Button();
            toIndBtn = new Button();
            toBCBtn = new Button();
            backBtn = new PictureBox();
            closeBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            SuspendLayout();
            // 
            // toDRBtn
            // 
            toDRBtn.BackColor = Color.FromArgb(0, 130, 142);
            toDRBtn.FlatAppearance.BorderSize = 0;
            toDRBtn.FlatStyle = FlatStyle.Flat;
            toDRBtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toDRBtn.ForeColor = SystemColors.ButtonHighlight;
            toDRBtn.Location = new Point(379, 324);
            toDRBtn.Name = "toDRBtn";
            toDRBtn.Size = new Size(102, 52);
            toDRBtn.TabIndex = 4;
            toDRBtn.Text = "MANAGE";
            toDRBtn.UseVisualStyleBackColor = false;
            toDRBtn.Click += toDRBtn_Click;
            // 
            // toBRBtn
            // 
            toBRBtn.BackColor = Color.FromArgb(0, 130, 142);
            toBRBtn.FlatAppearance.BorderSize = 0;
            toBRBtn.FlatStyle = FlatStyle.Flat;
            toBRBtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toBRBtn.ForeColor = SystemColors.ButtonHighlight;
            toBRBtn.Location = new Point(781, 332);
            toBRBtn.Name = "toBRBtn";
            toBRBtn.Size = new Size(96, 44);
            toBRBtn.TabIndex = 5;
            toBRBtn.Text = "MANAGE";
            toBRBtn.UseVisualStyleBackColor = false;
            toBRBtn.Click += toBRBtn_Click;
            // 
            // toIndBtn
            // 
            toIndBtn.BackColor = Color.FromArgb(0, 130, 142);
            toIndBtn.FlatAppearance.BorderSize = 0;
            toIndBtn.FlatStyle = FlatStyle.Flat;
            toIndBtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toIndBtn.ForeColor = SystemColors.ButtonHighlight;
            toIndBtn.Location = new Point(384, 498);
            toIndBtn.Name = "toIndBtn";
            toIndBtn.Size = new Size(97, 51);
            toIndBtn.TabIndex = 6;
            toIndBtn.Text = "MANAGE";
            toIndBtn.UseVisualStyleBackColor = false;
            toIndBtn.Click += toIndBtn_Click;
            // 
            // toBCBtn
            // 
            toBCBtn.BackColor = Color.FromArgb(0, 130, 142);
            toBCBtn.FlatAppearance.BorderSize = 0;
            toBCBtn.FlatStyle = FlatStyle.Flat;
            toBCBtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toBCBtn.ForeColor = SystemColors.ButtonHighlight;
            toBCBtn.Location = new Point(781, 505);
            toBCBtn.Name = "toBCBtn";
            toBCBtn.Size = new Size(96, 44);
            toBCBtn.TabIndex = 7;
            toBCBtn.Text = "MANAGE";
            toBCBtn.UseVisualStyleBackColor = false;
            toBCBtn.Click += toBCBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(249, 249, 249);
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(63, 111);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(45, 46);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 8;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(249, 249, 249);
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(12, 111);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(45, 46);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 12;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // ChooseDoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 645);
            Controls.Add(closeBtn);
            Controls.Add(backBtn);
            Controls.Add(toBCBtn);
            Controls.Add(toIndBtn);
            Controls.Add(toBRBtn);
            Controls.Add(toDRBtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChooseDoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseDoc";
            Load += ChooseDoc_Load;
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button toDRBtn;
        private Button toBRBtn;
        private Button toIndBtn;
        private Button toBCBtn;
        private PictureBox backBtn;
        private PictureBox closeBtn;
    }
}