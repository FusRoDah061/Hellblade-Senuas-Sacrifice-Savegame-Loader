namespace HellbladeSaveLoader
{
    class SavegameFile
    {

        public string FileName { get; set; }
        public string FriendlyName { get; set; }
        public string ThumbnailFileName { get; set; }

        public SavegameFile(string friendlyName, string fileName, string thumbFile)
        {
            FileName = fileName;
            FriendlyName = friendlyName;
            ThumbnailFileName = thumbFile;
        }
    }
}
