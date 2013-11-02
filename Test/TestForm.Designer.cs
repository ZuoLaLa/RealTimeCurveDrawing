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
            this.btnStart = new System.Windows.Forms.Button();
            this.timerData = new System.Windows.Forms.Timer(this.components);
            this.tbCurrentData = new System.Windows.Forms.TextBox();
            this.labelCurrentData = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGlobal = new System.Windows.Forms.Button();
            this.btnFixedMove = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnInitialWidth = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDrag = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.rtgControl = new RealTimeGraph.RTGControl();
            this.btnGrid = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(587, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerData
            // 
            this.timerData.Interval = 200;
            this.timerData.Tick += new System.EventHandler(this.timerData_Tick);
            // 
            // tbCurrentData
            // 
            this.tbCurrentData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentData.Location = new System.Drawing.Point(584, 57);
            this.tbCurrentData.Name = "tbCurrentData";
            this.tbCurrentData.Size = new System.Drawing.Size(83, 20);
            this.tbCurrentData.TabIndex = 2;
            this.tbCurrentData.Text = "未开始采样";
            // 
            // labelCurrentData
            // 
            this.labelCurrentData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentData.AutoSize = true;
            this.labelCurrentData.Location = new System.Drawing.Point(584, 41);
            this.labelCurrentData.Name = "labelCurrentData";
            this.labelCurrentData.Size = new System.Drawing.Size(70, 13);
            this.labelCurrentData.TabIndex = 3;
            this.labelCurrentData.Text = "Current Data:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(587, 83);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 25);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGlobal
            // 
            this.btnGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGlobal.Location = new System.Drawing.Point(587, 194);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(75, 23);
            this.btnGlobal.TabIndex = 5;
            this.btnGlobal.Text = "&Global Mode";
            this.btnGlobal.UseVisualStyleBackColor = true;
            this.btnGlobal.Click += new System.EventHandler(this.btnGlobal_Click);
            // 
            // btnFixedMove
            // 
            this.btnFixedMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFixedMove.Location = new System.Drawing.Point(587, 223);
            this.btnFixedMove.Name = "btnFixedMove";
            this.btnFixedMove.Size = new System.Drawing.Size(75, 23);
            this.btnFixedMove.TabIndex = 5;
            this.btnFixedMove.Text = "&Fixed Move";
            this.btnFixedMove.UseVisualStyleBackColor = true;
            this.btnFixedMove.Click += new System.EventHandler(this.btnFixedMove_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.Location = new System.Drawing.Point(587, 252);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 6;
            this.btnZoomIn.Text = "&Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnInitialWidth
            // 
            this.btnInitialWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInitialWidth.Location = new System.Drawing.Point(587, 335);
            this.btnInitialWidth.Name = "btnInitialWidth";
            this.btnInitialWidth.Size = new System.Drawing.Size(75, 23);
            this.btnInitialWidth.TabIndex = 7;
            this.btnInitialWidth.Text = "Initial &Width";
            this.btnInitialWidth.UseVisualStyleBackColor = true;
            this.btnInitialWidth.Click += new System.EventHandler(this.btnInitialWidth_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(587, 364);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDrag
            // 
            this.btnDrag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrag.Location = new System.Drawing.Point(587, 283);
            this.btnDrag.Name = "btnDrag";
            this.btnDrag.Size = new System.Drawing.Size(75, 25);
            this.btnDrag.TabIndex = 10;
            this.btnDrag.Text = "&Drag";
            this.btnDrag.UseVisualStyleBackColor = true;
            this.btnDrag.Click += new System.EventHandler(this.btnDrag_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMsg});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
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
            // timerStatus
            // 
            this.timerStatus.Interval = 1000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // rtgControl
            // 
            this.rtgControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtgControl.GraphTitle = "位移实时显示曲线";
            this.rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.FixedMoveMode;
            this.rtgControl.GraphXTitle = "时间(s)";
            this.rtgControl.GraphYTitle = "距离(mm)";
            this.rtgControl.Location = new System.Drawing.Point(13, 13);
            this.rtgControl.Name = "rtgControl";
            this.rtgControl.Size = new System.Drawing.Size(565, 375);
            this.rtgControl.TabIndex = 9;
            this.rtgControl.XDataAccuracy = 1F;
            this.rtgControl.YDataAccuracy = 0.1F;
            // 
            // btnGrid
            // 
            this.btnGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrid.Location = new System.Drawing.Point(587, 132);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(75, 23);
            this.btnGrid.TabIndex = 12;
            this.btnGrid.Text = "Gri&d";
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 441);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnDrag);
            this.Controls.Add(this.rtgControl);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnInitialWidth);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnFixedMove);
            this.Controls.Add(this.btnGlobal);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelCurrentData);
            this.Controls.Add(this.tbCurrentData);
            this.Controls.Add(this.btnStart);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerData;
        private System.Windows.Forms.TextBox tbCurrentData;
        private System.Windows.Forms.Label labelCurrentData;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGlobal;
        private System.Windows.Forms.Button btnFixedMove;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnInitialWidth;
        private System.Windows.Forms.Button btnReset;
        private RealTimeGraph.RTGControl rtgControl;
        private System.Windows.Forms.Button btnDrag;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsMsg;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Button btnGrid;

    }
}

