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
            nudDay = new NumericUpDown();
            label1 = new Label();
            dtpbirth = new DateTimePicker();
            dbrithcalc = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // dt1
            // 
            dt1.Location = new Point(676, 42);
            dt1.Name = "dt1";
            dt1.Size = new Size(161, 96);
            dt1.TabIndex = 0;
            dt1.Text = "計算";
            dt1.UseVisualStyleBackColor = true;
            dt1.Click += dt1_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(211, 89);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 1;
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(339, 447);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(399, 39);
            tbOut.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(482, 165);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 39);
            nudDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(622, 172);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dtpbirth
            // 
            dtpbirth.Location = new Point(211, 302);
            dtpbirth.Name = "dtpbirth";
            dtpbirth.Size = new Size(200, 23);
            dtpbirth.TabIndex = 1;
            // 
            // dbrithcalc
            // 
            dbrithcalc.Location = new Point(676, 272);
            dbrithcalc.Name = "dbrithcalc";
            dbrithcalc.Size = new Size(161, 96);
            dbrithcalc.TabIndex = 0;
            dbrithcalc.Text = "計算";
            dbrithcalc.UseVisualStyleBackColor = true;
            dbrithcalc.Click += dt1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 605);
            Controls.Add(label1);
            Controls.Add(nudDay);
            Controls.Add(tbOut);
            Controls.Add(dtpbirth);
            Controls.Add(dtpDate);
            Controls.Add(dbrithcalc);
            Controls.Add(dt1);
            Name = "Form1";
            Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dt1;
        private DateTimePicker dtpDate;
        private TextBox tbOut;
        private NumericUpDown nudDay;
        private Label label1;
        private DateTimePicker dtpbirth;
        private Button dbrithcalc;
    }
}
