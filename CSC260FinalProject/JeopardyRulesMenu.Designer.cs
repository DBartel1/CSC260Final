namespace CSC260FinalProject
{
    partial class JeopardyRulesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JeopardyRulesMenu));
            this.rulesTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rulesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.rulesTextBox.Location = new System.Drawing.Point(442, 156);
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.Size = new System.Drawing.Size(300, 465);
            this.rulesTextBox.TabIndex = 0;
            this.rulesTextBox.Text = resources.GetString("rulesTextBox.Text");
            this.rulesTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rules";
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.DimGray;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backbtn.Location = new System.Drawing.Point(1041, 645);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(131, 74);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // JeopardyRulesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CSC260FinalProject.Properties.Resources.jeopardy_board_1596958685;
            this.ClientSize = new System.Drawing.Size(1184, 789);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rulesTextBox);
            this.Name = "JeopardyRulesMenu";
            this.Text = "JeopardyRulesMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rulesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
    }
}