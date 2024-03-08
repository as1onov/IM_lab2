using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИМ_лаба_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.02;
        Random rnd = new Random();
        double price_dollar, price_euro;
        int days;
        int day;

        private void button_start_Click(object sender, EventArgs e)
        {
            
 
            if (!timer1.Enabled) {
                day = 0;

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();

                price_dollar = (double)edDollar.Value;
                price_euro = (double)edEuro.Value;
                days = (int)edDays.Value;
                
                chart1.Series[0].Points.AddXY(0, price_dollar);
                chart1.Series[1].Points.AddXY(0, price_euro);

                timer1.Start();

             }

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            day += 1;
            price_euro = price_euro * (1 + k * (rnd.NextDouble() - 0.5));
            price_dollar = price_dollar * (1 + k * (rnd.NextDouble() - 0.5));

            chart1.Series[0].Points.AddXY(day, price_dollar);
            chart1.Series[1].Points.AddXY(day, price_euro);
            
            if (day == days) timer1.Stop();

        }
    }
}
