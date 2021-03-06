﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EWAV.Views
{
    /// <summary>
    /// DTO for 2x2 grid cells         
    /// </summary>
    public class RenderGridCellsDTO
    {
        // dt.Columns.Add(new DataColumn("Exposure", typeof(string)));
        public  string Exposure;
             
        //  dt.Columns.Add(new DataColumn("Outcome Rate" + Environment.NewLine + "Exposure", typeof(string)));    
        public string OutcomeRate_Exposure;
        //  dt.Columns.Add(new DataColumn("Outcome Rate" + Environment.NewLine + "No Exposure", typeof(string)));     
        public string OutcomeRate_NoExposure;
        //  dt.Columns.Add(new DataColumn("Risk Ratio", typeof(string)));        
        public string RiskRatio;
        //  dt.Columns.Add(new DataColumn("Odds Ratio", typeof(string)));  
        public string OddsRatio;

        public RenderGridCellsDTO()
        {
        }
    }
}