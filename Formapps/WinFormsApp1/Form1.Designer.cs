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
            label1 = new Label();
            rbToyota = new RadioButton();
            cbAuthor = new ComboBox();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbInpot = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dgRecoed = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btNewInput = new Button();
            label7 = new Label();
            cbCarName = new ComboBox();
            pbPicture = new PictureBox();
            tbRepot = new Button();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            へるぷHToolStripMenuItem = new ToolStripMenuItem();
            btAddRecord = new Button();
            btModifyRecord = new Button();
            btDereteRecord = new Button();
            btPictureOpen = new Button();
            btPictureDelete = new Button();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRecoed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbToyota.Location = new Point(6, 22);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(58, 24);
            rbToyota.TabIndex = 1;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 18F);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(97, 104);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(229, 40);
            cbAuthor.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbInpot);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(97, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 52);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbOther.Location = new Point(305, 22);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(65, 24);
            rbOther.TabIndex = 1;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbInpot
            // 
            rbInpot.AutoSize = true;
            rbInpot.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbInpot.Location = new Point(227, 22);
            rbInpot.Name = "rbInpot";
            rbInpot.Size = new Size(72, 24);
            rbInpot.TabIndex = 1;
            rbInpot.TabStop = true;
            rbInpot.Text = "輸入車";
            rbInpot.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbSubaru.Location = new Point(169, 22);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(62, 24);
            rbSubaru.TabIndex = 1;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbHonda.Location = new Point(115, 22);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(62, 24);
            rbHonda.TabIndex = 1;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbNissan.Location = new Point(61, 22);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(57, 24);
            rbNissan.TabIndex = 1;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F);
            dtpDate.Location = new Point(97, 45);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(231, 39);
            dtpDate.TabIndex = 4;
            dtpDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // dgRecoed
            // 
            dgRecoed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRecoed.Location = new Point(97, 455);
            dgRecoed.Name = "dgRecoed";
            dgRecoed.Size = new Size(564, 195);
            dgRecoed.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(12, 226);
            label4.Name = "label4";
            label4.Size = new Size(62, 32);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(12, 303);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(12, 455);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // btNewInput
            // 
            btNewInput.BackColor = Color.Coral;
            btNewInput.FlatStyle = FlatStyle.Flat;
            btNewInput.Location = new Point(360, 51);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(153, 41);
            btNewInput.TabIndex = 6;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(582, 47);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 8;
            label7.Text = "画像";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 18F);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(97, 231);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(229, 40);
            cbCarName.TabIndex = 2;
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(582, 99);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(327, 211);
            pbPicture.TabIndex = 9;
            pbPicture.TabStop = false;
            // 
            // tbRepot
            // 
            tbRepot.Location = new Point(97, 303);
            tbRepot.Name = "tbRepot";
            tbRepot.Size = new Size(404, 146);
            tbRepot.TabIndex = 10;
            tbRepot.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, へるぷHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(988, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator2, 色設定ToolStripMenuItem, toolStripSeparator1, 終了ToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル&(F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(180, 22);
            開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(180, 22);
            保存ToolStripMenuItem.Text = "保存...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(180, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            終了ToolStripMenuItem.Size = new Size(180, 22);
            終了ToolStripMenuItem.Text = "終了&(X)";
            // 
            // へるぷHToolStripMenuItem
            // 
            へるぷHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            へるぷHToolStripMenuItem.Name = "へるぷHToolStripMenuItem";
            へるぷHToolStripMenuItem.Size = new Size(73, 20);
            へるぷHToolStripMenuItem.Text = "ヘルプ&(H）";
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = SystemColors.GradientActiveCaption;
            btAddRecord.Location = new Point(580, 323);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(81, 56);
            btAddRecord.TabIndex = 12;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            // 
            // btModifyRecord
            // 
            btModifyRecord.BackColor = SystemColors.ButtonHighlight;
            btModifyRecord.Location = new Point(699, 323);
            btModifyRecord.Name = "btModifyRecord";
            btModifyRecord.Size = new Size(81, 56);
            btModifyRecord.TabIndex = 12;
            btModifyRecord.Text = "修正";
            btModifyRecord.UseVisualStyleBackColor = false;
            // 
            // btDereteRecord
            // 
            btDereteRecord.BackColor = Color.FromArgb(255, 255, 128);
            btDereteRecord.Location = new Point(815, 323);
            btDereteRecord.Name = "btDereteRecord";
            btDereteRecord.Size = new Size(81, 56);
            btDereteRecord.TabIndex = 12;
            btDereteRecord.Text = "解除";
            btDereteRecord.UseVisualStyleBackColor = false;
            // 
            // btPictureOpen
            // 
            btPictureOpen.Location = new Point(666, 44);
            btPictureOpen.Name = "btPictureOpen";
            btPictureOpen.Size = new Size(84, 39);
            btPictureOpen.TabIndex = 13;
            btPictureOpen.Text = "開く...";
            btPictureOpen.UseVisualStyleBackColor = true;
            // 
            // btPictureDelete
            // 
            btPictureDelete.Location = new Point(792, 44);
            btPictureDelete.Name = "btPictureDelete";
            btPictureDelete.Size = new Size(84, 39);
            btPictureDelete.TabIndex = 13;
            btPictureDelete.Text = "解除";
            btPictureDelete.UseVisualStyleBackColor = true;
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(180, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 738);
            Controls.Add(btPictureDelete);
            Controls.Add(btPictureOpen);
            Controls.Add(btDereteRecord);
            Controls.Add(btModifyRecord);
            Controls.Add(btAddRecord);
            Controls.Add(tbRepot);
            Controls.Add(pbPicture);
            Controls.Add(label7);
            Controls.Add(btNewInput);
            Controls.Add(dgRecoed);
            Controls.Add(dtpDate);
            Controls.Add(groupBox1);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗管理レポートシステム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgRecoed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbToyota;
        private ComboBox cbAuthor;
        private GroupBox groupBox1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private DataGridView dgRecoed;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btNewInput;
        private Label label7;
        private ComboBox cbCarName;
        private PictureBox pbPicture;
        private Button tbRepot;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private Button btAddRecord;
        private Button btModifyRecord;
        private Button btDereteRecord;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private Button btPictureOpen;
        private Button btPictureDelete;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbOther;
        private RadioButton rbInpot;
        private ToolStripMenuItem へるぷHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
    }
}
