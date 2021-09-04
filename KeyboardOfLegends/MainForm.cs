using System;
using System.Windows.Forms;

namespace KeyboardOfLegends
{

    public partial class MainForm : Form
    {
        HookKeys hk;
        public MainForm()
        {
            InitializeComponent();

            hk = new HookKeys();

            Run(false);
        }

        void Run(bool pStart)
        {
            HookKeys.HookDisabled = !pStart;
            StopButton.Enabled = pStart;
            StartButton.Enabled = !pStart;
            LabelRunning.Visible = pStart;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (hk == null)
                hk = new HookKeys();

            Run(true);
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Run(false);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            //open read.me github page
        }
    }   
}
