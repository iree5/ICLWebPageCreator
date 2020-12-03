﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ICLWebPageCreator
{
    /// <summary>
    /// Logique d'interaction pour Fenetre_intitule_du_menu.xaml
    /// </summary>
    public partial class Fenetre_intitule_du_menu : Window
    {
        public static string str_intitulé;
        public static string str_lien;
        public Fenetre_intitule_du_menu()
        {
            InitializeComponent();
            str_intitulé = "";
            str_lien = "";
        }

        private void bouton_ok_Click(object sender, RoutedEventArgs e)
        {
            if (intitulé.Text != "")
            {
                str_intitulé = intitulé.Text;
                str_lien = lien.Text;
                Close();
            }
        }

    }
}
