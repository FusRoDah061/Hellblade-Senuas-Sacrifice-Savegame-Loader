using Newtonsoft.Json.Linq;
using SharpConfig;
using System;
using System.Collections.Generic;

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

        public List<SavegameFile> SavegameFiles
        {
            get
            {
                return _getSavegamesList();
            }
            set
            {
                _cfg["SavegameFiles"] = value;
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

        private List<SavegameFile> _getSavegamesList()
        {
            object list = _getItem("SavegameFiles");

            if (list.GetType() == typeof(JArray))
            {
                JArray collection = (JArray)list;
                return collection.ToObject<List<SavegameFile>>();
            }
            else
            {
                return (List<SavegameFile>)list;
            }
        }

    }
}
