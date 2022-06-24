﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3K_Library
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Profile profil = new Form_Profile();
            profil.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Rak rak = new Form_Rak();
            rak.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Book book = new Form_Book();
            book.Show();
            this.Close();
        }
    }
}
