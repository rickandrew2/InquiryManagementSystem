namespace AdminBMS
{
    partial class DocReq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocReq));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            updateBtn = new Button();
            label1 = new Label();
            dataGridViewMyAllData = new DataGridView();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            deleteBtn = new Button();
            pictureBox1 = new PictureBox();
            backBtn = new PictureBox();
            docIDTb = new Guna.UI2.WinForms.Guna2TextBox();
            requesterTb = new Guna.UI2.WinForms.Guna2TextBox();
            docTypeTb = new Guna.UI2.WinForms.Guna2TextBox();
            requestDateTb = new Guna.UI2.WinForms.Guna2TextBox();
            statusTb = new Guna.UI2.WinForms.Guna2TextBox();
            closeBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(0, 130, 142);
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(943, 358);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(201, 29);
            updateBtn.TabIndex = 2;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 358);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 7;
            label1.Text = "DocReq ID";
            // 
            // dataGridViewMyAllData
            // 
            dataGridViewMyAllData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMyAllData.Location = new Point(67, 177);
            dataGridViewMyAllData.Name = "dataGridViewMyAllData";
            dataGridViewMyAllData.RowHeadersWidth = 51;
            dataGridViewMyAllData.RowTemplate.Height = 29;
            dataGridViewMyAllData.Size = new Size(828, 317);
            dataGridViewMyAllData.TabIndex = 13;
            dataGridViewMyAllData.CellContentClick += dataGridViewMyAllData_CellContentClick;
            dataGridViewMyAllData.RowHeaderMouseClick += dataGridViewMyAllData_RowHeaderMouseClick;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(0, 130, 142);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtn.ForeColor = SystemColors.ButtonHighlight;
            deleteBtn.Location = new Point(943, 283);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(201, 37);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "DELETE";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1209, 645);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(249, 249, 249);
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(98, 114);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(45, 46);
            backBtn.SizeMode = PictureBoxSizeMode.Zoom;
            backBtn.TabIndex = 18;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // docIDTb
            // 
            docIDTb.BorderColor = Color.FromArgb(0, 67, 105);
            docIDTb.BorderRadius = 5;
            docIDTb.CustomizableEdges = customizableEdges1;
            docIDTb.DefaultText = "";
            docIDTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            docIDTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            docIDTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            docIDTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            docIDTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            docIDTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            docIDTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            docIDTb.Location = new Point(76, 550);
            docIDTb.Margin = new Padding(3, 4, 3, 4);
            docIDTb.Name = "docIDTb";
            docIDTb.PasswordChar = '\0';
            docIDTb.PlaceholderText = "document request #";
            docIDTb.SelectedText = "";
            docIDTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            docIDTb.Size = new Size(178, 35);
            docIDTb.TabIndex = 19;
            // 
            // requesterTb
            // 
            requesterTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            requesterTb.BorderColor = Color.FromArgb(0, 67, 105);
            requesterTb.BorderRadius = 5;
            requesterTb.CustomizableEdges = customizableEdges3;
            requesterTb.DefaultText = "";
            requesterTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            requesterTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            requesterTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            requesterTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            requesterTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            requesterTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            requesterTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            requesterTb.Location = new Point(301, 550);
            requesterTb.Margin = new Padding(3, 4, 3, 4);
            requesterTb.Name = "requesterTb";
            requesterTb.PasswordChar = '\0';
            requesterTb.PlaceholderText = "requester name";
            requesterTb.SelectedText = "";
            requesterTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            requesterTb.Size = new Size(215, 35);
            requesterTb.TabIndex = 20;
            requesterTb.TextAlign = HorizontalAlignment.Center;
            // 
            // docTypeTb
            // 
            docTypeTb.BorderColor = Color.FromArgb(0, 67, 105);
            docTypeTb.BorderRadius = 5;
            docTypeTb.CustomizableEdges = customizableEdges5;
            docTypeTb.DefaultText = "";
            docTypeTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            docTypeTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            docTypeTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            docTypeTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            docTypeTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            docTypeTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            docTypeTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            docTypeTb.Location = new Point(572, 550);
            docTypeTb.Margin = new Padding(3, 4, 3, 4);
            docTypeTb.Name = "docTypeTb";
            docTypeTb.PasswordChar = '\0';
            docTypeTb.PlaceholderText = "document type";
            docTypeTb.SelectedText = "";
            docTypeTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            docTypeTb.Size = new Size(194, 35);
            docTypeTb.TabIndex = 21;
            docTypeTb.TextAlign = HorizontalAlignment.Center;
            // 
            // requestDateTb
            // 
            requestDateTb.BorderColor = Color.FromArgb(0, 67, 105);
            requestDateTb.BorderRadius = 5;
            requestDateTb.CustomizableEdges = customizableEdges7;
            requestDateTb.DefaultText = "";
            requestDateTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            requestDateTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            requestDateTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            requestDateTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            requestDateTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            requestDateTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            requestDateTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            requestDateTb.Location = new Point(796, 550);
            requestDateTb.Margin = new Padding(3, 4, 3, 4);
            requestDateTb.Name = "requestDateTb";
            requestDateTb.PasswordChar = '\0';
            requestDateTb.PlaceholderText = "date of request";
            requestDateTb.SelectedText = "";
            requestDateTb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            requestDateTb.Size = new Size(194, 35);
            requestDateTb.TabIndex = 22;
            requestDateTb.TextAlign = HorizontalAlignment.Center;
            // 
            // statusTb
            // 
            statusTb.BorderColor = Color.FromArgb(0, 67, 105);
            statusTb.BorderRadius = 5;
            statusTb.CustomizableEdges = customizableEdges9;
            statusTb.DefaultText = "";
            statusTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            statusTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            statusTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            statusTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            statusTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            statusTb.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            statusTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            statusTb.Location = new Point(1018, 550);
            statusTb.Margin = new Padding(3, 4, 3, 4);
            statusTb.Name = "statusTb";
            statusTb.PasswordChar = '\0';
            statusTb.PlaceholderText = "status";
            statusTb.SelectedText = "";
            statusTb.ShadowDecoration.CustomizableEdges = customizableEdges10;
            statusTb.Size = new Size(158, 35);
            statusTb.TabIndex = 23;
            statusTb.TextAlign = HorizontalAlignment.Center;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(249, 249, 249);
            closeBtn.Image = (Image)resources.GetObject("closeBtn.Image");
            closeBtn.Location = new Point(47, 114);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(45, 46);
            closeBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeBtn.TabIndex = 24;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // DocReq
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 643);
            Controls.Add(closeBtn);
            Controls.Add(statusTb);
            Controls.Add(requestDateTb);
            Controls.Add(docTypeTb);
            Controls.Add(requesterTb);
            Controls.Add(docIDTb);
            Controls.Add(backBtn);
            Controls.Add(deleteBtn);
            Controls.Add(dataGridViewMyAllData);
            Controls.Add(label1);
            Controls.Add(updateBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DocReq";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DocReq";
            Load += DocReq_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyAllData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button updateBtn;
        private Label label1;
        private DataGridView dataGridViewMyAllData;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private Button deleteBtn;
        private PictureBox pictureBox1;
        private PictureBox backBtn;
        private Guna.UI2.WinForms.Guna2TextBox docIDTb;
        private Guna.UI2.WinForms.Guna2TextBox requesterTb;
        private Guna.UI2.WinForms.Guna2TextBox docTypeTb;
        private Guna.UI2.WinForms.Guna2TextBox requestDateTb;
        private Guna.UI2.WinForms.Guna2TextBox statusTb;
        private PictureBox closeBtn;
    }
}