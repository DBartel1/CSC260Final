namespace CSC260FinalProject
{
    partial class JepordyInterface
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
            this.play_btn = new System.Windows.Forms.Button();
            this.rules_btn = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.mainmenutext = new System.Windows.Forms.Label();
            this.closegame_btn = new System.Windows.Forms.Button();
            this.closeapplication_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Silver;
            this.play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Location = new System.Drawing.Point(492, 246);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(237, 96);
            this.play_btn.TabIndex = 0;
            this.play_btn.Text = "Play!";
            this.play_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // rules_btn
            // 
            this.rules_btn.BackColor = System.Drawing.Color.Silver;
            this.rules_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules_btn.Location = new System.Drawing.Point(492, 546);
            this.rules_btn.Name = "rules_btn";
            this.rules_btn.Size = new System.Drawing.Size(237, 100);
            this.rules_btn.TabIndex = 1;
            this.rules_btn.Text = "Rules";
            this.rules_btn.UseVisualStyleBackColor = false;
            this.rules_btn.Click += new System.EventHandler(this.rules_btn_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Silver;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Location = new System.Drawing.Point(492, 395);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(237, 102);
            this.About.TabIndex = 2;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // mainmenutext
            // 
            this.mainmenutext.AutoSize = true;
            this.mainmenutext.BackColor = System.Drawing.Color.Transparent;
            this.mainmenutext.Image = global::CSC260FinalProject.Properties.Resources._36442_3439547833;
            this.mainmenutext.Location = new System.Drawing.Point(244, 9);
            this.mainmenutext.MaximumSize = new System.Drawing.Size(700, 200);
            this.mainmenutext.MinimumSize = new System.Drawing.Size(700, 200);
            this.mainmenutext.Name = "mainmenutext";
            this.mainmenutext.Size = new System.Drawing.Size(700, 200);
            this.mainmenutext.TabIndex = 3;
            // 
            // closegame_btn
            // 
            this.closegame_btn.Location = new System.Drawing.Point(0, 0);
            this.closegame_btn.Name = "closegame_btn";
            this.closegame_btn.Size = new System.Drawing.Size(75, 23);
            this.closegame_btn.TabIndex = 0;
            // 
            // closeapplication_btn
            // 
            this.closeapplication_btn.BackColor = System.Drawing.Color.Silver;
            this.closeapplication_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeapplication_btn.Location = new System.Drawing.Point(1004, 640);
            this.closeapplication_btn.Name = "closeapplication_btn";
            this.closeapplication_btn.Size = new System.Drawing.Size(168, 79);
            this.closeapplication_btn.TabIndex = 4;
            this.closeapplication_btn.Text = "Exit Application";
            this.closeapplication_btn.UseVisualStyleBackColor = false;
            this.closeapplication_btn.Click += new System.EventHandler(this.closeapplication_btn_Click);
            // 
            // JepordyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::CSC260FinalProject.Properties.Resources.jeopardy_board_1596958685;
            this.ClientSize = new System.Drawing.Size(1184, 731);
            this.Controls.Add(this.closeapplication_btn);
            this.Controls.Add(this.closegame_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.mainmenutext);
            this.Controls.Add(this.About);
            this.Controls.Add(this.rules_btn);
            this.Name = "JepordyInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.JeopardyMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button rules_btn;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Label mainmenutext;
        private System.Windows.Forms.Button closegame_btn;
        private System.Windows.Forms.Button closeapplication_btn;
    }
}

