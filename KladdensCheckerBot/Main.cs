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
        private int Xx;
        private int Yy;
        private int Zz;



        public Main()
        {
            InitializeComponent();
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
                    Xx = Client.ReadInt(0x0061E9C8);
                    Yy = Client.ReadInt(0x0061E9C4);
                    Zz = Client.ReadInt(0x0061E9C0);



                    hp.Text = "Loading...";
                    mana.Text = "Loading...";
                    level.Text = "Loading...";
                    ml.Text = "Loading...";
                    X.Text = "Calculating...";
                    Y.Text = "Calculating...";
                    Z.Text = "Calculating...";




                }
            }
        }

        private void timer1_Tick (object sender, EventArgs e)
        {

            hp.Text = Health.ToString();

            Health = Client.ReadInt(0x00613B6C);
            hp.Text = Health.ToString();
        
                X.Text = Xx.ToString();

                Xx = Client.ReadInt(0x0061E9C8);
                X.Text = Xx.ToString();
             
                    Y.Text = Yy.ToString();

                    Yy = Client.ReadInt(0x0061E9C4);
                    Y.Text = Yy.ToString();
                   
                        Z.Text = Zz.ToString();

                        Zz = Client.ReadInt(0x0061E9C0);
                        Z.Text = Zz.ToString();
                       


                            mana.Text = ManaP.ToString();

                            ManaP = Client.ReadInt(0x00613B50);
                            mana.Text = ManaP.ToString();

                       
                        level.Text = LP.ToString();

                        LP = Client.ReadInt(0x00613B58);
                        level.Text = LP.ToString();
                       


                            ml.Text = MLP.ToString();

                            MLP = Client.ReadInt(0x00613B54);
                            ml.Text = MLP.ToString();
                    }
                }
            
        
    








