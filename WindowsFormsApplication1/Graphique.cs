using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace WindowsFormsApplication1
{
    public partial class Graphique : Form
    {
        public Series series1;
        public Chart Chart2;
        public ChartArea ChartArea1;

        public Graphique(List<Data> loadedData)
        {
            this.Visible = true;
            //Créer un Chart
            Chart2 = new Chart();
            //Il ne contient rien

            //Créer ChartArea (zone graphique)
            ChartArea1 = new ChartArea();

            //Ajouter le  Chart Area à la Collection ChartAreas du  Chart
            Chart2.ChartAreas.Add(ChartArea1);

            //Créer deux  data series (qui contiendront les DataPoint)
            series1 = new Series();

            //Ajouter des points à la collections Points de la première series
            foreach (Data index in loadedData)
            {
                series1.Points.AddXY(index.datehour, index.close);
            }

            
            series1.BorderWidth = 3;
            //series1.BorderColor = Color.Red;
            series1.Color = Color.Blue;
            series1.ChartType = SeriesChartType.Line;

            //On indique d'afficher ces Series sur le ChartArea1
            series1.ChartArea = "ChartArea1";

            //Setting the serie
            Chart2.Series.Clear();
            Chart2.Series.Add(series1);
            Chart2.Series[0].XValueType = ChartValueType.DateTime;

            //Setting the AxisX parameters
            Chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd/HH-mm-ss";
            Chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
            Chart2.ChartAreas[0].AxisX.Interval = 1;
            Chart2.ChartAreas[0].AxisX.Minimum = loadedData[0].datehour.ToOADate();
            Chart2.ChartAreas[0].AxisX.Maximum = loadedData[loadedData.Count - 1].datehour.ToOADate();

            //Setting the ScaleView parameters
            Chart2.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            Chart2.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Hours;
            Chart2.ChartAreas[0].AxisX.ScaleView.Size = 0.1;

            Chart2.ChartAreas[0].AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Hours;
            Chart2.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 1;

            Chart2.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

            Chart2.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;

            //Chart2.ChartAreas[0].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Hours;
            //Chart2.ChartAreas[0].AxisX.ScaleView.MinSize = 1;

            //Chart2.ChartAreas[0].AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Hours;
            Chart2.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 12;
            //Chart2.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Hours;
            //Chart2.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 1;

            Chart2.ChartAreas[0].AxisY.Minimum = 0.9;
            Chart2.ChartAreas[0].AxisY.Maximum = 1.4;

            //Positionner le controle Chart
            Chart2.Location = new System.Drawing.Point(15, 45);

            // Dimensionner le Chart
            Chart2.Size = new System.Drawing.Size(800, 600);


            // Ajouter le chart à la form
            this.Controls.Add(Chart2);
            InitializeComponent();
        }

        private void Graphique_Load(object sender, EventArgs e)
        {

        }

        public void Graphique_refresh(List<Data> loaded_data)
        {
            Chart2.Series[0].XValueType = ChartValueType.DateTime;
            Chart2.Series[0].Points.AddXY(loaded_data[loaded_data.Count - 1].datehour, loaded_data[loaded_data.Count - 1].close);
            Chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd/HH-mm-ss";
            Chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
            Chart2.ChartAreas[0].AxisX.Interval = 1;
            Chart2.ChartAreas[0].AxisX.Minimum = loaded_data[0].datehour.ToOADate();
            Chart2.ChartAreas[0].AxisX.Maximum = loaded_data[loaded_data.Count - 1].datehour.ToOADate();
        }

     
    }
}
