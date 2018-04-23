Namespace Dashboard_CustomVisualInteractivity_Web
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim measure3 As New DevExpress.DashboardCommon.Measure()
            Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
            Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
            Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.dataSource1 = New DevExpress.DashboardCommon.DataSource()
            Me.nwindDataSet1 = New Dashboard_CustomVisualInteractivity_Web.nwindDataSet()
            Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
            DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' gridDashboardItem1
            ' 
            dimension1.DataMember = "CategoryName"
            dimension1.Name = "Category"
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridDimensionColumn1.AddDataItem("Dimension", dimension1)
            measure1.DataMember = "Extended Price"
            measure1.Name = "Extended Price"
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn1.AddDataItem("Measure", measure1)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridMeasureColumn1})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            measure2.DataMember = "Quantity"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
            Me.gridDashboardItem1.DataItemRepository.Add(measure2, "DataItem2")
            Me.gridDashboardItem1.DataSource = Me.dataSource1
            Me.gridDashboardItem1.HiddenMeasures.AddRange(New DevExpress.DashboardCommon.Measure() { measure2})
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem1.Name = "Grid 1"
            Me.gridDashboardItem1.ShowCaption = False
            ' 
            ' dataSource1
            ' 
            Me.dataSource1.ComponentName = "dataSource1"
            Me.dataSource1.Data = Me.nwindDataSet1
            Me.dataSource1.DataMember = "SalesPerson"
            Me.dataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client
            Me.dataSource1.Name = "Data Source 1"
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' chartDashboardItem1
            ' 
            dimension2.DataMember = "Sales Person"
            Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
            Me.chartDashboardItem1.AxisX.TitleVisible = False
            Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
            measure3.DataMember = "Extended Price"
            measure3.Name = "Extended Price"
            dimension3.DataMember = "OrderDate"
            Me.chartDashboardItem1.DataItemRepository.Clear()
            Me.chartDashboardItem1.DataItemRepository.Add(measure3, "DataItem0")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1")
            Me.chartDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2")
            Me.chartDashboardItem1.DataSource = Me.dataSource1
            Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.chartDashboardItem1.Name = "Chart 1"
            chartPane1.Name = "Pane 1"
            chartPane1.PrimaryAxisY.ShowGridLines = True
            chartPane1.PrimaryAxisY.TitleVisible = True
            chartPane1.SecondaryAxisY.ShowGridLines = False
            chartPane1.SecondaryAxisY.TitleVisible = True
            simpleSeries1.AddDataItem("Value", measure3)
            chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
            Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
            Me.chartDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
            Me.chartDashboardItem1.ShowCaption = False
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.DataSource() { Me.dataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridDashboardItem1, Me.chartDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
            dashboardLayoutItem1.Weight = 54.358974358974358R
            dashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
            dashboardLayoutItem2.Weight = 45.641025641025642R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.ImageDataSerializable = ""
            Me.Title.Text = "Dashboard"
            Me.Title.Visible = False
            DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private dataSource1 As DevExpress.DashboardCommon.DataSource
        Private nwindDataSet1 As nwindDataSet
        Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
    End Class
End Namespace
