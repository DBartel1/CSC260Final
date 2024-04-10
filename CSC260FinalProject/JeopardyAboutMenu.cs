using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC260FinalProject
{
    public partial class JeopardyAboutMenu : Form
    {
        public JeopardyAboutMenu()
        {
            InitializeComponent();
        }

        private void JeopardyAboutMenu_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JeopardyAboutMenu));
            this.JeopardyLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JeopardyLabel
            // 
            this.JeopardyLabel.AutoSize = true;
            this.JeopardyLabel.BackColor = System.Drawing.Color.Transparent;
            this.JeopardyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JeopardyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.JeopardyLabel.Image = global::CSC260FinalProject.Properties.Resources._36442_3439547833;
            this.JeopardyLabel.Location = new System.Drawing.Point(244, 9);
            this.JeopardyLabel.MaximumSize = new System.Drawing.Size(700, 200);
            this.JeopardyLabel.MinimumSize = new System.Drawing.Size(700, 200);
            this.JeopardyLabel.Name = "JeopardyLabel";
            this.JeopardyLabel.Size = new System.Drawing.Size(700, 200);
            this.JeopardyLabel.TabIndex = 0;
            this.JeopardyLabel.Click += new System.EventHandler(this.JeopardyLabel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.richTextBox1.Location = new System.Drawing.Point(408, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(416, 415);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DimGray;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(1041, 645);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(131, 74);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // JeopardyAboutMenu
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CSC260FinalProject.Properties.Resources.jeopardy_board_1596958685;
            this.ClientSize = new System.Drawing.Size(1184, 731);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.JeopardyLabel);
            this.Name = "JeopardyAboutMenu";
            this.Load += new System.EventHandler(this.JeopardyAboutMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void JeopardyAboutMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void JeopardyLabel_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            JepordyInterface form = new JepordyInterface();
            form.Show();
            this.Hide();

        }
    }
}
