﻿using RealTimeGraph;

namespace Test
{
    partial class TestForm
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
            this.components = new System.ComponentModel.Container();
            this.btnCurve1 = new System.Windows.Forms.Button();
            this.timerData1 = new System.Windows.Forms.Timer(this.components);
            this.tbCurrentData = new System.Windows.Forms.TextBox();
            this.labelCurrentData = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGlobal = new System.Windows.Forms.Button();
            this.btnFixedMove = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnDrag = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslGraphType = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.btnGrid = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.graphControl = new RealTimeGraph.GraphControl();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCurve1
            // 
            this.btnCurve1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCurve1.Location = new System.Drawing.Point(590, 11);
            this.btnCurve1.Name = "btnCurve1";
            this.btnCurve1.Size = new System.Drawing.Size(75, 23);
            this.btnCurve1.TabIndex = 1;
            this.btnCurve1.Text = "Curve &1";
            this.btnCurve1.UseVisualStyleBackColor = true;
            this.btnCurve1.Click += new System.EventHandler(this.btnCurve1_Click);
            // 
            // timerData1
            // 
            this.timerData1.Interval = 200;
            this.timerData1.Tick += new System.EventHandler(this.timerData1_Tick);
            // 
            // tbCurrentData
            // 
            this.tbCurrentData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentData.Location = new System.Drawing.Point(582, 126);
            this.tbCurrentData.Name = "tbCurrentData";
            this.tbCurrentData.Size = new System.Drawing.Size(83, 21);
            this.tbCurrentData.TabIndex = 2;
            this.tbCurrentData.Text = "未开始采样";
            // 
            // labelCurrentData
            // 
            this.labelCurrentData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentData.AutoSize = true;
            this.labelCurrentData.Location = new System.Drawing.Point(582, 111);
            this.labelCurrentData.Name = "labelCurrentData";
            this.labelCurrentData.Size = new System.Drawing.Size(83, 12);
            this.labelCurrentData.TabIndex = 3;
            this.labelCurrentData.Text = "Current Data:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(590, 153);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Sto&p";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGlobal
            // 
            this.btnGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGlobal.Location = new System.Drawing.Point(590, 253);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(75, 21);
            this.btnGlobal.TabIndex = 5;
            this.btnGlobal.Text = "&Global Mode";
            this.btnGlobal.UseVisualStyleBackColor = true;
            this.btnGlobal.Click += new System.EventHandler(this.btnGlobal_Click);
            // 
            // btnFixedMove
            // 
            this.btnFixedMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFixedMove.Location = new System.Drawing.Point(590, 280);
            this.btnFixedMove.Name = "btnFixedMove";
            this.btnFixedMove.Size = new System.Drawing.Size(75, 21);
            this.btnFixedMove.TabIndex = 5;
            this.btnFixedMove.Text = "&Fixed Move";
            this.btnFixedMove.UseVisualStyleBackColor = true;
            this.btnFixedMove.Click += new System.EventHandler(this.btnFixedMove_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.Location = new System.Drawing.Point(590, 307);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 21);
            this.btnZoomIn.TabIndex = 6;
            this.btnZoomIn.Text = "&Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnDrag
            // 
            this.btnDrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrag.Location = new System.Drawing.Point(590, 335);
            this.btnDrag.Name = "btnDrag";
            this.btnDrag.Size = new System.Drawing.Size(75, 23);
            this.btnDrag.TabIndex = 10;
            this.btnDrag.Text = "&Drag";
            this.btnDrag.UseVisualStyleBackColor = true;
            this.btnDrag.Click += new System.EventHandler(this.btnDrag_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMsg,
            this.tslGraphType});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 385);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(671, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip";
            // 
            // tsMsg
            // 
            this.tsMsg.Name = "tsMsg";
            this.tsMsg.Size = new System.Drawing.Size(87, 17);
            this.tsMsg.Text = "Curve Message";
            // 
            // tslGraphType
            // 
            this.tslGraphType.Name = "tslGraphType";
            this.tslGraphType.Size = new System.Drawing.Size(68, 17);
            this.tslGraphType.Text = "Graph Type";
            // 
            // timerStatus
            // 
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // btnGrid
            // 
            this.btnGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrid.Location = new System.Drawing.Point(590, 226);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(75, 21);
            this.btnGrid.TabIndex = 12;
            this.btnGrid.Text = "Gr&id";
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(590, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreenShot.Location = new System.Drawing.Point(590, 50);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(75, 23);
            this.btnScreenShot.TabIndex = 14;
            this.btnScreenShot.Text = "ScreenShot";
            this.btnScreenShot.UseVisualStyleBackColor = true;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // graphControl
            // 
            this.graphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphControl.AxisXTitle = "时间(s)";
            this.graphControl.AxisYTitle = "距离(mm)";
            this.graphControl.GraphStyle = RealTimeGraph.GraphMode.FixMoveMode;
            this.graphControl.GraphTitle = "位移实时显示曲线";
            this.graphControl.InitialMaxX = 100F;
            this.graphControl.InitialMaxY = 100F;
            this.graphControl.InitialMinX = 0F;
            this.graphControl.InitialMinY = 0F;
            this.graphControl.Location = new System.Drawing.Point(13, 12);
            this.graphControl.Name = "graphControl";
            this.graphControl.Size = new System.Drawing.Size(565, 346);
            this.graphControl.TabIndex = 9;
            this.graphControl.XDataAccuracy = 0.1F;
            this.graphControl.YDataAccuracy = 0.1F;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 407);
            this.Controls.Add(this.btnScreenShot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnDrag);
            this.Controls.Add(this.graphControl);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnFixedMove);
            this.Controls.Add(this.btnGlobal);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelCurrentData);
            this.Controls.Add(this.tbCurrentData);
            this.Controls.Add(this.btnCurve1);
            this.Name = "TestForm";
            this.Text = "Real Time Graph Test";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCurve1;
        private System.Windows.Forms.Timer timerData1;
        private System.Windows.Forms.TextBox tbCurrentData;
        private System.Windows.Forms.Label labelCurrentData;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGlobal;
        private System.Windows.Forms.Button btnFixedMove;
        private System.Windows.Forms.Button btnZoomIn;
        private RealTimeGraph.GraphControl graphControl;
        private System.Windows.Forms.Button btnDrag;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsMsg;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripStatusLabel tslGraphType;
        private System.Windows.Forms.Button btnScreenShot;

    }
}

