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
        private static Category_Selection _category_Selection = new Category_Selection();

        public static JeopardyAboutMenu jeopardyaboutmenu
        {
            get { return _jeopardyaboutmenu; }
        }
        public static JeopardyGameScreen jeopardygamescreen
        {
            get { return _jeopardygamescreen; }
        }
        public static Category_Selection category_Selection
        {
            get { return _category_Selection; }
        }
        public static JepordyInterface jeopardymainmenu
        {
            get { return jeopardymainmenu; }
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

        private void category_selection_btn_Click(object sender, EventArgs e)
        {
            category_Selection.Show();
            this.Hide();
        }

        //OtherMethods


    }
}

