namespace FakeItTillYouMakeIt
{
    partial class Form4
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFuel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTime2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_Background = new System.Windows.Forms.Timer(this.components);
            this.timerAddCloud = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerPlaneBeg = new System.Windows.Forms.Timer(this.components);
            this.pbTemperature = new System.Windows.Forms.ProgressBar();
            this.lblLifes = new System.Windows.Forms.Label();
            this.timerBeginning = new System.Windows.Forms.Timer(this.components);
            this.timerKometa = new System.Windows.Forms.Timer(this.components);
            this.tsslRobotCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCloudsDestroyed = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFuel,
            this.tsslTime2,
            this.toolStripStatusLabel3,
            this.tsslRobotCoordinates,
            this.tsslCloudsDestroyed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslFuel
            // 
            this.tsslFuel.Name = "tsslFuel";
            this.tsslFuel.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslTime2
            // 
            this.tsslTime2.Name = "tsslTime2";
            this.tsslTime2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // timer_Background
            // 
            this.timer_Background.Interval = 850;
            this.timer_Background.Tick += new System.EventHandler(this.timer_Background_Tick);
            // 
            // timerAddCloud
            // 
            this.timerAddCloud.Interval = 4500;
            this.timerAddCloud.Tick += new System.EventHandler(this.timerAddCloud_Tick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerPlaneBeg
            // 
            this.timerPlaneBeg.Interval = 850;
            this.timerPlaneBeg.Tick += new System.EventHandler(this.timerPlaneBeg_Tick);
            // 
            // pbTemperature
            // 
            this.pbTemperature.Location = new System.Drawing.Point(4, 38);
            this.pbTemperature.Name = "pbTemperature";
            this.pbTemperature.Size = new System.Drawing.Size(13, 283);
            this.pbTemperature.TabIndex = 2;
            // 
            // lblLifes
            // 
            this.lblLifes.AutoSize = true;
            this.lblLifes.BackColor = System.Drawing.Color.Transparent;
            this.lblLifes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLifes.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblLifes.Location = new System.Drawing.Point(718, 38);
            this.lblLifes.Name = "lblLifes";
            this.lblLifes.Size = new System.Drawing.Size(0, 25);
            this.lblLifes.TabIndex = 3;
            // 
            // timerBeginning
            // 
            this.timerBeginning.Interval = 1000;
            this.timerBeginning.Tick += new System.EventHandler(this.timerBeginning_Tick);
            // 
            // timerKometa
            // 
            this.timerKometa.Interval = 850;
            this.timerKometa.Tick += new System.EventHandler(this.timerKometa_Tick);
            // 
            // tsslRobotCoordinates
            // 
            this.tsslRobotCoordinates.Name = "tsslRobotCoordinates";
            this.tsslRobotCoordinates.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslCloudsDestroyed
            // 
            this.tsslCloudsDestroyed.Name = "tsslCloudsDestroyed";
            this.tsslCloudsDestroyed.Size = new System.Drawing.Size(0, 17);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 429);
            this.Controls.Add(this.lblLifes);
            this.Controls.Add(this.pbTemperature);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form4_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer_Background;
        private System.Windows.Forms.Timer timerAddCloud;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerPlaneBeg;
        private System.Windows.Forms.ProgressBar pbTemperature;
        private System.Windows.Forms.Label lblLifes;
        private System.Windows.Forms.ToolStripStatusLabel tsslFuel;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timerBeginning;
        private System.Windows.Forms.Timer timerKometa;
        private System.Windows.Forms.ToolStripStatusLabel tsslRobotCoordinates;
        private System.Windows.Forms.ToolStripStatusLabel tsslCloudsDestroyed;
    }
}