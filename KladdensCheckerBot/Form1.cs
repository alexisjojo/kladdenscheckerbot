using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Försök_till_egen_Bot
{
    public partial class Main : Form
    {
        private Main frmMain;

        private int Health;
        private int ManaP;
        private int LP;
        private int MLP;




        public Main()
        {
            InitializeComponent();
        }

        private void mana_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] P = Process.GetProcessesByName("Tibia");
            if (P.Length == 0)
            {
                MessageBox.Show("Could'nt Find Tibia Client.");
            }
            else
            {
                Client.TibiaHwnd();

                Health = Client.ReadInt(0x00613B6C);
                ManaP = Client.ReadInt(0x00613B50);
                LP = Client.ReadInt(0x00613B58);
                MLP = Client.ReadInt(0x00613B54);


                hp.Text = "Loading...";
                mana.Text = "Loading...";
                level.Text = "Loading...";
                ml.Text = "Loading...";



            }
        }

        private string String(int p)
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hp.Text = Health.ToString();

            Health = Client.ReadInt(0x00613B6C);
            hp.Text = Health.ToString();
            {
                mana.Text = Health.ToString();

                ManaP = Client.ReadInt(0x00613B50);
                mana.Text = ManaP.ToString();

            }
            level.Text = LP.ToString();

            LP = Client.ReadInt(0x00613B58);
            level.Text = LP.ToString();





            
        }

        private void status_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
