namespace FakeItTillYouMakeIt
{
    partial class Form2
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLevel = new System.Windows.Forms.Button();
            this.rbLevel1 = new System.Windows.Forms.RadioButton();
            this.rbLevel2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBeginning = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::FakeItTillYouMakeIt.Properties.Resources.x;
            this.btnClose.Location = new System.Drawing.Point(468, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLevel
            // 
            this.btnLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLevel.BackgroundImage = global::FakeItTillYouMakeIt.Properties.Resources.star2;
            this.btnLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLevel.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLevel.Location = new System.Drawing.Point(345, 237);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(150, 62);
            this.btnLevel.TabIndex = 1;
            this.btnLevel.Text = "P l a y ";
            this.btnLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLevel.UseVisualStyleBackColor = false;
            this.btnLevel.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbLevel1
            // 
            this.rbLevel1.AutoSize = true;
            this.rbLevel1.BackColor = System.Drawing.Color.Transparent;
            this.rbLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLevel1.ForeColor = System.Drawing.SystemColors.Control;
            this.rbLevel1.Location = new System.Drawing.Point(335, 59);
            this.rbLevel1.Name = "rbLevel1";
            this.rbLevel1.Size = new System.Drawing.Size(149, 28);
            this.rbLevel1.TabIndex = 3;
            this.rbLevel1.Text = " L e v e l   1  ";
            this.rbLevel1.UseVisualStyleBackColor = false;
            // 
            // rbLevel2
            // 
            this.rbLevel2.AutoSize = true;
            this.rbLevel2.BackColor = System.Drawing.Color.Transparent;
            this.rbLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLevel2.ForeColor = System.Drawing.SystemColors.Control;
            this.rbLevel2.Location = new System.Drawing.Point(335, 112);
            this.rbLevel2.Name = "rbLevel2";
            this.rbLevel2.Size = new System.Drawing.Size(143, 28);
            this.rbLevel2.TabIndex = 4;
            this.rbLevel2.Text = " L e v e l   2 ";
            this.rbLevel2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Keep it till the end";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::FakeItTillYouMakeIt.Properties.Resources._4508363357;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem});
            this.instructionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // timerBeginning
            // 
            this.timerBeginning.Tick += new System.EventHandler(this.timerBeginning_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FakeItTillYouMakeIt.Properties.Resources._45083633571;
            this.ClientSize = new System.Drawing.Size(507, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbLevel2);
            this.Controls.Add(this.rbLevel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLevel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbLevel1;
        private System.Windows.Forms.RadioButton rbLevel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.Timer timerBeginning;

    }
}