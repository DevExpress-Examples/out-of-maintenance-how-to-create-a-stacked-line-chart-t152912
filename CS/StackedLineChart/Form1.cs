using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.Utils;

namespace StackedLineChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl stackedLineChart = new ChartControl();

            // Create stacked line series.
            Series series1 = new Series("Series 1", ViewType.StackedLine);
            Series series2 = new Series("Series 2", ViewType.StackedLine);
            Series series3 = new Series("Series 3", ViewType.StackedLine);
            Series series4 = new Series("Series 4", ViewType.StackedLine);

            // Add points to them
            series1.Points.Add(new SeriesPoint("A", 8100));
            series1.Points.Add(new SeriesPoint("B", 4120));
            series1.Points.Add(new SeriesPoint("C", -1300));
            series1.Points.Add(new SeriesPoint("D", -1700));

            series2.Points.Add(new SeriesPoint("A", 14500));
            series2.Points.Add(new SeriesPoint("B", 18000));
            series2.Points.Add(new SeriesPoint("C", 19500));
            series2.Points.Add(new SeriesPoint("D", 21000));

            series3.Points.Add(new SeriesPoint("A", -915));
            series3.Points.Add(new SeriesPoint("B", -1348));
            series3.Points.Add(new SeriesPoint("C", -2900));
            series3.Points.Add(new SeriesPoint("D", -3423));

            series4.Points.Add(new SeriesPoint("A", -6395));
            series4.Points.Add(new SeriesPoint("B", -6494));
            series4.Points.Add(new SeriesPoint("C", -7819));
            series4.Points.Add(new SeriesPoint("D", -9567));

            // Add series to the chart.
            stackedLineChart.Series.AddRange(new Series[] { series1, series2, series3, series4 });

            // Show series labels.
            series1.LabelsVisibility = DefaultBoolean.True;
            series2.LabelsVisibility = DefaultBoolean.True;
            series3.LabelsVisibility = DefaultBoolean.True;
            series4.LabelsVisibility = DefaultBoolean.True;

            // Customize crosshair cursor options to compare series.   
            stackedLineChart.CrosshairOptions.ShowArgumentLabels = true;
            stackedLineChart.CrosshairOptions.ShowValueLabels = true;
            stackedLineChart.CrosshairOptions.ShowValueLine = true;
            stackedLineChart.CrosshairOptions.SnapMode = CrosshairSnapMode.NearestValue;

            // Add a title to the chart (if necessary).
            stackedLineChart.Titles.Add(new ChartTitle());
            stackedLineChart.Titles[0].Text = "A Stacked Line Chart";

            // Add the chart to the form.
            stackedLineChart.Dock = DockStyle.Fill;
            this.Controls.Add(stackedLineChart);
        }
    }
}
