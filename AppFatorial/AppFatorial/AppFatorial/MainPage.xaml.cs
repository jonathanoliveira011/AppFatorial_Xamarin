﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppFatorial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcula (object sender, EventArgs e)
        {
            // 3 = 3 * 2 * 1
            int n = Convert.ToInt32(eNumero.Text);
            int total = n;
            for (int i = n - 1; i > 0; i--)
            {

                total = total * i;

            }
            lblResposta.Text = ("O fatorial do número "+ n.ToString() + " é "+ total.ToString() + ".");

        }

    }
}
