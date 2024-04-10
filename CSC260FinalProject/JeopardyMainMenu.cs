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
    public partial class JepordyInterface : Form
    {
        public JepordyInterface()
        {
            InitializeComponent();
        }

        private void JeopardyMainMenu_Load(object sender, EventArgs e)
        {

        }

        //Buttons
        private void play_btn_Click(object sender, EventArgs e)
        {

        }
        private void rules_btn_Click(object sender, EventArgs e)
        {

        }
        private void About_Click(object sender, EventArgs e)
        {
            JeopardyAboutMenu form = new JeopardyAboutMenu();
            form.Show();
            this.Hide();

        }

        private void closeapplication_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //OtherMethods


    }
}
