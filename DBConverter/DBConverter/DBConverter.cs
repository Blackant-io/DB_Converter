using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;

namespace DBConverter
{
    class DBConverter
    {
        public string MySQL_MSSQL(string strQuery)
        {
            Dictionary<string, NameValueCollection> allSettings = new Dictionary<string, NameValueCollection>();
            try
            {
                const string strLanguageElements = "LanguageElements";
                allSettings.Add(strLanguageElements, ConfigurationManager.GetSection("customAppSettingsGroup/LanguageElements") as NameValueCollection);
                allSettings.Add("Table", ConfigurationManager.GetSection("customAppSettingsGroup/Table") as NameValueCollection);
                allSettings.Add("BuiltInFunctions", ConfigurationManager.GetSection("customAppSettingsGroup/BuiltInFunctions") as NameValueCollection);
                allSettings.Add("DataType", ConfigurationManager.GetSection("customAppSettingsGroup/DataType") as NameValueCollection);
                allSettings.Add("Exclude", ConfigurationManager.GetSection("customAppSettingsGroup/Exclude") as NameValueCollection);
                string[] strexclude = allSettings["Exclude_MySQL"]["exclude"].Split(',');

                foreach (var strreplace in allSettings[strLanguageElements])
                {
                    strQuery = strQuery.Replace(strreplace.ToString(), allSettings[strLanguageElements][strreplace.ToString()]);
                }
                foreach (var strreplace in allSettings["Table"])
                {
                    strQuery = strQuery.Replace(strreplace.ToString(), allSettings["Table"][strreplace.ToString()]);
                }
                foreach (var strreplace in allSettings["BuiltInFunctions"])
                {
                    strQuery = strQuery.Replace(strreplace.ToString(), allSettings["BuiltInFunctions"][strreplace.ToString()]);
                }
                foreach (var strreplace in allSettings["DataType"])
                {
                    strQuery = strQuery.Replace(strreplace.ToString(), allSettings["DataType"][strreplace.ToString()]);
                }
               
                foreach(string remove in strexclude)
                {
                    strQuery = strQuery.Replace(remove, "");
                }
                return strQuery;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public string MSSQL_MySQL(string strQuery)
        {
            Dictionary<string, NameValueCollection> allSettings = new Dictionary<string, NameValueCollection>();
            try
            {
                allSettings.Add("LanguageElements", ConfigurationManager.GetSection("customAppSettingsGroup/LanguageElements") as NameValueCollection);
                allSettings.Add("Table", ConfigurationManager.GetSection("customAppSettingsGroup/Table") as NameValueCollection);
                allSettings.Add("BuiltInFunctions", ConfigurationManager.GetSection("customAppSettingsGroup/BuiltInFunctions") as NameValueCollection);
                allSettings.Add("DataType", ConfigurationManager.GetSection("customAppSettingsGroup/DataType") as NameValueCollection);
                allSettings.Add("Exclude", ConfigurationManager.GetSection("customAppSettingsGroup/Exclude") as NameValueCollection);
                string[] strexclude = allSettings["Exclude_MSSQL"]["exclude"].Split(',');

                foreach (var strreplace in allSettings["LanguageElements"])
                {
                    strQuery = strQuery.Replace(allSettings["LanguageElements"][strreplace.ToString()],strreplace.ToString());
                }
                foreach (var strreplace in allSettings["Table"])
                {
                    strQuery = strQuery.Replace(allSettings["Table"][strreplace.ToString()],strreplace.ToString());
                }
                foreach (var strreplace in allSettings["BuiltInFunctions"])
                {
                    strQuery = strQuery.Replace( allSettings["BuiltInFunctions"][strreplace.ToString()], strreplace.ToString());
                }
                foreach (var strreplace in allSettings["DataType"])
                {
                    strQuery = strQuery.Replace( allSettings["DataType"][strreplace.ToString()], strreplace.ToString());
                }

                foreach (string remove in strexclude)
                {
                    strQuery = strQuery.Replace(remove, "");
                }
                return strQuery;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
