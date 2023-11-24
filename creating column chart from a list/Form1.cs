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

namespace creating_column_chart_from_a_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<KeyValuePair<string, double>> temperatureData = define_list();
            Series series = define_series();
            series.ChartType = SeriesChartType.Column;
            foreach (var temp in temperatureData)
            {
                series.Points.AddXY(temp.Key, temp.Value);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Temperature in degrees C";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<KeyValuePair<string, double>> temperatureData = define_list();
            Series series = define_series();
            series.ChartType = SeriesChartType.Line;
            foreach (var temp in temperatureData)
            {
                series.Points.AddXY(temp.Key, temp.Value);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Temperature in degrees C";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<KeyValuePair<string, double>> temperatureData = define_list();

            Series series = define_series();
            series.ChartType = SeriesChartType.Bar;

            foreach (var temp in temperatureData)
            {
                series.Points.AddXY(temp.Key, temp.Value);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Temperature in degrees C";
        }

        static List<KeyValuePair<string, double>> define_list()
        {
            List<KeyValuePair<string, double>> temperatureData = new List<KeyValuePair<string, double>>
            {
                new KeyValuePair<string, double>("2018",9.49),
                new KeyValuePair<string, double>("2019",9.42),
                new KeyValuePair<string, double>("2020",9.62),
                new KeyValuePair<string, double>("2021",9.28),
                new KeyValuePair<string, double>("2022",10.93)
            };
            return temperatureData;
        } 

        static Series define_series()
        {
            Series series = new Series("Average Temp in degrees C");
            return series;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<KeyValuePair<string, double>> temperatureData = define_list();

            Series series = define_series();
            series.ChartType = SeriesChartType.Pie;

            foreach (var temp in temperatureData)
            {
                series.Points.AddXY(temp.Key, temp.Value);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Temperature in degrees C";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<KeyValuePair<string, double>> temperatureData = define_list();

            Series series = define_series();
            series.ChartType = SeriesChartType.Area;

            foreach (var temp in temperatureData)
            {
                series.Points.AddXY(temp.Key, temp.Value);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Temperature in degrees C";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<KeyValuePair<string, double>> temperatureData = define_list();

            Series series = define_series();
            series.ChartType = SeriesChartType.Doughnut;

            foreach (var temp in temperatureData)
            {
                series.Points.AddXY(temp.Key, temp.Value);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Temperature in degrees C";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            List<KeyValuePair<string, double>> temperatureData = define_list();

            Series series = define_series();
            series.ChartType = SeriesChartType.Point;

            foreach (var temp in temperatureData)
            {
                series.Points.AddXY(temp.Key, temp.Value);
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.Title = "Year";
            chart1.ChartAreas[0].AxisY.Title = "Temperature in degrees C";
        }
    }
}
