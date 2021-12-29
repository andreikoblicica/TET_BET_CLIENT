using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TET_BET
{
    public class AppSettingsFetcher
    {
        private static string GetAppSettingsJSONFile()
        {
            return File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
        }

        public static string GetConnectionString()
        {
            var myJObject = JObject.Parse(GetAppSettingsJSONFile());

            return myJObject.SelectToken("ConnectionStrings").SelectToken("DefaultConnectionString").ToString();
        }
    }
}