namespace HellbladeSaveLoader
{
    class SavegameFile
    {

        public string FileName { get; set; }
        public string FriendlyName { get; set; }

        public SavegameFile(string friendlyName, string fileName)
        {
            FileName = fileName;
            FriendlyName = friendlyName;
        }
    }
}
