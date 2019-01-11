namespace HellbladeSaveLoader
{
    partial class NewFileDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFileDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblThumbnailDirectory = new System.Windows.Forms.Label();
            this.lblSavegameDirectory = new System.Windows.Forms.Label();
            this.pbxThumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Savegame description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(12, 34);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(401, 29);
            this.txtDescription.TabIndex = 4;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(230, 69);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(183, 30);
            this.btnSelectImage.TabIndex = 10;
            this.btnSelectImage.Text = "Select thumbnail...";
            this.btnSelectImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(12, 192);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(401, 30);
            this.btnSelectFile.TabIndex = 11;
            this.btnSelectFile.Text = "Select savegame file location...";
            this.btnSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(401, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save new file";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblThumbnailDirectory
            // 
            this.lblThumbnailDirectory.AutoEllipsis = true;
            this.lblThumbnailDirectory.BackColor = System.Drawing.Color.Transparent;
            this.lblThumbnailDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThumbnailDirectory.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.lblThumbnailDirectory.ForeColor = System.Drawing.Color.White;
            this.lblThumbnailDirectory.Location = new System.Drawing.Point(230, 102);
            this.lblThumbnailDirectory.Name = "lblThumbnailDirectory";
            this.lblThumbnailDirectory.Size = new System.Drawing.Size(183, 22);
            this.lblThumbnailDirectory.TabIndex = 14;
            this.lblThumbnailDirectory.Text = "<dir>";
            this.lblThumbnailDirectory.Visible = false;
            // 
            // lblSavegameDirectory
            // 
            this.lblSavegameDirectory.AutoEllipsis = true;
            this.lblSavegameDirectory.BackColor = System.Drawing.Color.Transparent;
            this.lblSavegameDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSavegameDirectory.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.lblSavegameDirectory.ForeColor = System.Drawing.Color.White;
            this.lblSavegameDirectory.Location = new System.Drawing.Point(12, 225);
            this.lblSavegameDirectory.Name = "lblSavegameDirectory";
            this.lblSavegameDirectory.Size = new System.Drawing.Size(401, 22);
            this.lblSavegameDirectory.TabIndex = 15;
            this.lblSavegameDirectory.Text = "<dir>";
            this.lblSavegameDirectory.Visible = false;
            // 
            // pbxThumbnail
            // 
            this.pbxThumbnail.BackColor = System.Drawing.Color.Black;
            this.pbxThumbnail.Location = new System.Drawing.Point(16, 69);
            this.pbxThumbnail.Name = "pbxThumbnail";
            this.pbxThumbnail.Size = new System.Drawing.Size(208, 117);
            this.pbxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThumbnail.TabIndex = 13;
            this.pbxThumbnail.TabStop = false;
            // 
            // NewFileDialog
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(425, 309);
            this.Controls.Add(this.lblSavegameDirectory);
            this.Controls.Add(this.lblThumbnailDirectory);
            this.Controls.Add(this.pbxThumbnail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewFileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add new savegame file";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbxThumbnail;
        private System.Windows.Forms.Label lblThumbnailDirectory;
        private System.Windows.Forms.Label lblSavegameDirectory;
    }
}