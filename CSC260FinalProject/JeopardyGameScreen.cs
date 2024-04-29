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
        #region properties
        public string answer { get; set; }
        public string userInput { get; set; }
        public string correctanswer { get; set; }
        static int score;
        public int totalscore;
        #endregion
        #region constructures 
        public JeopardyGameScreen()
        {
            InitializeComponent();
        }
        #endregion
        #region category 1

        private void c1q1_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "Ron is a wizard and this persons best friend.";
            correctanswer = "The correct answer is \"Who is Harry Potter?\"";
            answer = "Who is Harry Potter?";
            score = 100;
            c1q1.BackColor = Color.DimGray;

        }

        private void c1q2_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "A planet like structure owned by the Empire.";
            correctanswer = "The correct answer is \"What is the Death Star?\"";
            answer = "What is the Death Star?";
            score = 200;
            c1q2.BackColor = Color.DimGray;
        }

        private void c1q3_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The main villian in Avengers Infinity War and Avengers End Game.";
            correctanswer = "The correct answer is \"Who is Thanos?\"";
            answer = "Who is Thanos?";
            score = 300;
            c1q3.BackColor = Color.DimGray;
        }
        private void c1q4_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "Katniss Everdeen is her sister.";
            correctanswer = "The correct answer is \"Who is Prim?\"";
            answer = "Who is Prim?";
            score = 400;
            c1q4.BackColor = Color.DimGray;
        }
        private void c1q5_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "He fled from police in an infamous chase driving a Ford Bronco.";
            correctanswer = "The correct answer is \"Who is OJ Simpson?\"";
            answer = "Who is OJ Simpson?";
            score = 500;
            c1q5.BackColor = Color.DimGray;
        }
        #endregion
        #region category 2
        private void c2q1_Click(object sender, EventArgs e)
        {

        }

        private void c2q2_Click(object sender, EventArgs e)
        {

        }

        private void c2q3_Click(object sender, EventArgs e)
        {

        }

        private void c2q4_Click(object sender, EventArgs e)
        {

        }

        private void c2q5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region displaying answer and checking to see if correct
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
                questionDisplay.Text = "Correct!";
                answertxtbox.Text = "";
            }
            else
            {
                questionDisplay.Text = correctanswer;
                answer = "reset";
                answertxtbox.Text = "";
            }
        }
        #endregion

        #region labels and textboxes that need no code inside of them
        private void winningsAmount_Click(object sender, EventArgs e){}
        private void winningsamountint_Click(object sender, EventArgs e) {}
        private void c1Display_Click(object sender, EventArgs e) {}
        private void questionDisplay_TextChanged(object sender, EventArgs e) {}
        #endregion

        
    }
}
