using System.Globalization;

namespace WinFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btButton1_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var s1 = dateTime.ToString("yyyy/MM/dd hh:mm");
            var today = DateTime.Today;
            tvOut1.Text = s1;
        }

        private void btButton2_Click(object sender, EventArgs e) {
            var dateTime = DateTime.Now;
            var s2 = dateTime.ToString("yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b");
            var today = DateTime.Today;
            tvOut2.Text = s2;
        }

        private void btButton3_Click(object sender, EventArgs e) {
            var date = DateTime.Now;
            var culture = new CultureInfo("ja-jp");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var s3 = date.ToString("gy”N MŒŽ d“ú(dddd)", culture);
            tvOut3.Text = s3;
        }
    }
}
