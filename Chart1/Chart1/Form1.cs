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

namespace Chart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] X = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            int[] Y1 = { 210, 220, 198, 187, 201, 206, 234, 198, 204, 210, 211, 192 };
            int[] Y3 = { 200, 220, 198, 187, 251, 206, 234, 198, 204, 210, 201, 192 };
            int[] Y2 = new int[12];
            for (int i = 0; i < Y2.Length; i++) Y2[i] = 200;


            cht1.Series.Add(new Series("Series2"));

            cht1.Series[0].Points.DataBindXY(X, Y1);
            cht1.Series[1].Points.DataBindY(Y2);
            //cht1.Series[1].Points.DataBindY(Y3);



            //X
            cht1.ChartAreas[0].AxisX.Interval = 1;
            cht1.ChartAreas[0].AxisX.Title = "时间";
            cht1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            //Y
            cht1.ChartAreas[0].AxisY.Title = "产能";
            cht1.ChartAreas[0].AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            cht1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            //Show Value
            cht1.Series[0].Label = "#VAL";
            //cht1.Series[1].Label = "#VAL";

            //图例
            cht1.Series[0].LegendText = "实际产能";
            cht1.Series[1].LegendText = "目标产能";

            //折线
            cht1.Series[1].ChartType = SeriesChartType.Line;

            //颜色
            cht1.Series[1].Color = Color.Red;
        }
    }
}
