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

            timerStatus.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            xDataList.Clear();
            yDataList.Clear();

            rtgControl.GraphClear();
            rtgControl.ResetAxis();
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.FixedMoveMode;
            rtgControl.XDataList = this.xDataList;
            rtgControl.YDataList = this.yDataList;

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            tbCurrentData.Text = "开始采样";
            timerData.Start();
        }

        private void timerData_Tick(object sender, EventArgs e)
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
            timerData.Stop();
            time = 0;

            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void btnGlobal_Click(object sender, EventArgs e)
        {
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.GlobalMode;
            rtgControl.Refresh();
        }

        private void btnFixedMove_Click(object sender, EventArgs e)
        {
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.FixedMoveMode;
            rtgControl.Refresh();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.RectZoomInMode;
            rtgControl.Refresh();
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
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            tsMsg.Text = rtgControl.MsgOutput;
        }
    }
}
