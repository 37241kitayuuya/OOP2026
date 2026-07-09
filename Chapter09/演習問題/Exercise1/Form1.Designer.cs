namespace WinFormsApp1 {
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
            btButton1 = new Button();
            tvOut1 = new TextBox();
            btButton2 = new Button();
            tvOut2 = new TextBox();
            btButton3 = new Button();
            tvOut3 = new TextBox();
            SuspendLayout();
            // 
            // btButton1
            // 
            btButton1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btButton1.Location = new Point(130, 40);
            btButton1.Name = "btButton1";
            btButton1.Size = new Size(182, 110);
            btButton1.TabIndex = 0;
            btButton1.Text = "①";
            btButton1.UseVisualStyleBackColor = true;
            btButton1.Click += btButton1_Click;
            // 
            // tvOut1
            // 
            tvOut1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tvOut1.Location = new Point(356, 76);
            tvOut1.Name = "tvOut1";
            tvOut1.Size = new Size(577, 39);
            tvOut1.TabIndex = 1;
            tvOut1.Text = "あ";
            // 
            // btButton2
            // 
            btButton2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btButton2.Location = new Point(130, 193);
            btButton2.Name = "btButton2";
            btButton2.Size = new Size(182, 110);
            btButton2.TabIndex = 0;
            btButton2.Text = "②";
            btButton2.UseVisualStyleBackColor = true;
            btButton2.Click += btButton2_Click;
            // 
            // tvOut2
            // 
            tvOut2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tvOut2.Location = new Point(356, 229);
            tvOut2.Name = "tvOut2";
            tvOut2.Size = new Size(577, 39);
            tvOut2.TabIndex = 1;
            tvOut2.Text = "あ";
            // 
            // btButton3
            // 
            btButton3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btButton3.Location = new Point(130, 360);
            btButton3.Name = "btButton3";
            btButton3.Size = new Size(182, 110);
            btButton3.TabIndex = 0;
            btButton3.Text = "③";
            btButton3.UseVisualStyleBackColor = true;
            btButton3.Click += btButton3_Click;
            // 
            // tvOut3
            // 
            tvOut3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tvOut3.Location = new Point(356, 396);
            tvOut3.Name = "tvOut3";
            tvOut3.Size = new Size(577, 39);
            tvOut3.TabIndex = 1;
            tvOut3.Text = "あ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 568);
            Controls.Add(tvOut3);
            Controls.Add(tvOut2);
            Controls.Add(tvOut1);
            Controls.Add(btButton3);
            Controls.Add(btButton2);
            Controls.Add(btButton1);
            Name = "Form1";
            Text = "問題9-1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btButton1;
        private TextBox tvOut1;
        private Button btButton2;
        private TextBox tvOut2;
        private Button btButton3;
        private TextBox tvOut3;
    }
}
