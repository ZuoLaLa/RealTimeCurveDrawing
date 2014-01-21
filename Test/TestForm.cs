using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RealTimeGraph;

namespace Test
{
    public partial class TestForm : Form
    {
        private readonly List<float> xDataList;
        private readonly List<float> yDataList;
        private float time;
        private float data;
        private float xDataMin;
        private float xDataMax;
        private float yDataMin;
        private float yDataMax;

        public TestForm()
        {
            InitializeComponent();
            graphControl.ResetDisplayRect();

            xDataList = new List<float>();
            yDataList = new List<float>();
            time = 0;
            data = 0;

            tslGraphType.Alignment = ToolStripItemAlignment.Right;
            timerStatus.Start();

            btnCurve1.Enabled = true;
            btnStop.Enabled = false;
            btnClear.Enabled = false;

            graphControl.GraphStyle = GraphMode.FixMoveMode;
            btnFixedMove.Enabled = false;
            btnGlobal.Enabled = true;
            btnDrag.Enabled = true;
            btnZoomIn.Enabled = true;
        }

        private void btnCurve1_Click(object sender, EventArgs e)
        {
            xDataList.Clear();
            yDataList.Clear();

            graphControl.GraphClear();
            graphControl.ResetDisplayRect();
            graphControl.XDataList = this.xDataList;
            graphControl.YDataList = this.yDataList;

            btnCurve1.Enabled = false;
            btnStop.Enabled = true;
            tbCurrentData.Text = @"开始采样";
            time = 0;
            timerData1.Start();
        }

        private void timerData1_Tick(object sender, EventArgs e)
        {
            time += 1;
            data = (float)(Math.Sin(time / 10f) * 200);

            xDataList.Add(time);
            yDataList.Add(data);
            GetDataLimits();

            tbCurrentData.Text = data.ToString();
            graphControl.UpdateDataLimits(xDataMin, xDataMax, yDataMin, yDataMax);
            graphControl.Refresh();
            tsMsg.Text = graphControl.MsgOutput;
        }

        private void GetDataLimits()
        {
            int num = xDataList.Count;
            if (num == 1)
            {
                xDataMin = xDataList[0];
                xDataMax = xDataList[0];
                yDataMin = yDataList[0];
                yDataMax = yDataList[0];
            }
            else
            {
                xDataMin = (xDataList[num - 1] < xDataMin) ?
                    xDataList[num - 1] : xDataMin;
                xDataMax = (xDataList[num - 1] > xDataMax) ?
                    xDataList[num - 1] : xDataMax;
                yDataMin = (yDataList[num - 1] < yDataMin) ?
                    yDataList[num - 1] : yDataMin;
                yDataMax = (yDataList[num - 1] > yDataMax) ?
                    yDataList[num - 1] : yDataMax;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerData1.Stop();
            time = 0;

            btnStop.Enabled = false;
            btnClear.Enabled = true;
            btnCurve1.Enabled = true;
        }

        private void btnGlobal_Click(object sender, EventArgs e)
        {
            graphControl.GraphStyle = GraphMode.GlobalMode;
            graphControl.Refresh();

            btnFixedMove.Enabled = true;
            btnGlobal.Enabled = false;
            btnDrag.Enabled = true;
            btnZoomIn.Enabled = true;
        }

        private void btnFixedMove_Click(object sender, EventArgs e)
        {
            graphControl.GraphStyle = GraphMode.FixMoveMode;
            graphControl.Refresh();

            btnFixedMove.Enabled = false;
            btnGlobal.Enabled = true;
            btnDrag.Enabled = true;
            btnZoomIn.Enabled = true;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            graphControl.GraphStyle = GraphMode.RectZoomInMode;
            graphControl.Refresh();

            btnFixedMove.Enabled = true;
            btnGlobal.Enabled = true;
            btnDrag.Enabled = true;
            btnZoomIn.Enabled = false;
        }

        private void btnDrag_Click(object sender, EventArgs e)
        {
            graphControl.GraphStyle = GraphMode.DragMode;
            graphControl.Refresh();

            btnFixedMove.Enabled = true;
            btnGlobal.Enabled = true;
            btnDrag.Enabled = false;
            btnZoomIn.Enabled = true;
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            tsMsg.Text = graphControl.MsgOutput;
            tslGraphType.Text = graphControl.GraphStyle.ToString();
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            graphControl.IsShowGrid = !graphControl.IsShowGrid;
            graphControl.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            xDataList.Clear();
            yDataList.Clear();

            graphControl.GraphClear();
            graphControl.ResetDisplayRect();

            btnClear.Enabled = false;
        }

    }
}
