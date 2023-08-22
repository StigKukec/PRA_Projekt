namespace MainApplication
{
    partial class CourseManagerForm
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
            label1 = new Label();
            label2 = new Label();
            tbSubjectTitle = new TextBox();
            btnProceed = new Button();
            btnCancel = new Button();
            nudEctsNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudEctsNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 24);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Naziv kolegija:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 98);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Broj ECTS";
            // 
            // tbSubjectTitle
            // 
            tbSubjectTitle.Location = new Point(35, 47);
            tbSubjectTitle.Name = "tbSubjectTitle";
            tbSubjectTitle.Size = new Size(228, 27);
            tbSubjectTitle.TabIndex = 2;
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(164, 210);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(118, 44);
            btnProceed.TabIndex = 4;
            btnProceed.Text = "Stvori";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += BtnProceed_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 44);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Zatvori";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // nudEctsNumber
            // 
            nudEctsNumber.Location = new Point(105, 130);
            nudEctsNumber.Name = "nudEctsNumber";
            nudEctsNumber.Size = new Size(73, 27);
            nudEctsNumber.TabIndex = 6;
            // 
            // CourseManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 263);
            Controls.Add(nudEctsNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnProceed);
            Controls.Add(tbSubjectTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CourseManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upravljač kolegija";
            ((System.ComponentModel.ISupportInitialize)nudEctsNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "CourseManagerForm";
        //}


        #endregion
        private Label label1;
        private Label label2;
        private TextBox tbSubjectTitle;
        private Button btnProceed;
        private Button btnCancel;
        private NumericUpDown nudEctsNumber;
    }
}