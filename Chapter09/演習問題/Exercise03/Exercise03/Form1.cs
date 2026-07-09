using System.Diagnostics;

namespace Exercise03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            var tw = new Stopwatch();
            tw.Start();
        }
    }
}
