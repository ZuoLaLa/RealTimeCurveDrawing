using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class TestForm : Form
    {
        private List<float> xDataList;
        private List<float> yDataList;
        private float time;
        private float data;
        private float xDataMin;
        private float xDataMax;
        private float yDataMin;
        private float yDataMax;

        public TestForm()
        {
            InitializeComponent();

            xDataList = new List<float>();
            yDataList = new List<float>();
            time = 0;
            data = 0;

            tslGraphType.Alignment = ToolStripItemAlignment.Right;
            timerStatus.Start();

            btnCurve1.Enabled = true;
            btnCurve2.Enabled = true;
            btnStop.Enabled = false;
            btnClear.Enabled = false;

            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.FixedMoveMode;
            btnFixedMove.Enabled = false;
            btnGlobal.Enabled = true;
            btnDrag.Enabled = true;
            btnZoomIn.Enabled = true;
        }

        private void btnCurve1_Click(object sender, EventArgs e)
        {
            xDataList.Clear();
            yDataList.Clear();

            rtgControl.GraphClear();
            rtgControl.ResetAxis();
            rtgControl.XDataList = this.xDataList;
            rtgControl.YDataList = this.yDataList;

            btnCurve1.Enabled = false;
            btnCurve2.Enabled = false;
            btnStop.Enabled = true;
            tbCurrentData.Text = "开始采样";
            time = 0;
            timerData1.Start();
        }

        private void btnCurve2_Click(object sender, EventArgs e)
        {
            xDataList.Clear();
            yDataList.Clear();

            rtgControl.GraphClear();
            rtgControl.ResetAxis();
            rtgControl.XDataList = this.xDataList;
            rtgControl.YDataList = this.yDataList;

            btnCurve1.Enabled = false;
            btnCurve2.Enabled = false;
            btnStop.Enabled = true;
            tbCurrentData.Text = "开始采样";
            time = 0;
            timerData2.Start();
        }

        private void timerData1_Tick(object sender, EventArgs e)
        {
            time += 1;
            data = (float)(Math.Sin(time / 10f) * 200);

            xDataList.Add(time);
            yDataList.Add(data);
            getDataLimits();

            tbCurrentData.Text = data.ToString();
            rtgControl.UpdateDataLimits(xDataMin, xDataMax, yDataMin, yDataMax);
            rtgControl.Refresh();
            tsMsg.Text = rtgControl.MsgOutput;
        }

        private void timerData2_Tick(object sender, EventArgs e)
        {
            time += 1;
            data = rectWave(time);

            xDataList.Add(time);
            yDataList.Add(data);
            getDataLimits();

            tbCurrentData.Text = data.ToString();
            rtgControl.UpdateDataLimits(xDataMin, xDataMax, yDataMin, yDataMax);
            rtgControl.Refresh();
            tsMsg.Text = rtgControl.MsgOutput;
        }
        /// <summary>
        /// 方波发生器
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private float rectWave(float time)
        {
            int t = Convert.ToInt32(time);
            int m = t % 40;
            float d;

            if (m < 20)
            {
                d = 180;
            }
            else
            {
                d = -180;
            }

            return d;
        }

        private void getDataLimits()
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
            btnCurve2.Enabled = true;
        }

        private void btnGlobal_Click(object sender, EventArgs e)
        {
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.GlobalMode;
            rtgControl.Refresh();

            btnFixedMove.Enabled = true;
            btnGlobal.Enabled = false;
            btnDrag.Enabled = true;
            btnZoomIn.Enabled = true;
        }

        private void btnFixedMove_Click(object sender, EventArgs e)
        {
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.FixedMoveMode;
            rtgControl.Refresh();

            btnFixedMove.Enabled = false;
            btnGlobal.Enabled = true;
            btnDrag.Enabled = true;
            btnZoomIn.Enabled = true;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.RectZoomInMode;
            rtgControl.Refresh();

            btnFixedMove.Enabled = true;
            btnGlobal.Enabled = true;
            btnDrag.Enabled = true;
            btnZoomIn.Enabled = false;
        }

        private void btnInitialWidth_Click(object sender, EventArgs e)
        {
            rtgControl.ResetAxisXWidth();
            rtgControl.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.RectZoomInMode;
            rtgControl.ResetAxis();
            rtgControl.Refresh();
        }

        private void btnDrag_Click(object sender, EventArgs e)
        {
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.DragMode;
            rtgControl.Refresh();

            btnFixedMove.Enabled = true;
            btnGlobal.Enabled = true;
            btnDrag.Enabled = false;
            btnZoomIn.Enabled = true;
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            tsMsg.Text = rtgControl.MsgOutput;
            tslGraphType.Text = rtgControl.GraphType.ToString();
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            rtgControl.ShowGrid = !rtgControl.ShowGrid;
            rtgControl.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            xDataList.Clear();
            yDataList.Clear();

            rtgControl.GraphClear();
            rtgControl.ResetAxis();

            btnClear.Enabled = false;
        }
    }
}
