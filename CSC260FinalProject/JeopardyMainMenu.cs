using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC260FinalProject
{
    public partial class JepordyInterface : Form
    {
        #region initializers
        public JepordyInterface()
        {
            InitializeComponent();
        }
        private static JeopardyAboutMenu _jeopardyaboutmenu = new JeopardyAboutMenu();
        private static JeopardyGameScreen _jeopardygamescreen = new JeopardyGameScreen();
        private static JeopardyRulesMenu _jeopardyrulesmenu = new JeopardyRulesMenu();
         static JeopardyAboutMenu jeopardyaboutmenu
        {
            get { return _jeopardyaboutmenu; }
        }
        public static JeopardyGameScreen jeopardygamescreen
        {
            get { return _jeopardygamescreen; }
        }
        public static JepordyInterface jeopardymainmenu
        {
            get { return jeopardymainmenu; }
        }
        public static JeopardyRulesMenu jeopardyrulesmenu
        {
            get { return _jeopardyrulesmenu; }
        }



        #endregion

        private void JeopardyMainMenu_Load(object sender, EventArgs e)
        {

        }

        //Buttons
        private void play_btn_Click(object sender, EventArgs e)
        {
            jeopardygamescreen.Show();
            this.Hide();
        }
        private void rules_btn_Click(object sender, EventArgs e)
        {
            jeopardyrulesmenu.Show();
            this.Hide();
        }
        private void About_Click(object sender, EventArgs e)
        {
            jeopardyaboutmenu.Show();
            this.Hide();

        }

        private void closeapplication_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //OtherMethods


    }
}

