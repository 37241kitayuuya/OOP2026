namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void dt1_Click(object sender, EventArgs e) {
            DateTime dt1 = dtpDate.Value;

            if (DateTime.IsLeapYear(dt1.Year)) {
                tbOut.Text = "‚¤‚é‚¤”N";
            } else {
                tbOut.Text = "‚¤‚é‚¤”N‚Å‚Í‚ ‚è‚Ü‚¹‚ñ";
            }


        }
    }
}
