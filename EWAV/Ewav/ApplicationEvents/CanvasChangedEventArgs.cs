﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace EWAV.Client.Application
{


    public class CanvasChangedEventArgs : EventArgs
    {


        public double Width { get; set; }
        public double Height { get; set; }


        public CanvasChangedEventArgs(double Height, double Width)
        {

            this.Width = Width;
            this.Height = Height;





        }


    }
}