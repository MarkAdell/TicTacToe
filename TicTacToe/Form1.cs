using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        TextBox[,] Blocks; //A reference to an array of the TextBoxes holding "X" or "O".

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creating the array and initializing it.
                Blocks = new TextBox[3, 3]{
                {Block00 , Block01 , Block02},
                {Block10 , Block11 , Block12},
                {Block20 , Block21 , Block22}
            };

            X_Score.Font = new Font(Font.FontFamily, 15.0F); //X player score label.
            O_Score.Font = new Font(Font.FontFamily, 15.0F); //O player score label.

            Score_X.Font = new Font(Font.FontFamily, 15.0F); //X player score label that shows score.
            Score_O.Font = new Font(Font.FontFamily, 15.0F); //O player score label that shows score.

            foreach (TextBox block in Blocks) //looping the array.
            {
                block.Font = new Font("Comic Sans MS", 28.0F, FontStyle.Regular); //Editing font.
                block.TextAlign = HorizontalAlignment.Center; //Setting the allignment.
                block.CharacterCasing = CharacterCasing.Upper; //Setting font to UpperCase.
                block.MaxLength = 1;
            }

            //Unvisible label to make let it be the focused control instead of the textbox.
            this.ActiveControl = LabelToFocusOn;
        }

        string LastMove = null; //Helper string to handel wrong player turn.
        int score_o = 0, score_x = 0;

        //Event when a TextBox text is changed.
        private void Block_TextChanged(object sender, EventArgs e)
        {
            TextBox Block = (TextBox)sender; //The sender block (The event is set to all blocks).

            if (Block.Text == "") return;

            if (Block.Text.Length == 2)
            {
                char tmp = Block.Text[0];
                Block.Text = "";
                Block.Text += tmp;
                return;
            }

            //Handeling if the user typed characters other than X or O.
            if (Block.Text != "X" && Block.Text != "O")
            {
                PlaySound("to2to2to2.wav");
                MessageBox.Show("Only X And O Are Allowed!");
                Block.Text = "";
                return;
            }

            if (Block.Text.Equals(LastMove)) //Handeling wrong player turn.
            {
                PlaySound("to2to2to2.wav");
                if (LastMove.Equals("X"))
                    MessageBox.Show("O's Player Move");
                else
                    MessageBox.Show("X's Player Move");

                Block.Text = "";
                return;
            }

            if (Block.Text != "") //Setting LastMove to handel wrong player turn.
            {
                LastMove = Block.Text;
            }

            for (int i = 0; i < 3; i++) //Checking vertical blocks to see if someone wins.
            {
                if (Blocks[i, 0].Text != "")
                {
                    if (Blocks[i, 0].Text.Equals(Blocks[i, 1].Text) && Blocks[i, 1].Text.Equals(Blocks[i, 2].Text))
                    {
                        Paint_Red(Blocks[i, 0], Blocks[i, 1], Blocks[i, 2]);
                        Set_Score(Blocks[i, 0].Text);
                        Reset_Blocks();
                        break;
                    }
                }
            }

            for (int i = 0; i < 3; i++) //Checking horizontal blocks to see if someone wins.
            {
                if (Blocks[0, i].Text != "")
                {
                    if (Blocks[0, i].Text.Equals(Blocks[1, i].Text) && Blocks[1, i].Text.Equals(Blocks[2, i].Text))
                    {
                        Paint_Red(Blocks[0, i], Blocks[1, i], Blocks[2, i]);
                        Set_Score(Blocks[0, i].Text);
                        Reset_Blocks();
                        break;
                    }
                }
            }

            if (Blocks[1, 1].Text != "") //Checking at diagonals to see if someone wins.
            {
                if (Blocks[0, 0].Text.Equals(Blocks[1, 1].Text) && Blocks[1, 1].Text.Equals(Blocks[2, 2].Text))
                {
                    Paint_Red(Blocks[0, 0], Blocks[1, 1], Blocks[2, 2]);
                    Set_Score(Blocks[0, 0].Text);
                    Reset_Blocks();
                    return;
                }

                if (Blocks[0, 2].Text.Equals(Blocks[1, 1].Text) && Blocks[1, 1].Text.Equals(Blocks[2, 0].Text))
                {
                    Paint_Red(Blocks[0, 2], Blocks[1, 1], Blocks[2, 0]);
                    Set_Score(Blocks[0, 2].Text);
                    Reset_Blocks();
                    return;
                }
            }

            //Playing a sound when a player types X or O.
            if (Block.Text.Equals("X"))
                PlaySound("boing_spring.wav");
            else if (Block.Text.Equals("O"))
                PlaySound("boing_poing.wav");

            //Handeling draw.
            bool AllFilled = true;
            foreach (TextBox block in Blocks)
            {
                if (block.Text == "")
                {
                    AllFilled = false;
                    break;
                }
            }
            if (AllFilled == true)
            {
                PlaySound("blip.wav");
                MessageBox.Show("Draw!");
                Reset_Blocks();
            }

            Block.ReadOnly = true; //Making the user unable to delete once he played.
        }

        private void Set_Score(string WinningPlayer) //A method to set the scores and show the winning player.
        {
            PlaySound("blip.wav");
            if (WinningPlayer == "O")
            {
                MessageBox.Show("O Player Wins");
                score_o++;
                Score_O.Text = "";
                Score_O.Text = score_o.ToString();
            }
            else
            {
                MessageBox.Show("X Player Wins");
                score_x++;
                Score_X.Text = "";
                Score_X.Text = score_x.ToString();
            }
        }

        //A method to paint the given blocks red, called when a player wins.
        private void Paint_Red(TextBox block1, TextBox block2, TextBox block3)
        {
            block1.ReadOnly = false;
            block2.ReadOnly = false;
            block3.ReadOnly = false;
            block1.ForeColor = System.Drawing.Color.Red;
            block2.ForeColor = System.Drawing.Color.Red;
            block3.ForeColor = System.Drawing.Color.Red;
        }

        private void Reset_Blocks() //A method to reset everything , called when a player wins.
        {
            LastMove = null;

            foreach (TextBox block in Blocks)
            {
                block.ForeColor = System.Drawing.Color.Black;
                block.ReadOnly = false;
                block.Text = "";
            }

            //Unvisible label to make let it be the focused control instead of the textbox.
            this.ActiveControl = LabelToFocusOn;
        }
        private void PlaySound(string path) //A method to play .wav file at the sent path.
        {
            SoundPlayer simpleSound = new SoundPlayer(path);
            simpleSound.Play();
        }
    }
}