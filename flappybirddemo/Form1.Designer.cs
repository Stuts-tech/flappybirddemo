
namespace flappybirddemo
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
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.Image = global::flappybirddemo.Properties.Resources.flappyBird;
            this.flappybird.Location = new System.Drawing.Point(140, 200);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(83, 53);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // pipetop
            // 
            this.pipetop.Image = global::flappybirddemo.Properties.Resources.pipeTop;
            this.pipetop.Location = new System.Drawing.Point(424, -1);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(124, 137);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pipetop.TabIndex = 1;
            this.pipetop.TabStop = false;
            this.pipetop.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ground
            // 
            this.ground.Image = global::flappybirddemo.Properties.Resources.ground2;
            this.ground.Location = new System.Drawing.Point(-64, 462);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1342, 68);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            this.ground.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::flappybirddemo.Properties.Resources.pipeBottom;
            this.pipebottom.Location = new System.Drawing.Point(774, 321);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(106, 150);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pipebottom.TabIndex = 3;
            this.pipebottom.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(78, 45);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(124, 44);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "score:";
            this.scoretext.Click += new System.EventHandler(this.label1_Click);
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1205, 528);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.flappybird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gametimer;
    }
}

