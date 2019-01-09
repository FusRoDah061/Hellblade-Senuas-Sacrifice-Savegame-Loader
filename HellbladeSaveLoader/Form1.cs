using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Topbar topbar = new Topbar(this);
            topbar.Dock = DockStyle.Top;
            topbar.Height = 30;
            topbar.Title = this.Text;

            this.SuspendLayout();
            this.Controls.Add(topbar);
            this.ResumeLayout(true);

            _config = ConfigManager.GetInstance();

            _fillSavegameFiles();
        }
        
        private void btnBackup_Click(object sender, EventArgs e)
        {
            _backupSaveFile();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filepath = ((SavegameFile) cbxSavefiles.SelectedValue).FileName;
            DialogResult result = MessageBox.Show("Do you want to create a backup of the current savegame file?", "Create backup?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            try
            {
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
            catch(FileNotFoundException)
            {
                MessageBox.Show("Couldn't find file " +  filepath, "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxSavefiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SavegameFile selected = (SavegameFile)cbxSavefiles.SelectedValue;

            if (File.Exists(selected.ThumbnailFileName))
                pbxThumbnail.ImageLocation = selected.ThumbnailFileName;
            else
                pbxThumbnail.Image = null;
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
            cbxSavefiles.ValueMember = null;
           
        }

        private List<SavegameFile> _getPresetFiles()
        {
            List<SavegameFile> files = new List<SavegameFile>();

            files.Add(new SavegameFile("Surt Boss Fight", @"Resources\save\surt_boss_fight.sav", @"Resources\thumb\surt_boss_fight_thumb.jpg"));
            files.Add(new SavegameFile("Valravn Boss Fight", @"Resources\save\valravn_boss_fight.sav", @"Resources\thumb\valravn_boss_fight_thumb.jpg"));
            files.Add(new SavegameFile("Bridge Fight", @"Resources\save\bridge_fight.sav", @"Resources\thumb\bridge_fight_thumb.jpg"));

            files.Add(new SavegameFile("Trials", @"Resources\save\trials.sav", @"Resources\thumb\trials_thumb.jpg"));
            files.Add(new SavegameFile("Labyrinth Trial", @"Resources\save\labyrinth_trial.sav", @"Resources\thumb\labyrinth_trial_thumb.jpg"));
            files.Add(new SavegameFile("Swamp Trial", @"Resources\save\swamp_trial.sav", @"Resources\thumb\swamp_trial_thumb.jpg"));
            files.Add(new SavegameFile("Tower Trial", @"Resources\save\tower_trial.sav", @"Resources\thumb\tower_trial_thumb.jpg"));
            files.Add(new SavegameFile("Darkness Trial", @"Resources\save\darkness_trial.sav", @"Resources\thumb\darkness_trial_thumb.jpg"));

            files.Add(new SavegameFile("Garmr Boss Fight", @"Resources\save\garmr_boss_fight.sav", @"Resources\thumb\garmr_boss_fight_thumb.jpg"));
            files.Add(new SavegameFile("Hela Boss Fight", @"Resources\save\hela_boss_fight.sav", @"Resources\thumb\hela_boss_fight_thumb.jpg"));
            
            return files;
        }

        private void _loadFile(string filepath)
        {
            FileInfo newFile = new FileInfo(filepath);

            newFile.CopyTo(_config.SaveFilesFolder + _config.DefaultSaveFileName + ".sav", true);

            MessageBox.Show("Savegame file loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(_config.SaveFilesFolder);
        }
    }
}
