﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Interface2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kruvazor kruvazor = new Kruvazor();
            Oyuncak_Al(kruvazor);

            Apachee apchee = new Apachee();
            Oyuncak_Al(apchee);
        }

        void Oyuncak_Al(IAtes_Eden oyuncak)
        {
            oyuncak.AtesEt();
        }
    }
}
