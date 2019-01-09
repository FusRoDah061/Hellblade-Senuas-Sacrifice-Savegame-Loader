namespace HellbladeSaveLoader
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSavefiles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnChangeFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxThumbnail = new System.Windows.Forms.PictureBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(20, 313);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(399, 30);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup current savefile";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(344, 277);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 30);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a savegame file to load";
            // 
            // cbxSavefiles
            // 
            this.cbxSavefiles.FormattingEnabled = true;
            this.cbxSavefiles.Location = new System.Drawing.Point(20, 277);
            this.cbxSavefiles.Name = "cbxSavefiles";
            this.cbxSavefiles.Size = new System.Drawing.Size(318, 30);
            this.cbxSavefiles.TabIndex = 3;
            this.cbxSavefiles.SelectedIndexChanged += new System.EventHandler(this.cbxSavefiles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(607, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Always backup your files.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "sav";
            this.openFileDialog.FileName = "HellbladeSave_0";
            this.openFileDialog.Filter = "Hellblade Savegame File|*.sav";
            // 
            // btnChangeFolder
            // 
            this.btnChangeFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeFolder.FlatAppearance.BorderSize = 0;
            this.btnChangeFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnChangeFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFolder.ForeColor = System.Drawing.Color.White;
            this.btnChangeFolder.Location = new System.Drawing.Point(20, 349);
            this.btnChangeFolder.Name = "btnChangeFolder";
            this.btnChangeFolder.Size = new System.Drawing.Size(399, 30);
            this.btnChangeFolder.TabIndex = 5;
            this.btnChangeFolder.Text = "Change save files folder location";
            this.btnChangeFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeFolder.UseVisualStyleBackColor = false;
            this.btnChangeFolder.Click += new System.EventHandler(this.btnChangeFolder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HellbladeSaveLoader.Properties.Resources.hellblade_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pbxThumbnail
            // 
            this.pbxThumbnail.BackColor = System.Drawing.Color.Black;
            this.pbxThumbnail.Location = new System.Drawing.Point(20, 128);
            this.pbxThumbnail.Name = "pbxThumbnail";
            this.pbxThumbnail.Size = new System.Drawing.Size(208, 117);
            this.pbxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThumbnail.TabIndex = 7;
            this.pbxThumbnail.TabStop = false;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Location = new System.Drawing.Point(24, 385);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(399, 30);
            this.btnOpenFolder.TabIndex = 8;
            this.btnOpenFolder.Text = "Navigate to savegame files folder";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::HellbladeSaveLoader.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 432);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.pbxThumbnail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChangeFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSavefiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBackup);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hellblade: Senua\'s Sacrifice Savegame File Loader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSavefiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnChangeFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxThumbnail;
        private System.Windows.Forms.Button btnOpenFolder;
    }
}

