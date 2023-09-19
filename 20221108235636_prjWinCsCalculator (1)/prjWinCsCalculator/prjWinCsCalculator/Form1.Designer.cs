namespace prjWinCsCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuProgrammes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucalculatrices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVScientifique = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubureauxChange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVersionLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnLigne = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProgrammes,
            this.mnuView,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuProgrammes
            // 
            this.mnuProgrammes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnucalculatrices,
            this.mnubureauxChange,
            this.mnuQuitter});
            this.mnuProgrammes.Name = "mnuProgrammes";
            this.mnuProgrammes.Size = new System.Drawing.Size(87, 20);
            this.mnuProgrammes.Text = "Programmes";
            // 
            // mnucalculatrices
            // 
            this.mnucalculatrices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnucalculatrices.BackgroundImage")));
            this.mnucalculatrices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVStandard,
            this.mnuVScientifique});
            this.mnucalculatrices.Name = "mnucalculatrices";
            this.mnucalculatrices.Size = new System.Drawing.Size(221, 22);
            this.mnucalculatrices.Text = "Calculators";
            // 
            // mnuVStandard
            // 
            this.mnuVStandard.Name = "mnuVStandard";
            this.mnuVStandard.Size = new System.Drawing.Size(183, 22);
            this.mnuVStandard.Text = "Version Standard";
            this.mnuVStandard.Click += new System.EventHandler(this.mnuVStandard_Click);
            // 
            // mnuVScientifique
            // 
            this.mnuVScientifique.Name = "mnuVScientifique";
            this.mnuVScientifique.Size = new System.Drawing.Size(183, 22);
            this.mnuVScientifique.Text = "Version Scientificque";
            this.mnuVScientifique.Click += new System.EventHandler(this.mnuVScientifique_Click);
            // 
            // mnubureauxChange
            // 
            this.mnubureauxChange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVersionLocal,
            this.mnuEnLigne});
            this.mnubureauxChange.Name = "mnubureauxChange";
            this.mnubureauxChange.Size = new System.Drawing.Size(221, 22);
            this.mnubureauxChange.Text = "Bureaux Change";
            // 
            // mnuVersionLocal
            // 
            this.mnuVersionLocal.Name = "mnuVersionLocal";
            this.mnuVersionLocal.Size = new System.Drawing.Size(160, 22);
            this.mnuVersionLocal.Text = "Version Local";
            // 
            // mnuEnLigne
            // 
            this.mnuEnLigne.Name = "mnuEnLigne";
            this.mnuEnLigne.Size = new System.Drawing.Size(160, 22);
            this.mnuEnLigne.Text = "Version En Ligne";
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuQuitter.Size = new System.Drawing.Size(221, 22);
            this.mnuQuitter.Text = "Quitter Programme ";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolbar,
            this.mnuStatusbar});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            this.mnuView.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuToolbar
            // 
            this.mnuToolbar.Name = "mnuToolbar";
            this.mnuToolbar.Size = new System.Drawing.Size(180, 22);
            this.mnuToolbar.Text = "Toolbar";
            this.mnuToolbar.Visible = false;
            this.mnuToolbar.Click += new System.EventHandler(this.mnuToolbar_Click);
            // 
            // mnuStatusbar
            // 
            this.mnuStatusbar.Name = "mnuStatusbar";
            this.mnuStatusbar.Size = new System.Drawing.Size(180, 22);
            this.mnuStatusbar.Text = "Status Bar";
            this.mnuStatusbar.Visible = false;
            this.mnuStatusbar.Click += new System.EventHandler(this.mnuStatusbar_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserManual,
            this.mnuPropos});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuUserManual
            // 
            this.mnuUserManual.Name = "mnuUserManual";
            this.mnuUserManual.Size = new System.Drawing.Size(143, 22);
            this.mnuUserManual.Text = "User Manual";
            this.mnuUserManual.Click += new System.EventHandler(this.mnuUserManual_Click);
            // 
            // mnuPropos
            // 
            this.mnuPropos.Name = "mnuPropos";
            this.mnuPropos.Size = new System.Drawing.Size(143, 22);
            this.mnuPropos.Text = "A propos .. ...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 334);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 356);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "College LaSalle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuProgrammes;
        private System.Windows.Forms.ToolStripMenuItem mnucalculatrices;
        private System.Windows.Forms.ToolStripMenuItem mnuVStandard;
        private System.Windows.Forms.ToolStripMenuItem mnuVScientifique;
        private System.Windows.Forms.ToolStripMenuItem mnubureauxChange;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuVersionLocal;
        private System.Windows.Forms.ToolStripMenuItem mnuEnLigne;
        private System.Windows.Forms.ToolStripMenuItem mnuToolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuStatusbar;
        private System.Windows.Forms.ToolStripMenuItem mnuUserManual;
        private System.Windows.Forms.ToolStripMenuItem mnuPropos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

