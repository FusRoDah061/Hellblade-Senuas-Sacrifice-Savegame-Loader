using SharpConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellbladeSaveLoader
{
    class ConfigManager
    {

        private const string CONFIG_NAMESPACE = "HellbladeSaveLoaderConfig";

        private static ConfigManager _instance = null;
        private Config _cfg;
        
        private ConfigManager()
        {
            _cfg = new Config(CONFIG_NAMESPACE, false, true);
        }

        public static ConfigManager GetInstance()
        {
            if (_instance == null)
                _instance = new ConfigManager();

            return _instance;
        }

        public string SaveFilesFolder
        {
            get
            {
                return _cfg["SaveFilesFolder"];
            }
            set
            {
                _cfg["SaveFilesFolder"] = value;
            }
        }
        
    }
}
