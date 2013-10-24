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
            this.rtgControl = new RealTimeGraph.RTGControl();
            this.btnDrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(584, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
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
            this.tbCurrentData.Location = new System.Drawing.Point(584, 103);
            this.tbCurrentData.Name = "tbCurrentData";
            this.tbCurrentData.Size = new System.Drawing.Size(83, 21);
            this.tbCurrentData.TabIndex = 2;
            this.tbCurrentData.Text = "未开始采样";
            // 
            // labelCurrentData
            // 
            this.labelCurrentData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentData.AutoSize = true;
            this.labelCurrentData.Location = new System.Drawing.Point(584, 72);
            this.labelCurrentData.Name = "labelCurrentData";
            this.labelCurrentData.Size = new System.Drawing.Size(83, 12);
            this.labelCurrentData.TabIndex = 3;
            this.labelCurrentData.Text = "Current Data:";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(587, 127);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGlobal
            // 
            this.btnGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGlobal.Location = new System.Drawing.Point(587, 179);
            this.btnGlobal.Name = "btnGlobal";
            this.btnGlobal.Size = new System.Drawing.Size(75, 21);
            this.btnGlobal.TabIndex = 5;
            this.btnGlobal.Text = "&Global Mode";
            this.btnGlobal.UseVisualStyleBackColor = true;
            this.btnGlobal.Click += new System.EventHandler(this.btnGlobal_Click);
            // 
            // btnFixedMove
            // 
            this.btnFixedMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFixedMove.Location = new System.Drawing.Point(587, 206);
            this.btnFixedMove.Name = "btnFixedMove";
            this.btnFixedMove.Size = new System.Drawing.Size(75, 21);
            this.btnFixedMove.TabIndex = 5;
            this.btnFixedMove.Text = "&Fixed Move";
            this.btnFixedMove.UseVisualStyleBackColor = true;
            this.btnFixedMove.Click += new System.EventHandler(this.btnFixedMove_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.Location = new System.Drawing.Point(587, 233);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 21);
            this.btnZoomIn.TabIndex = 6;
            this.btnZoomIn.Text = "&Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnInitialWidth
            // 
            this.btnInitialWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInitialWidth.Location = new System.Drawing.Point(587, 309);
            this.btnInitialWidth.Name = "btnInitialWidth";
            this.btnInitialWidth.Size = new System.Drawing.Size(75, 21);
            this.btnInitialWidth.TabIndex = 7;
            this.btnInitialWidth.Text = "Initial &Width";
            this.btnInitialWidth.UseVisualStyleBackColor = true;
            this.btnInitialWidth.Click += new System.EventHandler(this.btnInitialWidth_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(587, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 21);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rtgControl
            // 
            this.rtgControl.GraphTitle = "位移实时显示曲线";
            this.rtgControl.GraphType = RealTimeGraph.RTGControl.GraphTypes.FixedMoveMode;
            this.rtgControl.GraphXTitle = "Time";
            this.rtgControl.GraphYTitle = "距离(mm)";
            this.rtgControl.Location = new System.Drawing.Point(13, 12);
            this.rtgControl.Name = "rtgControl";
            this.rtgControl.Size = new System.Drawing.Size(565, 346);
            this.rtgControl.TabIndex = 9;
            // 
            // btnDrag
            // 
            this.btnDrag.Location = new System.Drawing.Point(587, 261);
            this.btnDrag.Name = "btnDrag";
            this.btnDrag.Size = new System.Drawing.Size(75, 23);
            this.btnDrag.TabIndex = 10;
            this.btnDrag.Text = "&Drag";
            this.btnDrag.UseVisualStyleBackColor = true;
            this.btnDrag.Click += new System.EventHandler(this.btnDrag_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 369);
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

    }
}

