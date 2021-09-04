using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XandO
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string x = "Ahmed";
        string o = "Rami";
        string turn;
        string topRight, top, topLeft, right, middle, left, bottomRight, bottom, bottomLeft;
        public Form1()
        {
            InitializeComponent();
            int player = rnd.Next(1,3);
            if (player == 1)
            {
                turn = "ahmed";
            }
            else
            {
                turn = "rami";
            }
            GUI();
        }
        private void RandomFirstPlayer()
        {
            int player = rnd.Next(1, 3);
            if (player == 1)
            {
                turn = "ahmed";
            }
            else
            {
                turn = "rami";
            }
        }

        private void GUI()
        {
            if (turn == "ahmed")
            {
                lbl_arrow.Text = "f";
                lbl_rami.ForeColor = Control.DefaultForeColor;
                lbl_ahmed.ForeColor = Color.Green;
            }
            else if(turn == "rami")
            {
                lbl_arrow.Text = "g";
                lbl_rami.ForeColor = Color.Green;
                lbl_ahmed.ForeColor = Control.DefaultForeColor;
            }
        }
        private void lbl_topRight_Click(object sender, EventArgs e)
        {
            if (topRight != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_topRight.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_topRight.Text = "O";
                    turn = "ahmed";
                }
            }
            topRight = "checked";
            WhoWon();
            GUI();
        }

        private void WhoWon()
        {

            /*
                    x win
                     |        |
                 ___________________   
                     |        |
                 ___________________   
                     |        |
             
             */
            if(lbl_topRight.Text == "X" && lbl_top.Text == "X" && lbl_topLeft.Text == "X")
            {
                pic_topx.Visible = true;
                MessageBox.Show($"على الفوز {x} مبروك!");
                Clear();
            }
            else if(lbl_middleRight.Text == "X" && lbl_middle.Text == "X" && lbl_middleLeft.Text == "X")
            {
                pic_middlex.Visible = true;
                MessageBox.Show($"على الفوز {x} مبروك!");
                Clear();
            }
            else if (lbl_bottomRight.Text == "X" && lbl_bottom.Text == "X" && lbl_bottomLeft.Text == "X")
            {
                pic_bottomx.Visible = true;
                MessageBox.Show($"على الفوز {x} مبروك!");
                Clear();
            }
            else if (lbl_topLeft.Text == "X" && lbl_middleLeft.Text == "X" && lbl_bottomLeft.Text == "X")
            {
                pic_lefty.Visible = true;
                MessageBox.Show($"على الفوز {x} مبروك!");
                Clear();
            }
            else if (lbl_top.Text == "X" && lbl_middle.Text == "X" && lbl_bottom.Text == "X")
            {
                pic_middley.Visible = true;
                MessageBox.Show($"على الفوز {x} مبروك!");
                Clear();
            }
            else if (lbl_topRight.Text == "X" && lbl_middleRight.Text == "X" && lbl_bottomRight.Text == "X")
            {
                pic_righty.Visible = true;
                MessageBox.Show($"على الفوز {x} مبروك!");
                Clear();
            }
            // cross win
            else if (lbl_topRight.Text == "X" && lbl_middle.Text == "X" && lbl_bottomLeft.Text == "X")
            {
                MessageBox.Show($"على الفوز {x} مبروك!");
                Clear();
            }
            else if (lbl_topLeft.Text == "X" && lbl_middle.Text == "X" && lbl_bottomRight.Text == "X")
            {
                MessageBox.Show($"على الفوز {x} مبروك!");
                Clear();
            }


            /*
                    x win
                     |        |
                 ___________________   
                     |        |
                 ___________________   
                     |        |

             */
            else if (lbl_topRight.Text == "O" && lbl_top.Text == "O" && lbl_topLeft.Text == "O")
            {
                pic_topx.Visible = true;
                MessageBox.Show($"على الفوز {o} مبروك!");
                Clear();
            }
            else if (lbl_middleRight.Text == "O" && lbl_middle.Text == "O" && lbl_middleLeft.Text == "O")
            {
                pic_middlex.Visible = true;
                MessageBox.Show($"على الفوز {o} مبروك!");
                Clear();
            }
            else if (lbl_bottomRight.Text == "O" && lbl_bottom.Text == "O" && lbl_bottomLeft.Text == "O")
            {
                pic_bottomx.Visible = true;
                MessageBox.Show($"على الفوز {o} مبروك!");
                Clear();
            }
            else if (lbl_topLeft.Text == "O" && lbl_middleLeft.Text == "O" && lbl_bottomLeft.Text == "O")
            {
                pic_lefty.Visible = true;
                MessageBox.Show($"على الفوز {o} مبروك!");
                Clear();
            }
            else if (lbl_top.Text == "O" && lbl_middle.Text == "O" && lbl_bottom.Text == "O")
            {
                pic_middley.Visible = true;
                MessageBox.Show($"على الفوز {o} مبروك!");
                Clear();
            }
            else if (lbl_topRight.Text == "O" && lbl_middleRight.Text == "O" && lbl_bottomRight.Text == "O")
            {
                pic_righty.Visible = true;
                MessageBox.Show($"على الفوز {o} مبروك!");
                Clear();
            }
            // cross win
            else if (lbl_topRight.Text == "O" && lbl_middle.Text == "O" && lbl_bottomLeft.Text == "O")
            {
                MessageBox.Show($"على الفوز {o} مبروك!");
                Clear();
            }
            else if (lbl_topLeft.Text == "O" && lbl_middle.Text == "O" && lbl_bottomRight.Text == "O")
            {
                MessageBox.Show($"على الفوز {o} مبروك!");
                Clear();
            }
            


            if(lbl_topLeft.Text != "" && lbl_top.Text != "" && lbl_topRight.Text != "" && lbl_middleLeft.Text != "" && lbl_middle.Text != "" && lbl_middleRight.Text != "" && lbl_bottomLeft.Text != "" && lbl_bottom.Text != "" && lbl_bottomRight.Text != "")
            {
                MessageBox.Show("!تعادل");
                Clear();
            }
        }

        private void Clear()
        {
            lbl_topLeft.Text = "";
            lbl_top.Text = "";
            lbl_topRight.Text = "";
            lbl_middleLeft.Text = "";
            lbl_middle.Text = "";
            lbl_middleRight.Text = "";
            lbl_bottomLeft.Text = "";
            lbl_bottom.Text = "";
            lbl_bottomRight.Text = "";
            topRight = "";
            top = "";
            topLeft = "";
            right = "";
            middle = "";
            left = "";
            bottomRight = "";
            bottom = "";
            bottomLeft = "";
            lbl_arrow.Text = "-";
            lbl_rami.ForeColor = Control.DefaultForeColor;
            pic_lefty.Visible = false;
            pic_middley.Visible = false;
            pic_righty.Visible = false;
            pic_topx.Visible = false;
            pic_middlex.Visible = false;
            pic_bottomx.Visible = false;
            RandomFirstPlayer();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
            RandomFirstPlayer();
            GUI();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_top_Click(object sender, EventArgs e)
        {
            if (top != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_top.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_top.Text = "O";
                    turn = "ahmed";
                }
            }
            top = "checked";
            WhoWon();
            GUI();
        }

        private void lbl_topLeft_Click(object sender, EventArgs e)
        {
            if (topLeft != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_topLeft.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_topLeft.Text = "O";
                    turn = "ahmed";
                }
            }
            topLeft = "checked";
            WhoWon();
            GUI();
        }

        private void lbl_middleRight_Click(object sender, EventArgs e)
        {
            if (right != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_middleRight.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_middleRight.Text = "O";
                    turn = "ahmed";
                }
            }
            right = "checked";
            WhoWon();
            GUI();
        }

        private void lbl_middle_Click(object sender, EventArgs e)
        {
            if (middle != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_middle.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_middle.Text = "O";
                    turn = "ahmed";
                }
            }
            middle = "checked";
            WhoWon();
            GUI();
        }

        private void lbl_middleLeft_Click(object sender, EventArgs e)
        {
            if (left != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_middleLeft.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_middleLeft.Text = "O";
                    turn = "ahmed";
                }
            }
            left = "checked";
            WhoWon();
            GUI();
        }

        private void lbl_bottomRight_Click(object sender, EventArgs e)
        {
            if (bottomRight != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_bottomRight.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_bottomRight.Text = "O";
                    turn = "ahmed";
                }
            }
            bottomRight = "checked";
            WhoWon();
            GUI();
        }

        private void lbl_bottom_Click(object sender, EventArgs e)
        {
            if (bottom != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_bottom.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_bottom.Text = "O";
                    turn = "ahmed";
                }
            }
            bottom = "checked";
            WhoWon();
            GUI();
        }

        private void lbl_bottomLeft_Click(object sender, EventArgs e)
        {
            if (bottomLeft != "checked")
            {
                if (turn == "ahmed")
                {
                    lbl_bottomLeft.Text = "X";
                    turn = "rami";
                }
                else
                {
                    lbl_bottomLeft.Text = "O";
                    turn = "ahmed";
                }
            }
            bottomLeft = "checked";
            WhoWon();
            GUI();
        }
    }
}
