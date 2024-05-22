namespace AdminBMS
{
    partial class Indigency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indigency));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            dataGridViewMyAllData = new DataGridView();
            deleteBtn = new Button();
            updateBtn = new Button();
            pictureBox2 = new PictureBox();
            indigencyIDTb = new Guna.UI2.WinForms.Guna2TextBox();
            nameTb = new Guna.UI2.WinForms.Guna2TextBox();
            ageTb = new Guna.UI2.WinForms.Guna2TextBox();
            parentTb = new Guna.UI2.WinForms.Guna2TextBox();
            addressTb = new Guna.UI2.WinForms.Guna2TextBox();
            purposeTb = new Guna.UI2.WinForms.Guna2TextBox();
            dateTb = new Guna.UI2.WinForms.Guna2TextBox();
            closeBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1209, 649);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridViewMyAllData
            // 
            dataGridViewMyAllData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMyAllData.Location = new Point(77, 173);
            dataGridViewMyAllData.Name = "dataGridViewMyAllData";
            dataGridViewMyAllData.RowHeadersWidth = 51;
            dataGridViewMyAllData.RowTemplate.Height = 29;
            dataGridViewMyAllData.Size = new Size(833, 320);
            dataGridViewMyAllData.TabIndex = 1;
            dataGridViewMyAllData.CellContentClick += dataGridViewMyAllData_CellContentClick;
            dataGridViewMyAllData.RowHeaderMouseClick += dataGridViewMyAllData_RowHeaderMouseClick;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(0, 130, 142);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = SystemColors.Control;
            deleteBtn.Location = new Point(962, 284);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(202, 29);
            deleteBtn.TabIndex = 10;
            deleteBtn.Text = "DELETE";
            deleteBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(0, 130, 142);
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(962, 351);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(202, 29);
            updateBtn.TabIndex = 11;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(249, 249, 249);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(117, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // indigencyIDTb
            // 
            indigencyIDTb.BorderColor = Color.FromArgb(0, 67, 105);
            indigencyIDTb.BorderRadius = 5;
            indigencyIDTb.CustomizableEdges = customizableEdges15;
            indigencyIDTb.DefaultText = "";
            indigencyIDTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            indigencyIDTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            indigencyIDTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            indigencyIDTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            indigencyIDTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            indigencyIDTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            indigencyIDTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            indigencyIDTb.Location = new Point(77, 545);
            indigencyIDTb.Margin = new Padding(3, 4, 3, 4);
            indigencyIDTb.Name = "indigencyIDTb";
            indigencyIDTb.PasswordChar = '\0';
            indigencyIDTb.PlaceholderText = "indigency number";
            indigencyIDTb.SelectedText = "";
            indigencyIDTb.ShadowDecoration.CustomizableEdges = customizableEdges16;
            indigencyIDTb.Size = new Size(135, 35);
            indigencyIDTb.TabIndex = 18;
            // 
            // nameTb
            // 
            nameTb.BorderColor = Color.FromArgb(0, 67, 105);
            nameTb.BorderRadius = 5;
            nameTb.CustomizableEdges = customizableEdges17;
            nameTb.DefaultText = "";
            nameTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameTb.Location = new Point(242, 545);
            nameTb.Margin = new Padding(3, 4, 3, 4);
            nameTb.Name = "nameTb";
            nameTb.PasswordChar = '\0';
            nameTb.PlaceholderText = "full name";
            nameTb.SelectedText = "";
            nameTb.ShadowDecoration.CustomizableEdges = customizableEdges18;
            nameTb.Size = new Size(154, 35);
            nameTb.TabIndex = 19;
            nameTb.TextAlign = HorizontalAlignment.Center;
            // 
            // ageTb
            // 
            ageTb.BorderColor = Color.FromArgb(0, 67, 105);
            ageTb.BorderRadius = 5;
            ageTb.CustomizableEdges = customizableEdges19;
            ageTb.DefaultText = "";
            ageTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ageTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ageTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ageTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ageTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ageTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ageTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ageTb.Location = new Point(419, 545);
            ageTb.Margin = new Padding(3, 4, 3, 4);
            ageTb.Name = "ageTb";
            ageTb.PasswordChar = '\0';
            ageTb.PlaceholderText = "age";
            ageTb.SelectedText = "";
            ageTb.ShadowDecoration.CustomizableEdges = customizableEdges20;
            ageTb.Size = new Size(87, 35);
            ageTb.TabIndex = 20;
            ageTb.TextAlign = HorizontalAlignment.Center;
            // 
            // parentTb
            // 
            parentTb.BorderColor = Color.FromArgb(0, 67, 105);
            parentTb.BorderRadius = 5;
            parentTb.CustomizableEdges = customizableEdges21;
            parentTb.DefaultText = "";
            parentTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            parentTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            parentTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            parentTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            parentTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            parentTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            parentTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            parentTb.Location = new Point(525, 545);
            parentTb.Margin = new Padding(3, 4, 3, 4);
            parentTb.Name = "parentTb";
            parentTb.PasswordChar = '\0';
            parentTb.PlaceholderText = "parents/guardian";
            parentTb.SelectedText = "";
            parentTb.ShadowDecoration.CustomizableEdges = customizableEdges22;
            parentTb.Size = new Size(205, 35);
            parentTb.TabIndex = 21;
            parentTb.TextAlign = HorizontalAlignment.Center;
            // 
            // addressTb
            // 
            addressTb.BorderColor = Color.FromArgb(0, 67, 105);
            addressTb.BorderRadius = 5;
            addressTb.CustomizableEdges = customizableEdges23;
            addressTb.DefaultText = "";
            addressTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            addressTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            addressTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            addressTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            addressTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            addressTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addressTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            addressTb.Location = new Point(736, 545);
            addressTb.Margin = new Padding(3, 4, 3, 4);
            addressTb.Name = "addressTb";
            addressTb.PasswordChar = '\0';
            addressTb.PlaceholderText = "address";
            addressTb.SelectedText = "";
            addressTb.ShadowDecoration.CustomizableEdges = customizableEdges24;
            addressTb.Size = new Size(160, 35);
            addressTb.TabIndex = 22;
            addressTb.TextAlign = HorizontalAlignment.Center;
            // 
            // purposeTb
            // 
            purposeTb.BorderColor = Color.FromArgb(0, 67, 105);
            purposeTb.BorderRadius = 5;
            purposeTb.CustomizableEdges = customizableEdges25;
            purposeTb.DefaultText = "";
            purposeTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            purposeTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            purposeTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            purposeTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            purposeTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            purposeTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            purposeTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            purposeTb.Location = new Point(911, 545);
            purposeTb.Margin = new Padding(3, 4, 3, 4);
            purposeTb.Name = "purposeTb";
            purposeTb.PasswordChar = '\0';
            purposeTb.PlaceholderText = "purpose";
            purposeTb.SelectedText = "";
            purposeTb.ShadowDecoration.CustomizableEdges = customizableEdges26;
            purposeTb.Size = new Size(137, 35);
            purposeTb.TabIndex = 23;
            purposeTb.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTb
            // 
            dateTb.BorderColor = Color.FromArgb(0, 67, 105);
            dateTb.BorderRadius = 5;
            dateTb.CustomizableEdges = customizableEdges27;
            dateTb.DefaultText = "";
            dateTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            dateTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            dateTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            dateTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            dateTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            dateTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            dateTb.Location = new Point(1074, 545);
            dateTb.Margin = new Padding(3, 4, 3, 4);
            dateTb.Name = "dateTb";
            dateTb.PasswordChar = '\0';
            dateTb.PlaceholderText = "date";
            dateTb.SelectedText = "";
            dateTb.ShadowDecoration.CustomizableEdges = customizableEdges28;
            dateTb.Size = new Size(111, 35);
            dateTb.TabIndex = 24;
            dateTb.TextAlign = HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(249, 249, 249);
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(66, 110);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(45, 46);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 25;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // Indigency
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 643);
            Controls.Add(closeBtn);
            Controls.Add(dateTb);
            Controls.Add(purposeTb);
            Controls.Add(addressTb);
            Controls.Add(parentTb);
            Controls.Add(ageTb);
            Controls.Add(nameTb);
            Controls.Add(indigencyIDTb);
            Controls.Add(pictureBox2);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(dataGridViewMyAllData);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Indigency";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Indigency";
            Load += Indigency_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridViewMyAllData;
        private Button deleteBtn;
        private Button updateBtn;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox indigencyIDTb;
        private Guna.UI2.WinForms.Guna2TextBox nameTb;
        private Guna.UI2.WinForms.Guna2TextBox ageTb;
        private Guna.UI2.WinForms.Guna2TextBox parentTb;
        private Guna.UI2.WinForms.Guna2TextBox addressTb;
        private Guna.UI2.WinForms.Guna2TextBox purposeTb;
        private Guna.UI2.WinForms.Guna2TextBox dateTb;
        private PictureBox closeBtn;
    }
}