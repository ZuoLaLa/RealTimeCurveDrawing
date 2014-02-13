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
        private readonly List<float> zDataList;
        private readonly List<float> dataList1;
        private readonly List<float> dataList2;
        private float time;
        private float dataY;
        private float dataZ;

        public TestForm()
        {
            InitializeComponent();

            xDataList = new List<float>();
            yDataList = new List<float>();
            zDataList = new List<float>();
            dataList1 = new List<float>();
            dataList2 = new List<float>();
            time = 0;
            dataY = 0;

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
            zDataList.Clear();
            dataList1.Clear();
            dataList2.Clear();
            graphControl.DataLists.Add(
                new DataPairList<float>(xDataList, yDataList));
            graphControl.DataLists.Add(
                new DataPairList<float>(xDataList, zDataList));
            graphControl.DataLists.Add(
                new DataPairList<float>(xDataList, dataList1));
            graphControl.DataLists.Add(
                 new DataPairList<float>(xDataList, dataList2));

            btnCurve1.Enabled = false;
            btnStop.Enabled = true;
            tbCurrentData.Text = @"开始采样";
            time = 0;
            timerData1.Start();
        }

        private void timerData1_Tick(object sender, EventArgs e)
        {
            time += 1;
            dataY = (float)(Math.Sin(time / 10f) * 200);
            dataZ = (float)(Math.Cos(time / 10f) * 200);

            xDataList.Add(time);
            yDataList.Add(dataY);
            zDataList.Add(dataZ);
            dataList1.Add(dataY + dataZ);
            dataList2.Add(dataY - dataZ);

            tbCurrentData.Text = dataY.ToString();
            graphControl.Refresh();
            tsMsg.Text = graphControl.MsgOutput;
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
            zDataList.Clear();
            dataList1.Clear();
            dataList2.Clear();
            btnClear.Enabled = false;
        }

    }
}
