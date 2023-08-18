namespace MainApplication
{
    partial class LogOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogOut = new Button();
            btnExitApp = new Button();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(3, 26);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(239, 41);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Odjavi se";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnExitApp
            // 
            btnExitApp.Location = new Point(3, 73);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(239, 41);
            btnExitApp.TabIndex = 1;
            btnExitApp.Text = "Izađi iz aplikacije";
            btnExitApp.UseVisualStyleBackColor = true;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // LogOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            Controls.Add(btnExitApp);
            Controls.Add(btnLogOut);
            Name = "LogOut";
            Size = new Size(245, 118);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogOut;
        private Button btnExitApp;
    }
}
