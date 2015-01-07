namespace ModManager
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tileControlMainMenu = new DevExpress.XtraEditors.TileControl();
            this.tileGroupLaunch = new DevExpress.XtraEditors.TileGroup();
            this.tileItemLaunch = new DevExpress.XtraEditors.TileItem();
            this.tileGroupManage = new DevExpress.XtraEditors.TileGroup();
            this.tileItemManage = new DevExpress.XtraEditors.TileItem();
            this.tileGroupFind = new DevExpress.XtraEditors.TileGroup();
            this.tileItemFind = new DevExpress.XtraEditors.TileItem();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelFindPath = new System.Windows.Forms.Panel();
            this.findPathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 242);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = null;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(334, 20);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "WhiteForm";
            // 
            // tileControlMainMenu
            // 
            this.tileControlMainMenu.AllowDrag = false;
            this.tileControlMainMenu.AllowDragTilesBetweenGroups = false;
            this.tileControlMainMenu.AllowItemHover = true;
            this.tileControlMainMenu.BackColor = System.Drawing.Color.White;
            this.tileControlMainMenu.DragSize = new System.Drawing.Size(0, 0);
            this.tileControlMainMenu.Groups.Add(this.tileGroupLaunch);
            this.tileControlMainMenu.Groups.Add(this.tileGroupManage);
            this.tileControlMainMenu.Groups.Add(this.tileGroupFind);
            this.tileControlMainMenu.ItemSize = 200;
            this.tileControlMainMenu.Location = new System.Drawing.Point(-7, 150);
            this.tileControlMainMenu.MaxId = 19;
            this.tileControlMainMenu.Name = "tileControlMainMenu";
            this.tileControlMainMenu.RowCount = 0;
            this.tileControlMainMenu.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileControlMainMenu.Size = new System.Drawing.Size(950, 270);
            this.tileControlMainMenu.TabIndex = 1;
            // 
            // tileGroupLaunch
            // 
            this.tileGroupLaunch.Items.Add(this.tileItemLaunch);
            this.tileGroupLaunch.Name = "tileGroupLaunch";
            // 
            // tileItemLaunch
            // 
            this.tileItemLaunch.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileItemLaunch.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileItemLaunch.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItemLaunch.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemLaunch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemLaunch.BackgroundImage")));
            this.tileItemLaunch.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tileItemLaunch.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement1.Text = "Launch Game";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemLaunch.Elements.Add(tileItemElement1);
            this.tileItemLaunch.Id = 15;
            this.tileItemLaunch.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItemLaunch.Name = "tileItemLaunch";
            this.tileItemLaunch.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            // 
            // tileGroupManage
            // 
            this.tileGroupManage.Items.Add(this.tileItemManage);
            this.tileGroupManage.Name = "tileGroupManage";
            // 
            // tileItemManage
            // 
            this.tileItemManage.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileItemManage.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.tileItemManage.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItemManage.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemManage.BackgroundImage")));
            this.tileItemManage.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.tileItemManage.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement2.Text = "Manage Mods";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemManage.Elements.Add(tileItemElement2);
            this.tileItemManage.Id = 17;
            this.tileItemManage.Name = "tileItemManage";
            this.tileItemManage.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            // 
            // tileGroupFind
            // 
            this.tileGroupFind.Items.Add(this.tileItemFind);
            this.tileGroupFind.Name = "tileGroupFind";
            // 
            // tileItemFind
            // 
            this.tileItemFind.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileItemFind.AppearanceItem.Normal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.tileItemFind.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItemFind.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemFind.BackgroundImage")));
            this.tileItemFind.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            this.tileItemFind.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement3.Text = "Find Mods";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemFind.Elements.Add(tileItemElement3);
            this.tileItemFind.Id = 16;
            this.tileItemFind.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItemFind.Name = "tileItemFind";
            this.tileItemFind.Padding = new System.Windows.Forms.Padding(7, 2, 2, 2);
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Location = new System.Drawing.Point(748, 546);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(183, 13);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Mitchell Heastie © Copyright 2099";
            // 
            // labelPath
            // 
            this.labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(3, 546);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(183, 13);
            this.labelPath.TabIndex = 3;
            this.labelPath.Text = "Mitchell Heastie © Copyright 2099";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(445, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(44, 48);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Augustus", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(910, 44);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Total War Mod Manager";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelFindPath
            // 
            this.panelFindPath.Location = new System.Drawing.Point(-7, 150);
            this.panelFindPath.Name = "panelFindPath";
            this.panelFindPath.Size = new System.Drawing.Size(950, 270);
            this.panelFindPath.TabIndex = 6;
            // 
            // findPathFolderBrowserDialog
            // 
            this.findPathFolderBrowserDialog.Description = "Please locate the path to Rome2.exe manually....";
            this.findPathFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.findPathFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // FormMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.panelFindPath);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.tileControlMainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "WhiteForm";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TileControl tileControlMainMenu;
        private DevExpress.XtraEditors.TileGroup tileGroupLaunch;
        private DevExpress.XtraEditors.TileItem tileItemLaunch;
        private DevExpress.XtraEditors.TileItem tileItemFind;
        private DevExpress.XtraEditors.TileGroup tileGroupManage;
        private DevExpress.XtraEditors.TileItem tileItemManage;
        private System.Windows.Forms.Label labelCopyright;
        private DevExpress.XtraEditors.TileGroup tileGroupFind;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelFindPath;
        private System.Windows.Forms.FolderBrowserDialog findPathFolderBrowserDialog;
    }
}

