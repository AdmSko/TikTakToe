using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TikTakToe
{
    public partial class Form2 : Form
    {

        int[] check = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Players p1 = new Players();
        Players p2 = new Players();
        int turn = 1;
        public Form2(String name1, String name2)
        {
            p1.name = name1;
            p2.name = name2;
            Console.WriteLine(name1);
            InitializeComponent();
            currentPlayerName();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check[6] == 0)
            {
                if (turn % 2 == 1) button7.BackgroundImage = Properties.Resources.xicon;
                else button7.BackgroundImage = Properties.Resources.oicon;
                check[6] = 1;
                turn++;
                currentPlayerName();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check[7] == 0)
            {
                if (turn % 2 == 1) button8.BackgroundImage = Properties.Resources.xicon;
                else button8.BackgroundImage = Properties.Resources.oicon;
                check[7] = 1;
                turn++;
                currentPlayerName();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check[8] == 0)
            {
                if (turn % 2 == 1) button9.BackgroundImage = Properties.Resources.xicon;
                else button9.BackgroundImage = Properties.Resources.oicon;
                check[8] = 1;
                turn++;
                currentPlayerName();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check[3] == 0)
            {
                if (turn % 2 == 1) button4.BackgroundImage = Properties.Resources.xicon;
                else button4.BackgroundImage = Properties.Resources.oicon;
                check[3] = 1;
                turn++;
                currentPlayerName();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check[4] == 0)
            {
                if (turn % 2 == 1) button5.BackgroundImage = Properties.Resources.xicon;
                else button5.BackgroundImage = Properties.Resources.oicon;
                check[4] = 1;
                turn++;
                currentPlayerName();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check[5] == 0)
            {
                if (turn % 2 == 1) button6.BackgroundImage = Properties.Resources.xicon;
                else button6.BackgroundImage = Properties.Resources.oicon;
                check[5] = 1;
                turn++;
                currentPlayerName();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check[0] == 0)
            {
                if (turn % 2 == 1) button1.BackgroundImage = Properties.Resources.xicon;
                else button1.BackgroundImage = Properties.Resources.oicon;
                check[0] = 1;
                turn++;
                currentPlayerName();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check[1] == 0)
            {
                if (turn % 2 == 1) button2.BackgroundImage = Properties.Resources.xicon;
                else button2.BackgroundImage = Properties.Resources.oicon;
                check[1] = 1;
                turn++;
                currentPlayerName();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check[2] == 0)
            {
                if (turn % 2 == 1) button3.BackgroundImage = Properties.Resources.xicon;
                else button3.BackgroundImage = Properties.Resources.oicon;
                check[2] = 1;
                turn++;
                currentPlayerName();
            }
        }
    }
}
