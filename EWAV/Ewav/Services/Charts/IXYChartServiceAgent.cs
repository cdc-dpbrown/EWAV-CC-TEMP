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
using EWAV.Web.EpiDashboard;
using EWAV.Web.Services;
using System.Collections.Generic;

namespace EWAV.Services
{
    public interface IXYChartServiceAgent
    {
        void GetFrequencyResults(GadgetParameters gadgetParameters, Action<List<FrequencyResultData>, Exception> completed);
    }
}