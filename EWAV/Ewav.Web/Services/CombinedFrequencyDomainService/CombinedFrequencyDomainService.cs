﻿namespace CDC.ISB.EIDEV.Web.Services.CombinedFrequencyDomainService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using EpiDashboard;
    using System.Data;


    // TODO: Create methods containing your application logic.
    [EnableClientAccess()]
    public class CombinedFrequencyDomainService : DomainService
    {
        [Query(IsComposable = false)]
        public EWAVRule_Base Getrule(int id)
        {
            return new EWAVRule_Base();

        }

        /// <summary>
        /// DashboardHelper    
        /// </summary>
        private DashboardHelper dh;

        [Invoke]
        public DatatableBag GenerateCombinedFrequency(EWAVCombinedFrequencyGadgetParameters combinedParameters, string groupVar, GadgetParameters gadgetParameters,
               IEnumerable<EWAVDataFilterCondition> ewavDataFilters, List<EWAVRule_Base> rules, string filterString = "")
        {
            if (gadgetParameters.UseAdvancedDataFilter)
            {
                dh = new DashboardHelper(gadgetParameters, filterString, rules);
                gadgetParameters.UseAdvancedDataFilter = true;
                gadgetParameters.AdvancedDataFilterText = filterString;
            }
            else
            {
                dh = new DashboardHelper(gadgetParameters, ewavDataFilters, rules);
            }

            //DataTable dt = dh.GenerateCombinedBooleanFrequencyTable(groupVar, sortHighToLow, gadgetParameters, rules);
            bool booleanResults = false;
            int fields = -1;
            int denominator = -1;
            DataTable dt = dh.GenerateCombinedFrequencyTable(combinedParameters, groupVar, ref booleanResults, ref fields, ref denominator, gadgetParameters, rules);

            if (dt != null)
            {
                DatatableBag dtBag = new DatatableBag(dt, "");

                List<DictionaryDTO> DictionaryObject = new List<DictionaryDTO>();

                DictionaryObject.Add(new DictionaryDTO() { Key = new MyString("booleanResults"), Value = new MyString(booleanResults.ToString()) });
                DictionaryObject.Add(new DictionaryDTO() { Key = new MyString("fields"), Value = new MyString(fields.ToString()) });
                DictionaryObject.Add(new DictionaryDTO() { Key = new MyString("denominator"), Value = new MyString(denominator.ToString()) });
                dtBag.ExtraInfo = DictionaryObject;

                return dtBag;
            }
            else
            {
                throw new Exception("No Records found.");
            }

        }
    }
}