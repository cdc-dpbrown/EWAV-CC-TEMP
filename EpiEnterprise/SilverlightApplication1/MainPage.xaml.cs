﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

     

                            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {



            SilverlightApplication1.Web.DomainService1 ds1 = new Web.DomainService1();

            ds1.Test1();    





        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {


            SilverlightApplication1.Web.DomainService1 ds1 = new Web.DomainService1();

            ds1.Test2();    





        }

    
    }
}
