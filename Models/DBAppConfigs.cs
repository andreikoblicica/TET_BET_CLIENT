using System.ComponentModel.DataAnnotations;

namespace TET_BET.Models
{
    public class DBAppConfigs
    {
        [Key] public int appConfigID { get; set; }
        public string appConfigKey { get; set; }
        public string appConfigValue { get; set; }
        public string description { get; set; }
        public bool isEnabled { get; set; }
    }
}