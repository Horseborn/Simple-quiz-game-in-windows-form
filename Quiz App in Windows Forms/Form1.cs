using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quiz_App_in_Windows_Forms.Properties;

namespace Quiz_App_in_Windows_Forms
{
    public partial class Form1 : Form
    {

        // Declaring quiz game variables.
        private int correctAnswer;
        private int questionNumber = 1;
        private int score;
        private int percentage;
        private int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 8;

            if (questionNumber == 8)
            {
                this.Close();
            }
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                //percentage

                percentage = (int) Math.Round((double) (score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz done!" + "\n" + 
                    "You have answered " + score + " out of 8 questions correctly." + "\n" +
                    "Your total percentage is " + percentage + "%" + "\n" +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
                
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qNum)
        {
            switch (qNum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Sly;
                    
                    lblQuestion.Text = "What is the name of this popular Sony character?";

                    button1.Text = "Nathan Drake";
                    button2.Text = "Sly Cooper";
                    button3.Text = "Spyro";
                    button4.Text = "Solid Snake";

                    correctAnswer = 2;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.moba;

                    lblQuestion.Text = "What genre are these games?";

                    button1.Text = "MMORPG";
                    button2.Text = "FPS";
                    button3.Text = "RPG";
                    button4.Text = "MOBA";

                    correctAnswer = 4;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.isaac;

                    lblQuestion.Text = "What is the name of this popular indie game?";

                    button1.Text = "Kerbal Space Program";
                    button2.Text = "Hotline Miami";
                    button3.Text = "The Binding of Isaac: Rebirth";
                    button4.Text = "Papers, Please";

                    correctAnswer = 3;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.edmund;

                    lblQuestion.Text = "What is the name of this indie developer?";

                    button1.Text = "Toby Fox";
                    button2.Text = "Scott Cawthon";
                    button3.Text = "Edmund McMillen";
                    button4.Text = "Florian Himsl";

                    correctAnswer = 3;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.skyrim;

                    lblQuestion.Text = "In the game 'Skyrim', you find out you are a what?";

                    button1.Text = "A Royal";
                    button2.Text = "The last dragonborn";
                    button3.Text = "A descendant of Djengis Khan";
                    button4.Text = "A baker";

                    correctAnswer = 2;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.newvegas;

                    lblQuestion.Text = "Fallout New Vegas is developed by what company?";

                    button1.Text = "Obsidian Entertainment";
                    button2.Text = "Electronic Arts";
                    button3.Text = "Bethesda Softworks";
                    button4.Text = "Capcom";

                    correctAnswer = 1;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.ezio;

                    lblQuestion.Text = "What is the name of this video game character?";

                    button1.Text = "Altaïr Ibn-La'Ahad";
                    button2.Text = "Ezio Auditore da Firenze";
                    button3.Text = "Connor Kenway";
                    button4.Text = "Desmond Miles";

                    correctAnswer = 2;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.kratos;

                    lblQuestion.Text = "Which mythology does Kratos visit in the 2018 game 'God of War'?";

                    button1.Text = "Greek mythology";
                    button2.Text = "Japanese mythology";
                    button3.Text = "Roman mythology";
                    button4.Text = "Norse mythology";

                    correctAnswer = 4;
                    break;


            }

        }
    }
}
