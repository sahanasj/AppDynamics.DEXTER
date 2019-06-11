﻿using AppDynamics.Dexter.ReportObjects;
using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjectMaps
{
    public class LicenseRuleValueReportMap : ClassMap<LicenseValue>
    {
        public LicenseRuleValueReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.AccountName).Index(i); i++;

            Map(m => m.RuleName).Index(i); i++;
            Map(m => m.AgentType).Index(i); i++;

            Map(m => m.LicenseEventTime).Index(i); i++;
            Map(m => m.LicenseEventTimeUtc).Index(i); i++;

            Map(m => m.Average).Index(i); i++;

            Map(m => m.AccountID).Index(i); i++;
        }
    }
}
