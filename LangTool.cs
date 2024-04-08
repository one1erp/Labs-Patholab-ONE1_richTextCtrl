using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ONE1_richTextCtrl
{
    public partial class LangTool : UserControl
    {


        public LangTool()
        {
            InitializeComponent();
        }

        public event Action HebrewChanged;
        public event Action EnglishChanged;
        public event Action NoneChanged;

        public void MakeChecking(Lang b)
        {
            switch (b)
            {
                case Lang.EN:
                    rdbEN.Checked = true;
                    break;
                case Lang.HE:
                    rdbHE.Checked = true;
                    break;
                case Lang.OFF:
                    rdbOff.Checked = true;
                    break;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (NoneChanged != null) NoneChanged();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (HebrewChanged != null) HebrewChanged();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (EnglishChanged != null) EnglishChanged();
        }
    }
    public enum Lang
    {
        EN, HE, OFF
    }
}
