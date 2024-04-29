using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC260FinalProject
{
    public partial class JeopardyGameScreen : Form
    {
        public string answer { get; set; }
        public string userInput { get; set; }
        public string correctanswer { get; set; }
        static int score;
        public int totalscore;
        public JeopardyGameScreen()
        {
            InitializeComponent();
        }

        private void c1q5_Click(object sender, EventArgs e)
        {

        }

        private void c1q1_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "Ron is a wizard and this persons best friend";
            correctanswer = "The correct answer is \"Who is Harry Potter?\"";
            answer = "Who is Harry Potter?";
            score = 100;
            c1q1.BackColor = Color.DimGray;

        }

        private void c1q2_Click(object sender, EventArgs e)
        {
            
        }

        private void c1q3_Click(object sender, EventArgs e)
        {

        }

        private void c1q4_Click(object sender, EventArgs e)
        {

        }

        private void c1Display_Click(object sender, EventArgs e)
        {
            
        }

        private void questionDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void answertxtbox_TextChanged(object sender, EventArgs e)
        {
            
            userInput = answertxtbox.Text;  
            Console.WriteLine(userInput);
            Console.WriteLine(answer);
            
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(userInput);
            if (string.Equals(userInput, answer))
            {
                totalscore += score;
                winningsamountint.Text = ("$" + totalscore);
                Console.WriteLine(score);
                answer = "reset";
            }
            else
            {
               // Console.WriteLine(correctanswer);
                questionDisplay.Text = correctanswer;
            }
        }

        private void winningsAmount_Click(object sender, EventArgs e)
        {

        }

        private void winningsamountint_Click(object sender, EventArgs e)
        {
           // winningsamountint.Text = ("$" + totalscore);
        }
    }
}
