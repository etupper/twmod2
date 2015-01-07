using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using DevExpress.XtraSplashScreen;

namespace ModManager
{
    public partial class WaitFormMain : WaitForm
    {
        public WaitFormMain()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.CloseForm(false);
        }
    }
}