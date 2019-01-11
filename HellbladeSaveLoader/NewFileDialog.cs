using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HellbladeSaveLoader
{
    public partial class NewFileDialog : Form
    {

        public SavegameFile SavegameFile { get; set; }

        private string _description;
        private string _thumbnail;
        private string _file;

        private ConfigManager _config;

        public NewFileDialog()
        {
            InitializeComponent();

            _config = ConfigManager.GetInstance();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = @"Image files(*.jpg,*.jpeg,*.jpe,*.jfif,*.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            openFileDialog.ShowDialog();

            string file = openFileDialog.FileName;

            if (File.Exists(file))
            {
                _thumbnail = file;
                pbxThumbnail.ImageLocation = _thumbnail;
                lblThumbnailDirectory.Text = _thumbnail;
                lblThumbnailDirectory.Visible = true;
            }
            else
            {
                MessageBox.Show("Couldn't find file " + file, "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Hellblade Savegame File|*.sav";
            openFileDialog.FileName = "HellbladeSave_0";
            openFileDialog.InitialDirectory = _config.SaveFilesFolder;

            openFileDialog.ShowDialog();

            string file = openFileDialog.FileName;

            if (File.Exists(file))
            {
                _file = file;
                lblSavegameDirectory.Text = _file;
                lblSavegameDirectory.Visible = true;
            }
            else
            {
                MessageBox.Show("Couldn't find file " + file, "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _description = txtDescription.Text;

            if (String.IsNullOrEmpty(_description))
            {
                MessageBox.Show("Enter a description/name for this savegame file.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(_file))
            {
                MessageBox.Show("You must select a savegame file to add.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SavegameFile = new SavegameFile(_description, _file, _thumbnail);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
