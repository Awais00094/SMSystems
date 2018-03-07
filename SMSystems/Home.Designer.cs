namespace SMSystems
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis2 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis2 = new Telerik.WinControls.UI.LinearAxis();
            this.label5 = new System.Windows.Forms.Label();
            this.StockChart = new Telerik.WinControls.UI.RadChartView();
            ((System.ComponentModel.ISupportInitialize)(this.StockChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(-1, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Home Form";
            // 
            // StockChart
            // 
            this.StockChart.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.TickOrigin = null;
            categoricalAxis2.IsPrimary = true;
            linearAxis2.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis2.IsPrimary = true;
            linearAxis2.MajorStep = 0.1D;
            linearAxis2.TickOrigin = null;
            this.StockChart.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1,
            categoricalAxis2,
            linearAxis2});
            this.StockChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.StockChart.Location = new System.Drawing.Point(0, 0);
            this.StockChart.Name = "StockChart";
            this.StockChart.ShowGrid = false;
            this.StockChart.ShowLegend = true;
            this.StockChart.ShowTitle = true;
            this.StockChart.ShowToolTip = true;
            this.StockChart.ShowTrackBall = true;
            this.StockChart.Size = new System.Drawing.Size(480, 514);
            this.StockChart.TabIndex = 9;
            this.StockChart.Text = "radChartView1";
            this.StockChart.Title = "Today Stock";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(970, 514);
            this.Controls.Add(this.StockChart);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.StockChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private Telerik.WinControls.UI.RadChartView StockChart;
    }
}