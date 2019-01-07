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

        private string SAVE_FILES_FOLDER_DEFAULT = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HellbladeGame\Saved\SaveGames\";
        private string DEFAULT_SAVE_FILE_NAME_DEFAULT = "HellbladeSave_0";

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
                string value = Convert.ToString(_getItem("SaveFilesFolder"));
                
                if (String.IsNullOrEmpty(value))
                    value = SAVE_FILES_FOLDER_DEFAULT;

                return value;
            }
            set
            {
                _cfg["SaveFilesFolder"] = value;
            }
        }

        public string DefaultSaveFileName
        {
            get
            {
                string value = Convert.ToString(_getItem("DefaultSaveFileName"));
                
                if (String.IsNullOrEmpty(value))
                    value = DEFAULT_SAVE_FILE_NAME_DEFAULT;

                return value;
            }
            set
            {
                _cfg["DefaultSaveFileName"] = value;
            }
        }

        private object _getItem(string key)
        {
            object value = null;

            try {
                value = _cfg[key];
            }
            catch { }

            return value;
        }

    }
}
