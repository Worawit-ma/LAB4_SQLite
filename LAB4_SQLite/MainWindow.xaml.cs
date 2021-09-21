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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB4_SQLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
         
        }

        private void Buttonshow_Click(object sender, RoutedEventArgs e)
        {
            string data_out = "";
            foreach (string data in DataAccess.GetData())
            {
                data_out = data_out + " " + data.ToString() + "\n";
            }
            MessageBox.Show(data_out);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //add
            //winTextInput
            DataAccess.AddData(winTextInput.Text);
            winTextInput.Clear();
        }
    }
}
