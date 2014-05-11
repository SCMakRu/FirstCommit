namespace FakeItTillYouMakeIt
{
    partial class Form3
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
            this.timerBGMove = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslWH = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNoOfCoins = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslWeapon = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbPower = new System.Windows.Forms.ProgressBar();
            this.timerCoins = new System.Windows.Forms.Timer(this.components);
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblCoinsMissed = new System.Windows.Forms.Label();
            this.lblVortex = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblPBPower = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerBGMove
            // 
            this.timerBGMove.Enabled = true;
            this.timerBGMove.Interval = 40;
            this.timerBGMove.Tick += new System.EventHandler(this.timerBGMove_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWH,
            this.tsslNoOfCoins,
            this.tsslWeapon,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(762, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslWH
            // 
            this.tsslWH.Name = "tsslWH";
            this.tsslWH.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslNoOfCoins
            // 
            this.tsslNoOfCoins.Name = "tsslNoOfCoins";
            this.tsslNoOfCoins.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslWeapon
            // 
            this.tsslWeapon.Name = "tsslWeapon";
            this.tsslWeapon.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pbPower
            // 
            this.pbPower.BackColor = System.Drawing.Color.Lime;
            this.pbPower.ForeColor = System.Drawing.Color.Lime;
            this.pbPower.Location = new System.Drawing.Point(3, 3);
            this.pbPower.Maximum = 4;
            this.pbPower.Name = "pbPower";
            this.pbPower.Size = new System.Drawing.Size(97, 26);
            this.pbPower.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPower.TabIndex = 1;
            this.pbPower.Value = 4;
            this.pbPower.Click += new System.EventHandler(this.pbPower_Click);
            // 
            // timerCoins
            // 
            this.timerCoins.Interval = 50;
            this.timerCoins.Tick += new System.EventHandler(this.timerCoins_Tick);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Black;
            this.panelInfo.BackgroundImage = global::FakeItTillYouMakeIt.Properties.Resources.bg2;
            this.panelInfo.Controls.Add(this.lblCoinsMissed);
            this.panelInfo.Controls.Add(this.lblVortex);
            this.panelInfo.Controls.Add(this.lblPower);
            this.panelInfo.Controls.Add(this.lblPBPower);
            this.panelInfo.Controls.Add(this.lblCoins);
            this.panelInfo.Controls.Add(this.pbPower);
            this.panelInfo.Location = new System.Drawing.Point(659, 1);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(103, 341);
            this.panelInfo.TabIndex = 2;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfo_Paint);
            // 
            // lblCoinsMissed
            // 
            this.lblCoinsMissed.AutoSize = true;
            this.lblCoinsMissed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoinsMissed.ForeColor = System.Drawing.Color.Lime;
            this.lblCoinsMissed.Location = new System.Drawing.Point(3, 324);
            this.lblCoinsMissed.Name = "lblCoinsMissed";
            this.lblCoinsMissed.Size = new System.Drawing.Size(17, 16);
            this.lblCoinsMissed.TabIndex = 6;
            this.lblCoinsMissed.Text = "a";
            // 
            // lblVortex
            // 
            this.lblVortex.AutoSize = true;
            this.lblVortex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVortex.ForeColor = System.Drawing.Color.Lime;
            this.lblVortex.Location = new System.Drawing.Point(3, 64);
            this.lblVortex.Name = "lblVortex";
            this.lblVortex.Size = new System.Drawing.Size(17, 16);
            this.lblVortex.TabIndex = 5;
            this.lblVortex.Text = "a";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPower.ForeColor = System.Drawing.Color.Lime;
            this.lblPower.Location = new System.Drawing.Point(3, 48);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(17, 16);
            this.lblPower.TabIndex = 4;
            this.lblPower.Text = "a";
            // 
            // lblPBPower
            // 
            this.lblPBPower.AutoSize = true;
            this.lblPBPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPBPower.ForeColor = System.Drawing.Color.Lime;
            this.lblPBPower.Location = new System.Drawing.Point(3, 32);
            this.lblPBPower.Name = "lblPBPower";
            this.lblPBPower.Size = new System.Drawing.Size(17, 16);
            this.lblPBPower.TabIndex = 3;
            this.lblPBPower.Text = "a";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoins.ForeColor = System.Drawing.Color.Lime;
            this.lblCoins.Location = new System.Drawing.Point(3, 308);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(17, 16);
            this.lblCoins.TabIndex = 2;
            this.lblCoins.Text = "a";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(23, 13);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(0, 13);
            this.lblVreme.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 367);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResizeEnd += new System.EventHandler(this.Form3_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form3_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerBGMove;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslWH;
        private System.Windows.Forms.ProgressBar pbPower;
        private System.Windows.Forms.Timer timerCoins;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslNoOfCoins;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblPBPower;
        private System.Windows.Forms.Label lblVortex;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblCoinsMissed;
        private System.Windows.Forms.ToolStripStatusLabel tsslWeapon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblVreme;
    }
}