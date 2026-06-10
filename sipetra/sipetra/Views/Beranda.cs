using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sipetra.Models;



namespace sipetra.Views
{
    public partial class Beranda : Form
    {
        private string username;

        public Beranda(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Beranda_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Selamat Datang, " + username;
        }
    }
}