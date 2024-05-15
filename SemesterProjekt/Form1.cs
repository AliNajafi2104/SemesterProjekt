using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace SemesterProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rum1.ChartType = SeriesChartType.Line;
            rum2.ChartType = SeriesChartType.Line;
            rum1.MarkerStyle = MarkerStyle.Circle;
            rum2.MarkerStyle = MarkerStyle.Circle;
            chart1.Series.Add(rum1);
            chart1.Series.Add(rum2);
            Refresh();
            chart1.ChartAreas[0].AxisY.Minimum = 20;
            
            WindowState = FormWindowState.Maximized;
            dataGridView1.DataSource = SQLite.ReadRoom1();
            dataGridView2.DataSource = SQLite.ReadRoom2();
            chart1.Titles.Add("Kurve for " + DateTime.Now.ToString("MMMM dd, yyyy"));




            Timer timer = new Timer();
            timer.Interval = 5000; // 10 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Refresh(); // Call Refresh every 10 seconds
        }

        private void Refresh()
        {
           
            rum1.Points.Clear();
            rum2.Points.Clear(); // Dette sikrer at data ikke
                                 // akkummlerer i serierne
            målingerRoom1 = SQLite.ReadRoom1();
            målingerRoom2 = SQLite.ReadRoom2();
            
           
            decimal totalRoom1 = 0;
            decimal totalRoom2 = 0;
            foreach (Måling måling in målingerRoom1)
            {
                rum1.Points.AddXY(måling.Tidspunkt.ToString("HH:mm:ss"), måling.Temprature);
                totalRoom1 += måling.Temprature;
            }
            foreach(Måling måling2 in målingerRoom2)
            {
                rum2.Points.AddXY(måling2.Tidspunkt.ToString("HH:mm:ss"), måling2.Temprature);
                totalRoom2 += måling2.Temprature;
            }
            
           
            curTemp1.Text = målingerRoom1[målingerRoom1.Count()-1].Temprature.ToString() + " grader";
            curTemp2.Text = målingerRoom2[målingerRoom2.Count()-1].Temprature.ToString() + " grader";

            avgTempRoom1.Text = (totalRoom1 / målingerRoom1.Count).ToString("0.00") + " grader";
            avgTempRoom2.Text = (totalRoom2 / målingerRoom2.Count).ToString("0.00") + " grader";

            dataGridView1.Columns[2].Visible = false;
            dataGridView2.Columns[2].Visible = false;

            målingerRoom1.Reverse();
            målingerRoom2.Reverse();
            dataGridView1.DataSource = målingerRoom1;
            dataGridView2.DataSource = målingerRoom2;





            switch (målingerRoom1[målingerRoom1.Count-1].Aktivitet)
            {
                case 4:
                    label8.Text = "Afgiver varme";
                    break;
                case 0:
                    label8.Text = "Neutral/passiv";
                    break;
                case 10:
                    label8.Text = "Modtager varme";
                    break;
                default:
                    label8.Text = "";
                    break;
            }

            switch (målingerRoom2[målingerRoom2.Count - 1].Aktivitet)
            {
                case 4:
                    label11.Text = "Afgiver varme";
                    break;
                case 0:
                    label11.Text = "Neutral/passiv";
                    break;
                case 10:
                    label11.Text = "Modtager varme";
                    break;
                default:
                    label11.Text = "";
                    break;
            }
        }



       /* private void Byte()
        {
            switch (målingerRoom1[målingerRoom1.Count-1].Byte)
            {
                case 12:
                    AktivitetRum1.Text += "Aktiv";
                    StatusRum1.Text += "Passiv/neutral";
                    break;
                case 10:
                    AktivitetRum1.Text += "Aktiv";
                    StatusRum1.Text += "Forbruger varme";
                    break;
                case 9:
                    AktivitetRum1.Text += "Aktiv";
                    StatusRum1.Text += "Afgiver varme";
                    break;




                case 4:
                    AktivitetRum1.Text += "Ikke-aktiv";
                    StatusRum1.Text += "Passiv/neutral";

                    break;



                case 2:
                    AktivitetRum1.Text += "Ikke-aktiv";
                    StatusRum1.Text += "Forbruger varme";
                    break;

                case 1:
                    AktivitetRum1.Text += "Ikke-aktiv";
                    StatusRum1.Text += "Afgiver varme";
                    break;

                default:
                    AktivitetRum1.Text += "fejl";
                    StatusRum1.Text += "fejl";
                    break;
            }




            switch (målingerRoom2[målingerRoom2.Count - 1].Byte)
            {
                case 12:
                    AktivitetRum2.Text += "Aktiv";
                    StatusRum2.Text += "Passiv/neutral";
                    break;
                case 10:
                    AktivitetRum2.Text += "Aktiv";
                    StatusRum2.Text += "Forbruger varme";
                    break;
                case 9:
                    AktivitetRum2.Text += "Aktiv";
                    StatusRum2.Text += "Afgiver varme";
                    break;




                case 4:
                    AktivitetRum2.Text += "Ikke-aktiv";
                    StatusRum2.Text += "Passiv/neutral";

                    break;



                case 2:
                    AktivitetRum2.Text += "Ikke-aktiv";
                    StatusRum2.Text += "Forbruger varme";
                    break;

                case 1:
                    AktivitetRum2.Text += "Ikke-aktiv";
                    StatusRum2.Text += "Afgiver varme";
                    break;

                default:
                    AktivitetRum2.Text += "fejl";
                    StatusRum2.Text += "fejl";
                    break;
            }

        }
       */
       






        Series rum1 = new Series("Rum 1");
        Series rum2 = new Series("Rum 2");
        List<Måling> målingerRoom1 = new List<Måling>();
        List<Måling> målingerRoom2 = new List<Måling>();

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
