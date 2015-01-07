using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace ModManager {
    public partial class SplashScreenMain : SplashScreen {
        public SplashScreenMain() {
            InitializeComponent();
            labelCopyright.Text = "Mitchell Heastie © Copyright " + DateTime.Now.Year;
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg) {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand {
        }
    }
}