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
            questionDisplay.Text = "A moon like structure built by the Empire.";
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
            questionDisplay.Text = "The line \" Luke I am your father. \" comes from this movie. ";
            correctanswer = "The correct answer is \" Star Wars the Empire Strikes Back \"";
            answer = "Star Wars the Empire Strikes Back";
            score = 100;
            c2q1.BackColor = Color.DimGray;
        }

        private void c2q2_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The line \" Leave the gun take the cannoli. \" comes from this movie. ";
            correctanswer = "The correct answer is \" The Godfather. \"";
            answer = "The Godfather";
            score = 200;
            c2q2.BackColor = Color.DimGray;
        }

        private void c2q3_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The line \" Ohana means family. Family means nobody gets left behind or forgotten \" comes from this movie. ";
            correctanswer = "The correct answer is \" Lilo and Stitch\"";
            answer = "Lilo and Stitch";
            score = 300;
            c2q3.BackColor = Color.DimGray;
        }

        private void c2q4_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The line \"Life moves pretty fast. If you don't stop and look around once in a while, you could miss it.\" comes from this movie. ";
            correctanswer = "The correct answer is \" Ferris Beulers day off. \"";
            answer = "Ferris Beulers day off";
            score = 400;
            c2q4.BackColor = Color.DimGray;
        }

        private void c2q5_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The line \"If it bleeds, we can kill it. \" comes from this movie. "; ;
            correctanswer = "The correct answer is \"The Predator\"";
            answer = "The Predator";
            score = 500;
            c2q5.BackColor = Color.DimGray;
        }
        #endregion
        #region category 3
        private void c3q1_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "Luigi is this characters brother.";
            correctanswer = "The correct answer is \"Who is Mario?\"";
            answer = "Who is Mario?";
            score = 100;
            c3q1.BackColor = Color.DimGray;
        }

        private void c3q2_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The player tries to clear lines by using different blocks in this game. ";
            correctanswer = "The correct answer is \"What is Tetris?\"";
            answer = "What is Tetris?";
            score = 200;
            c3q2.BackColor = Color.DimGray;
        }

        private void c3q3_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "This popular video game released in 2012 uses blocks for everything in it's world.";
            correctanswer = "The correct answer is \"What is Minecraft? \"";
            answer = "What is Minecraft?";
            score = 300;
            c3q3.BackColor = Color.DimGray;
        }

        private void c3q4_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "This game released in 1980 had the first easter egg.";
            correctanswer = "The correct answer is \"What is Adventure? \"";
            answer = "What is Adventure?";
            score = 400;
            c3q4.BackColor = Color.DimGray;
        }

        private void c3q5_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "This horror survival video game series starts in Raccoon city where characters fight off zombies and mutants.";
            correctanswer = "The correct answer is \"What is Resident Evil? \"";
            answer = "What is Resident Evil?";
            score = 500;
            c3q5.BackColor = Color.DimGray;
        }
        #endregion
        #region category 4
            private void c4q1_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The capital of this country is home to the Eiffle Tower";
            correctanswer = "The correct answer is \"What is France?\"";
            answer = "What is France?";
            score = 100;
            c4q1.BackColor = Color.DimGray;
        }

        private void c4q2_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The Amstel flows under some 1300 bridges & viaducts in this capital.";
            correctanswer = "The correct answer is \"What is Amsterdam?\"";
            answer = "What is Amsterdam?";
            score = 200;
            c4q2.BackColor = Color.DimGray;
        }

        private void c4q3_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "he Andes rise east of this 4-letter coastal capital";
            correctanswer = "The correct answer is \"What is Peru?\"";
            answer = "What is Peru?";
            score = 300;
            c4q3.BackColor = Color.DimGray;
        }

        private void c4q4_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The 2 main roads in this city are King Fahd Highway running north-south & Mecca Highway running east-west";
            correctanswer = "The correct answer is \"What is Riyadh?\"";
            answer = "What is Riyadh?";
            score = 400;
            c4q4.BackColor = Color.DimGray;
        }

        private void c4q5_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "Come to Teotihuacan near this capital & see the Pyramid of the Sun";
            correctanswer = "The correct answer is \"What is Mexico City?\"";
            answer = "What is Mexico City?";
            score = 500;
            c4q5.BackColor = Color.DimGray;
        }
        #endregion
        #region category 5
        private void c5q1_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "This American football team is based in Green Bay, Wisconsin.";
            correctanswer = "The correct answer is \"Who are the Packers?\"";
            answer = "Who are the Packers?";
            score = 100;
            c5q1.BackColor = Color.DimGray;
        }

        private void c5q2_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "The nickname CR7 is what soccer players nickname?";
            correctanswer = "The correct answer is \"Who is Ronaldo?\"";
            answer = "Who is Ronaldo?";
            score = 200;
            c5q2.BackColor = Color.DimGray;
        }

        private void c5q3_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "Which American football player has the most Superbowl rings as of 2024?";
            correctanswer = "The correct answer is \"Who is Tom Brady?\"";
            answer = "Who is Tom Brady?";
            score = 300;
            c5q3.BackColor = Color.DimGray;
        }

        private void c5q4_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "South Africa beat New Zealead to win the 2023 World Cup in this sport.";
            correctanswer = "The correct answer is \"What is Rugby?\"";
            answer = "What is Rugby?";
            score = 400;
            c5q4.BackColor = Color.DimGray;
        }

        private void c5q5_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "This player was the MVP during the 2022 Basketball season.";
            correctanswer = "The correct answer is \"Who is Nikola Jokic?\"";
            answer = "Who is Nikola Jokic?";
            score = 500;
            c5q5.BackColor = Color.DimGray;
        }
        #endregion
        #region category 6
        private void c6q1_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "This painting is considered the most famous in the world.";
            correctanswer = "The correct answer is \"What is the Mona Lisa?\"";
            answer = "What is the Mona Lisa?";
            score = 100;
            c6q1.BackColor = Color.DimGray;
        }

        private void c6q2_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "Van Gogh painted this and it depicts a town at night.";
            correctanswer = "The correct answer is \"What is Starry Night?\"";
            answer = "What is Starry Night?";
            score = 200;
            c6q2.BackColor = Color.DimGray;
        }

        private void c6q3_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "Grant Wood painted this famous American paiting in 1930.";
            correctanswer = "The correct answer is \"What is American Gothic?\"";
            answer = "What is American Gothic?";
            score = 300;
            c6q3.BackColor = Color.DimGray;
        }

        private void c6q4_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "This artist painted \"The Night Watch \"+";
            correctanswer = "The correct answer is \"Who is Rembrant van Rijn?\"";
            answer = "Who is Rembrant van Rijn?";
            score = 400;
            c6q4.BackColor = Color.DimGray;
        }

        private void c6q5_Click(object sender, EventArgs e)
        {
            questionDisplay.Text = "This museum houses paintings such as the Mona Lisa.";
            correctanswer = "The correct answer is \"What is the Louvre?\"";
            answer = "What is the Louvre?";
            score = 500;
            c6q5.BackColor = Color.DimGray;
        }

        #endregion 
        #region answer checking and score count
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
