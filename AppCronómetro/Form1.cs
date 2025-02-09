using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

namespace AppCronómetro
{
    public partial class AppCron : Form
    {
        private string appCron;
        private Stopwatch stopwatch;

        public AppCron()
        {
            InitializeComponent();
            appCron = "";
            stopwatch = new Stopwatch();

        }

        private void AppCron_Load(object sender, EventArgs e)
        {
        }
        private void btnResetear_Click(object sender, EventArgs e)
        {


        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            Tcronometro.Enabled = true;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            Tcronometro.Enabled = false;
            appCron = "00:00.0";
            lbCronometro.Text = appCron;
            Lapso.Items.Clear();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            Lapso.Items.Add(lbCronometro.Text);
        }

        private void Tcronometro_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan( 0, 0, 0, 0, (int)
                stopwatch.ElapsedMilliseconds);

            int minute = ts.Minutes;
            int second = ts.Seconds;
            int millisecond = ts.Milliseconds;


            appCron = $"{minute}:{second}:{millisecond}";
            lbCronometro.Text = appCron;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AppCron_Load_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Lapso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

