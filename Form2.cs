using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TikTakToe
{
    public partial class Form2 : Form
    {
        List<string> sclist = new List<string>();
        int[] scores = { 0, 0 };
        int[] check = { 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // 0null, 1x, 2o
        Players p1 = new Players();
        Players p2 = new Players();
        int turn = 1;
        List<Button> buttons = new List<Button>();
        public Form2(String name1, String name2)
        {
            p1.name = name1;
            p2.name = name2;
            Console.WriteLine(name1);
            InitializeComponent();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            currentPlayerName();


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        public void move(int btnNumber)
        {
            if (check[btnNumber] == 0)
            {
                if (turn % 2 == 1)
                {
                    buttons[btnNumber].BackgroundImage = Properties.Resources.xicon;
                    check[btnNumber] = 1;
                }

                else
                {
                    buttons[btnNumber].BackgroundImage = Properties.Resources.oicon;
                    check[btnNumber] = 2;
                }

                turn++;
                currentPlayerName();
            }
            winCheck(turn % 2 + 1);
        }
        public void winCheck(int wn)
        {
            int j = 0, k = 4;
            for (int i = 0; i < 8; i += 3)
            {
                if ((check[i] == wn && check[i + 1] == wn && check[i + 2] == wn) || (check[j] == wn && check[j + 3] == wn && check[j + 6] == wn) || (check[k - 4] == wn && check[k] == wn && check[k + 4] == wn) || (check[k - 2] == wn && check[k] == wn && check[k + 2] == wn))
                {
                    if (wn == 1)
                    {
                        p1.score += 1;
                        scores[0] += 1;
                    }
                    else
                    {
                        p2.score += 1;
                        scores[1] += 1;
                    }
                    turn = 1;
                    foreach (Button button in buttons)
                    {
                        button.BackgroundImage = null;
                        Array.Clear(check, 0, check.Length);

                    }
                
                    sclist.Add(Convert.ToString(scores[0]) + "  -  " + Convert.ToString(scores[1]));
                    richTextBox1.Text = "";
                    if (scores[0] == 10 || scores[1] == 10)
                    {
                        if (scores[0] == 10) label6.Text = p1.name + "\nis a winner!";
                        else label6.Text = p2.name + "\nis a winner!";
                        label6.Visible = true;
                        Array.Clear(scores, 0, scores.Length);
                        sclist.Clear();
                        turn = 1;
                    }
                    else
                    {
                        if (label6.Visible == true) label6.Visible = false;
                        sclist.Reverse();
                        foreach (String sclis in sclist)
                        {
                            richTextBox1.Text += sclis + "\n";
                        }
                        sclist.Reverse();
                    }
                    turn = 1;
                }
                else if(turn == 10)
                {
                    foreach (Button button in buttons)
                    {
                        button.BackgroundImage = null;
                        Array.Clear(check, 0, check.Length);

                    }
                    turn = 1;
                }
                j++;
            }
        }
        public void currentPlayerName()
        {
            if (turn % 2 == 1)
            {
                label2.Text = "Turn: " + p1.name;
                label3.Text = "Turn: " + turn;
            }
            else
            {
                label2.Text = "Turn: " + p2.name;
                label3.Text = "Turn: " + turn;
            }
            label4.Text = p1.name;
            label5.Text = p2.name;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            move(6);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            move(7);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            move(8);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            move(3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            move(4);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            move(5);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            move(0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            move(1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            move(2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
