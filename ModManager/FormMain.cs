using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraSplashScreen;

namespace ModManager
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        Game _GAME = new Game();

        public FormMain()
        {
            InitializeComponent();
        }

        #region OVERRIDES
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(SplashScreenMain));
            labelCopyright.Text = "Mitchell Heastie © Copyright " + DateTime.Now.Year;

            _GAME.GetGameDirectory();

            if (_GAME.Path == "")
            {
                labelPath.Text = _GAME.FullPath;
            }
            else
            {
                SplashScreenManager.CloseForm(false);
                SplashScreenManager.ShowForm(this, typeof(WaitFormMain), false, false, false);

                _GAME.GetSteamDirectory();

                if (_GAME.SteamPath == "")
                {
                    labelPath.Text = _GAME.FullPath;
                }
                else
                {
                    SearchDirectory(_GAME.SteamPath, 0);

                    if (_GAME.Path == "")
                    {
                        labelPath.Text = _GAME.FullPath;
                    }
                    else
                    {
                        foreach (DriveInfo drive in DriveInfo.GetDrives().Where(x => x.IsReady))
                        {
                            SearchDirectory(drive.RootDirectory.Name, 0);
                        }

                        if (_GAME.Path == "")
                        {
                            labelPath.Text = _GAME.FullPath;
                        }
                    }
                }
            }
            SplashScreenManager.CloseForm(false);

            while (findPathFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(Path.Combine(findPathFolderBrowserDialog.SelectedPath, "Rome2.exe")))
                {
                    _GAME.Path = findPathFolderBrowserDialog.SelectedPath;

                    break;
                }
                MessageBox.Show("Rome2.exe not found in that directory, please try again.", "Invalid directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (_GAME.Path == "")
            {
                MessageBox.Show("Mod Manager can't work without the path to " + _GAME.EXE + ", exiting!", "Unable to continue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
        }
                
        private void SearchDirectory(string path, int indent)
        {
            if (path.Contains("Recycle.Bin") || path.Contains(_GAME.SteamPath))
            {
                return;
            }

            try
            {
                if ((File.GetAttributes(path) & FileAttributes.ReparsePoint)
                    != FileAttributes.ReparsePoint)
                {
                    foreach (string folder in Directory.GetDirectories(path))
                    {
                        this.Text = folder;
                        SplashScreenManager.Default.SetWaitFormDescription("Searching for game path...\n" + folder);

                        if (File.Exists(Path.Combine(folder, "Rome2.exe")) == true)
                        {
                            _GAME.Path = folder;
                            return;
                        }

                        SearchDirectory(folder, indent + 2);
                    }
                }
            }
            catch (UnauthorizedAccessException) { }
        }
    }

    public class SkinManager : Component
    {
        public SkinManager()
        {
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.WhiteForm).Assembly);
        }
    }
}
