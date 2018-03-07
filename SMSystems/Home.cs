using SMSBL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace SMSystems
{
    public partial class Home : Form
    {
        PieSeries pieSeries;
        public Home()
        {
            InitializeComponent();
            

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DrawStockChart();
         
        }
        //public Home(int id)
        //{
        //    InitializeComponent();
        //    MessageBox.Show(id + "");

        //}
    
        private void PopulatePieSeries()
        {
            var list = ReportBLL.GetProductStockList();
            this.pieSeries.ShowLabels = true;
            this.pieSeries.LabelFormat = "{0:P1}";
            this.pieSeries.RadiusFactor = 0.9f;
            this.pieSeries.Range = new AngleRange(270, 360);
            this.pieSeries.GradientStyle = GradientStyles.Linear;
            foreach (var item in list)
            {
                this.pieSeries.DataPoints.Add(new PieDataPoint(item.TotalStock,item.ArticalNo+": TotalPairs:"+item.TotalStock.ToString()));                     
            }           
            //this.pieSeries.DataPoints.Add(new PieDataPoint(40, "Apple"));
            //this.pieSeries.DataPoints.Add(new PieDataPoint(30, "Others"));
        }
        private void DrawStockChart()
        {
            this.StockChart.Controllers.Add(new ChartSelectionController());
            this.StockChart.SelectionMode = ChartSelectionMode.SingleDataPoint;
            this.pieSeries = new PieSeries();
            this.PopulatePieSeries();
            this.StockChart.AreaType = ChartAreaType.Pie;
            this.StockChart.Series.Clear();
            this.StockChart.Series.Add(this.pieSeries);
            Theme theme = Theme.ReadCSSText(@"
                                                theme                                         
                                                    {                                            
                                                        name: ControlDefault;                                            
                                                        elementType: Telerik.WinControls.UI.RadChartElement;                                             
                                                        controlType: Telerik.WinControls.UI.RadChartView;                                          
                                                    }                                         
                                                    PieSegment                                         
                                                    {                                                 
                                                        RadiusAspectRatio                                             
                                                        {                                                 
                                                            Value: 0.5;                                                 
                                                            EndValue: 1;                                                 
                                                            MaxValue: 1;                                                 
                                                            Frames: 20;                                                 
                                                            Interval: 10;                                                 
                                                            EasingType: OutCircular;                                                 
                                                            RandomDelay: 100;                                                 
                                                            RemoveAfterApply: true;                                              
                                                        }                                         
                                                    }                                         
                                                    ");
            ThemeRepository.Add(theme, false);
        }

    }
}
