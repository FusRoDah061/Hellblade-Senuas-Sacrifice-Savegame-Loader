using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            _backupSaveFile();
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
    }
}
