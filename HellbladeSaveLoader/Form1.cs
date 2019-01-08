using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HellbladeSaveLoader
{
    public partial class Form1 : Form
    {

        private ConfigManager _config;

        public Form1()
        {
            InitializeComponent();

            _config = ConfigManager.GetInstance();

            _fillSavegameFiles();
        }
        
        private void btnBackup_Click(object sender, EventArgs e)
        {
            _backupSaveFile();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filepath = cbxSavefiles.SelectedValue.ToString();
            DialogResult result = MessageBox.Show("Do you want to create a backup of the current savegame file?", "Create backup?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                _backupSaveFile();
                _loadFile(filepath);
            }
            else if (result == DialogResult.No)
            {
                _loadFile(filepath);
            }
        }

        private void btnChangeFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = _config.SaveFilesFolder;

            folderBrowserDialog.ShowDialog(this);

            if (!String.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                _config.SaveFilesFolder = folderBrowserDialog.SelectedPath;
        }

        private void _backupSaveFile()
        {
            FileInfo file = _getDefaultFile();

            string newFileName = DateTime.Now.ToString("yyyy-M-dd-HHmmss") + "_" + file.Name;

            file.CopyTo(file.DirectoryName + "\\" + newFileName);

            MessageBox.Show("Backup completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private FileInfo _getDefaultFile()
        {
            string fullPath = _config.SaveFilesFolder + _config.DefaultSaveFileName + ".sav";

            return _getFile(fullPath);
        }

        private FileInfo _getFile(string path)
        {
            string pathTmp = path;

            if (!File.Exists(pathTmp))
            {
                MessageBox.Show("Default savegame file not found. Please, select the file directory manually.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                openFileDialog.ShowDialog(this);

                pathTmp = openFileDialog.FileName;
            }

            return new FileInfo(pathTmp);
        }

        private void _fillSavegameFiles()
        {
            List<SavegameFile> files = _getPresetFiles();

            if (_config.SavegameFiles != null)
                files.AddRange(_config.SavegameFiles);

            cbxSavefiles.DataSource = files;
            cbxSavefiles.DisplayMember = "FriendlyName";
            cbxSavefiles.ValueMember = "FileName";
        }

        private List<SavegameFile> _getPresetFiles()
        {
            List<SavegameFile> files = new List<SavegameFile>();

            files.Add(new SavegameFile("Surt Boss Fight", @"Resources\surt_boss_fight.sav"));
            files.Add(new SavegameFile("Valravn Boss Fight", @"Resources\valravn_boss_fight.sav"));
            files.Add(new SavegameFile("Bridge Fight", @"Resources\bridge_fight.sav"));
            files.Add(new SavegameFile("Trials", @"Resources\trials.sav"));
            files.Add(new SavegameFile("Labyrinth Trial", @"Resources\labyrinth_trial.sav"));
            files.Add(new SavegameFile("Fenrir Boss Fight", @"Resources\fenrir_boss_fight.sav"));
            files.Add(new SavegameFile("Hela Boss Fight", @"Resources\hela_boss_fight.sav"));
            
            return files;
        }

        private void _loadFile(string filepath)
        {
            FileInfo newFile = new FileInfo(filepath);

            newFile.CopyTo(_config.SaveFilesFolder + _config.DefaultSaveFileName + ".sav", true);

            MessageBox.Show("Savegame file loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
    }
}
