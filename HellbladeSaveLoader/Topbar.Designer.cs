namespace HellbladeSaveLoader
{
    partial class Topbar
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Noto Sans Cond", 10F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Window";
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackColor = System.Drawing.Color.Red;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnCloseWindow.ForeColor = System.Drawing.Color.White;
            this.btnCloseWindow.Location = new System.Drawing.Point(460, 0);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(40, 30);
            this.btnCloseWindow.TabIndex = 1;
            this.btnCloseWindow.Text = "X";
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(415, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "__";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Topbar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.Name = "Topbar";
            this.Size = new System.Drawing.Size(500, 30);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Topbar_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnMinimize;
    }
}
