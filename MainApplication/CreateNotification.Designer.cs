namespace MainApplication
{
    partial class CreateNotification
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
            btnCancel = new Button();
            btnCreate = new Button();
            lblMessageTitle = new Label();
            tbMessageTitle = new TextBox();
            rtbMessage = new RichTextBox();
            lblMessage = new Label();
            lblCourse = new Label();
            cbCourse = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(35, 398);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(128, 42);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Zatvori";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(234, 398);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(128, 42);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Stvori";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblMessageTitle
            // 
            lblMessageTitle.AutoSize = true;
            lblMessageTitle.Location = new Point(35, 35);
            lblMessageTitle.Name = "lblMessageTitle";
            lblMessageTitle.Size = new Size(54, 20);
            lblMessageTitle.TabIndex = 2;
            lblMessageTitle.Text = "Naslov";
            // 
            // tbMessageTitle
            // 
            tbMessageTitle.Location = new Point(111, 32);
            tbMessageTitle.Name = "tbMessageTitle";
            tbMessageTitle.Size = new Size(238, 27);
            tbMessageTitle.TabIndex = 3;
            // 
            // rtbMessage
            // 
            rtbMessage.Location = new Point(35, 111);
            rtbMessage.Name = "rtbMessage";
            rtbMessage.Size = new Size(314, 197);
            rtbMessage.TabIndex = 4;
            rtbMessage.Text = "";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(35, 84);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(53, 20);
            lblMessage.TabIndex = 5;
            lblMessage.Text = "Poruka";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(35, 337);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(56, 20);
            lblCourse.TabIndex = 6;
            lblCourse.Text = "Kolegij";
            // 
            // cbCourse
            // 
            cbCourse.Cursor = Cursors.Hand;
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(97, 334);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(252, 28);
            cbCourse.Sorted = true;
            cbCourse.TabIndex = 7;
            cbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // CreateNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 470);
            Controls.Add(cbCourse);
            Controls.Add(lblCourse);
            Controls.Add(lblMessage);
            Controls.Add(rtbMessage);
            Controls.Add(tbMessageTitle);
            Controls.Add(lblMessageTitle);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Name = "CreateNotification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravitelj obavijesti";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnCreate;
        private Label lblMessageTitle;
        private TextBox tbMessageTitle;
        private RichTextBox rtbMessage;
        private Label lblMessage;
        private Label lblCourse;
        private ComboBox cbCourse;
    }
}