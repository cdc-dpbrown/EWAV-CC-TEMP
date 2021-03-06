﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDC.ISB.EIDEV.Web.Services
{
    /// <summary>
    /// Class created to mimic LogisticRegressionResults in EpiInfo. It was a struct in EpiInfo.
    /// </summary>
    public class LogRegressionResults
    {
        private int casesIncluded;

        public int CasesIncluded
        {
            get { return casesIncluded; }
            set { casesIncluded = value; }
        }
        private string convergence;

        public string Convergence
        {
            get { return convergence; }
            set { convergence = value; }
        }
        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }
        private double finalLikelihood;

        public double FinalLikelihood
        {
            get { return finalLikelihood; }
            set { finalLikelihood = value; }
        }
        private int iterations;

        public int Iterations
        {
            get { return iterations; }
            set { iterations = value; }
        }
        private double lRDF;

        public double LRDF
        {
            get { return lRDF; }
            set { lRDF = value; }
        }
        private double lRP;

        public double LRP
        {
            get { return lRP; }
            set { lRP = value; }
        }
        private double lRStatistic;

        public double LRStatistic
        {
            get { return lRStatistic; }
            set { lRStatistic = value; }
        }
        private double scoreDF;

        public double ScoreDF
        {
            get { return scoreDF; }
            set { scoreDF = value; }
        }
        private double scoreP;

        public double ScoreP
        {
            get { return scoreP; }
            set { scoreP = value; }
        }
        private double scoreStatistic;

        public double ScoreStatistic
        {
            get { return scoreStatistic; }
            set { scoreStatistic = value; }
        }
        private List<VariableRow> variables;

        public List<VariableRow> Variables
        {
            get { return variables; }
            set { variables = value; }
        }
    }
}