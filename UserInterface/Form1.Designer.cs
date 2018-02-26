namespace HID_PnP_Demo
{
    partial class Form1
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
            this.PushbuttonState_lbl = new System.Windows.Forms.Label();
            this.StatusBox_lbl = new System.Windows.Forms.Label();
            this.StatusBox_txtbx = new System.Windows.Forms.TextBox();
            this.ReadWriteThread = new System.ComponentModel.BackgroundWorker();
            this.FormUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.ANxVoltageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ToggleLEDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PushbuttonStateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.Random = new System.Windows.Forms.Button();
            this.MoveCountLabel = new System.Windows.Forms.Label();
            this.MoveCountDisplay = new System.Windows.Forms.TextBox();
            this.GetImage = new System.Windows.Forms.Button();
            this.RestartApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EasySolve = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.PushButtonLabelTwo = new System.Windows.Forms.Label();
            this.PushButtonLabelThree = new System.Windows.Forms.Label();
            this.PushButtonLabelFour = new System.Windows.Forms.Label();
            this.TileNumbersOnOff = new System.Windows.Forms.Button();
            this.SolvedLabel = new System.Windows.Forms.Label();
            this.FileDirectory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PushbuttonState_lbl
            // 
            this.PushbuttonState_lbl.AutoSize = true;
            this.PushbuttonState_lbl.Enabled = false;
            this.PushbuttonState_lbl.Location = new System.Drawing.Point(32, 674);
            this.PushbuttonState_lbl.Name = "PushbuttonState_lbl";
            this.PushbuttonState_lbl.Size = new System.Drawing.Size(141, 13);
            this.PushbuttonState_lbl.TabIndex = 25;
            this.PushbuttonState_lbl.Text = "Pushbutton State: Unknown";
            // 
            // StatusBox_lbl
            // 
            this.StatusBox_lbl.AutoSize = true;
            this.StatusBox_lbl.Location = new System.Drawing.Point(377, 624);
            this.StatusBox_lbl.Name = "StatusBox_lbl";
            this.StatusBox_lbl.Size = new System.Drawing.Size(37, 13);
            this.StatusBox_lbl.TabIndex = 22;
            this.StatusBox_lbl.Text = "Status";
            // 
            // StatusBox_txtbx
            // 
            this.StatusBox_txtbx.BackColor = System.Drawing.SystemColors.Window;
            this.StatusBox_txtbx.Location = new System.Drawing.Point(73, 621);
            this.StatusBox_txtbx.Name = "StatusBox_txtbx";
            this.StatusBox_txtbx.ReadOnly = true;
            this.StatusBox_txtbx.Size = new System.Drawing.Size(298, 20);
            this.StatusBox_txtbx.TabIndex = 21;
            // 
            // ReadWriteThread
            // 
            this.ReadWriteThread.WorkerReportsProgress = true;
            this.ReadWriteThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReadWriteThread_DoWork);
            // 
            // FormUpdateTimer
            // 
            this.FormUpdateTimer.Enabled = true;
            this.FormUpdateTimer.Interval = 6;
            this.FormUpdateTimer.Tick += new System.EventHandler(this.FormUpdateTimer_Tick);
            // 
            // ANxVoltageToolTip
            // 
            this.ANxVoltageToolTip.AutomaticDelay = 20;
            this.ANxVoltageToolTip.AutoPopDelay = 20000;
            this.ANxVoltageToolTip.InitialDelay = 15;
            this.ANxVoltageToolTip.ReshowDelay = 15;
            // 
            // ToggleLEDToolTip
            // 
            this.ToggleLEDToolTip.AutomaticDelay = 2000;
            this.ToggleLEDToolTip.AutoPopDelay = 20000;
            this.ToggleLEDToolTip.InitialDelay = 15;
            this.ToggleLEDToolTip.ReshowDelay = 15;
            // 
            // PushbuttonStateTooltip
            // 
            this.PushbuttonStateTooltip.AutomaticDelay = 20;
            this.PushbuttonStateTooltip.AutoPopDelay = 20000;
            this.PushbuttonStateTooltip.InitialDelay = 15;
            this.PushbuttonStateTooltip.ReshowDelay = 15;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 2000;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 15;
            this.toolTip1.ReshowDelay = 15;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 20;
            this.toolTip2.AutoPopDelay = 20000;
            this.toolTip2.InitialDelay = 15;
            this.toolTip2.ReshowDelay = 15;
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(356, 584);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(100, 23);
            this.Random.TabIndex = 1;
            this.Random.Text = "Full Jumble";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // MoveCountLabel
            // 
            this.MoveCountLabel.AutoSize = true;
            this.MoveCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MoveCountLabel.Location = new System.Drawing.Point(566, 197);
            this.MoveCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MoveCountLabel.Name = "MoveCountLabel";
            this.MoveCountLabel.Size = new System.Drawing.Size(165, 24);
            this.MoveCountLabel.TabIndex = 26;
            this.MoveCountLabel.Text = "Number of Moves:";
            // 
            // MoveCountDisplay
            // 
            this.MoveCountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MoveCountDisplay.Location = new System.Drawing.Point(736, 193);
            this.MoveCountDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoveCountDisplay.Name = "MoveCountDisplay";
            this.MoveCountDisplay.ReadOnly = true;
            this.MoveCountDisplay.Size = new System.Drawing.Size(66, 29);
            this.MoveCountDisplay.TabIndex = 27;
            // 
            // GetImage
            // 
            this.GetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GetImage.Location = new System.Drawing.Point(169, 535);
            this.GetImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetImage.Name = "GetImage";
            this.GetImage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GetImage.Size = new System.Drawing.Size(122, 46);
            this.GetImage.TabIndex = 29;
            this.GetImage.Text = "Get Image";
            this.GetImage.UseVisualStyleBackColor = true;
            this.GetImage.Click += new System.EventHandler(this.GetImage_Click);
            // 
            // RestartApp
            // 
            this.RestartApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartApp.Location = new System.Drawing.Point(656, 568);
            this.RestartApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RestartApp.Name = "RestartApp";
            this.RestartApp.Size = new System.Drawing.Size(106, 46);
            this.RestartApp.TabIndex = 4;
            this.RestartApp.Text = "Restart";
            this.RestartApp.UseVisualStyleBackColor = true;
            this.RestartApp.Click += new System.EventHandler(this.RestartApp_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 528);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EasySolve
            // 
            this.EasySolve.Location = new System.Drawing.Point(27, 584);
            this.EasySolve.Name = "EasySolve";
            this.EasySolve.Size = new System.Drawing.Size(100, 23);
            this.EasySolve.TabIndex = 31;
            this.EasySolve.Text = "Simple Jumble";
            this.EasySolve.UseVisualStyleBackColor = true;
            this.EasySolve.Click += new System.EventHandler(this.EasySolve_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(493, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(389, 108);
            this.Title.TabIndex = 34;
            this.Title.Text = "WELCOME TO SLIDE PUZZLE";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PushButtonLabelTwo
            // 
            this.PushButtonLabelTwo.AutoSize = true;
            this.PushButtonLabelTwo.Enabled = false;
            this.PushButtonLabelTwo.Location = new System.Drawing.Point(260, 674);
            this.PushButtonLabelTwo.Name = "PushButtonLabelTwo";
            this.PushButtonLabelTwo.Size = new System.Drawing.Size(150, 13);
            this.PushButtonLabelTwo.TabIndex = 35;
            this.PushButtonLabelTwo.Text = "Pushbutton 2 State: Unknown";
            // 
            // PushButtonLabelThree
            // 
            this.PushButtonLabelThree.AutoSize = true;
            this.PushButtonLabelThree.Enabled = false;
            this.PushButtonLabelThree.Location = new System.Drawing.Point(497, 674);
            this.PushButtonLabelThree.Name = "PushButtonLabelThree";
            this.PushButtonLabelThree.Size = new System.Drawing.Size(150, 13);
            this.PushButtonLabelThree.TabIndex = 36;
            this.PushButtonLabelThree.Text = "Pushbutton 3 State: Unknown";
            // 
            // PushButtonLabelFour
            // 
            this.PushButtonLabelFour.AutoSize = true;
            this.PushButtonLabelFour.Enabled = false;
            this.PushButtonLabelFour.Location = new System.Drawing.Point(717, 674);
            this.PushButtonLabelFour.Name = "PushButtonLabelFour";
            this.PushButtonLabelFour.Size = new System.Drawing.Size(150, 13);
            this.PushButtonLabelFour.TabIndex = 37;
            this.PushButtonLabelFour.Text = "Pushbutton 4 State: Unknown";
            // 
            // TileNumbersOnOff
            // 
            this.TileNumbersOnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TileNumbersOnOff.Location = new System.Drawing.Point(161, 535);
            this.TileNumbersOnOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TileNumbersOnOff.Name = "TileNumbersOnOff";
            this.TileNumbersOnOff.Size = new System.Drawing.Size(130, 50);
            this.TileNumbersOnOff.TabIndex = 39;
            this.TileNumbersOnOff.Text = "Turn Numbers Off";
            this.TileNumbersOnOff.UseVisualStyleBackColor = true;
            this.TileNumbersOnOff.Visible = false;
            this.TileNumbersOnOff.Click += new System.EventHandler(this.TileNumbersOnOff_Click);
            // 
            // SolvedLabel
            // 
            this.SolvedLabel.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SolvedLabel.Location = new System.Drawing.Point(580, 108);
            this.SolvedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SolvedLabel.Name = "SolvedLabel";
            this.SolvedLabel.Size = new System.Drawing.Size(204, 34);
            this.SolvedLabel.TabIndex = 40;
            this.SolvedLabel.Text = "GOOD LUCK!";
            this.SolvedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileDirectory
            // 
            this.FileDirectory.AutoEllipsis = true;
            this.FileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FileDirectory.Location = new System.Drawing.Point(516, 284);
            this.FileDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileDirectory.Name = "FileDirectory";
            this.FileDirectory.Size = new System.Drawing.Size(338, 87);
            this.FileDirectory.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 696);
            this.Controls.Add(this.FileDirectory);
            this.Controls.Add(this.SolvedLabel);
            this.Controls.Add(this.TileNumbersOnOff);
            this.Controls.Add(this.PushButtonLabelFour);
            this.Controls.Add(this.PushButtonLabelThree);
            this.Controls.Add(this.PushButtonLabelTwo);
            this.Controls.Add(this.PushbuttonState_lbl);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.EasySolve);
            this.Controls.Add(this.StatusBox_txtbx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatusBox_lbl);
            this.Controls.Add(this.RestartApp);
            this.Controls.Add(this.GetImage);
            this.Controls.Add(this.MoveCountDisplay);
            this.Controls.Add(this.MoveCountLabel);
            this.Controls.Add(this.Random);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Sliding Puzzle Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PushbuttonState_lbl;
        private System.Windows.Forms.Label StatusBox_lbl;
        private System.Windows.Forms.TextBox StatusBox_txtbx;
        private System.ComponentModel.BackgroundWorker ReadWriteThread;
        private System.Windows.Forms.Timer FormUpdateTimer;
        private System.Windows.Forms.ToolTip ANxVoltageToolTip;
        private System.Windows.Forms.ToolTip ToggleLEDToolTip;
        private System.Windows.Forms.ToolTip PushbuttonStateTooltip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Label MoveCountLabel;
        private System.Windows.Forms.TextBox MoveCountDisplay;
        private System.Windows.Forms.Button GetImage;
        private System.Windows.Forms.Button RestartApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EasySolve;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PushButtonLabelTwo;
        private System.Windows.Forms.Label PushButtonLabelThree;
        private System.Windows.Forms.Label PushButtonLabelFour;
        private System.Windows.Forms.Button TileNumbersOnOff;
        public System.Windows.Forms.Label SolvedLabel;
        private System.Windows.Forms.Label FileDirectory;
    }
}

