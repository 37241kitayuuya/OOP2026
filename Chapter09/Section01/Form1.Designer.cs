namespace Section01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dt1 = new Button();
            dtpDate = new DateTimePicker();
            tbOut = new TextBox();
            SuspendLayout();
            // 
            // dt1
            // 
            dt1.Location = new Point(497, 175);
            dt1.Name = "dt1";
            dt1.Size = new Size(75, 23);
            dt1.TabIndex = 0;
            dt1.Text = "関連\r\n";
            dt1.UseVisualStyleBackColor = true;
            dt1.Click += dt1_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(458, 303);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 1;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(466, 444);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(178, 23);
            tbOut.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 605);
            Controls.Add(tbOut);
            Controls.Add(dtpDate);
            Controls.Add(dt1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dt1;
        private DateTimePicker dtpDate;
        private TextBox tbOut;
    }
}
