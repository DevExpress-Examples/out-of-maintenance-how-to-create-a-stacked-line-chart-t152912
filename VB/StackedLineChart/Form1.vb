Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Namespace StackedLineChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim stackedLineChart As New ChartControl()

            ' Create stacked line series.
            Dim series1 As New Series("Series 1", ViewType.StackedLine)
            Dim series2 As New Series("Series 2", ViewType.StackedLine)
            Dim series3 As New Series("Series 3", ViewType.StackedLine)
            Dim series4 As New Series("Series 4", ViewType.StackedLine)

            ' Add points to them
            series1.Points.Add(New SeriesPoint("A", 8100))
            series1.Points.Add(New SeriesPoint("B", 4120))
            series1.Points.Add(New SeriesPoint("C", -1300))
            series1.Points.Add(New SeriesPoint("D", -1700))

            series2.Points.Add(New SeriesPoint("A", 14500))
            series2.Points.Add(New SeriesPoint("B", 18000))
            series2.Points.Add(New SeriesPoint("C", 19500))
            series2.Points.Add(New SeriesPoint("D", 21000))

            series3.Points.Add(New SeriesPoint("A", -915))
            series3.Points.Add(New SeriesPoint("B", -1348))
            series3.Points.Add(New SeriesPoint("C", -2900))
            series3.Points.Add(New SeriesPoint("D", -3423))

            series4.Points.Add(New SeriesPoint("A", -6395))
            series4.Points.Add(New SeriesPoint("B", -6494))
            series4.Points.Add(New SeriesPoint("C", -7819))
            series4.Points.Add(New SeriesPoint("D", -9567))

            ' Add series to the chart.
            stackedLineChart.Series.AddRange(New Series() { series1, series2, series3, series4 })

            ' Show series labels.
            series1.LabelsVisibility = DefaultBoolean.True
            series2.LabelsVisibility = DefaultBoolean.True
            series3.LabelsVisibility = DefaultBoolean.True
            series4.LabelsVisibility = DefaultBoolean.True

            ' Customize crosshair cursor options to compare series.   
            stackedLineChart.CrosshairOptions.ShowArgumentLabels = True
            stackedLineChart.CrosshairOptions.ShowValueLabels = True
            stackedLineChart.CrosshairOptions.ShowValueLine = True
            stackedLineChart.CrosshairOptions.SnapMode = CrosshairSnapMode.NearestValue

            ' Add a title to the chart (if necessary).
            stackedLineChart.Titles.Add(New ChartTitle())
            stackedLineChart.Titles(0).Text = "A Stacked Line Chart"

            ' Add the chart to the form.
            stackedLineChart.Dock = DockStyle.Fill
            Me.Controls.Add(stackedLineChart)
        End Sub
    End Class
End Namespace
