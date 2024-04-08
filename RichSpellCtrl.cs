using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ONE1_richTextCtrl
{
    public partial class RichSpellCtrl : UserControl
    {
        bool useSpellChecker;

        #region Ctor
        public event Action ExtraBtnClciked;
        public RichSpellCtrl()
        {
            InitializeComponent();

            //Add Option to disable spell checker 24/3/22
            //if (!DesignMode)
            //{
            // code that shouldn't be executed at design time 
            useSpellChecker = UseSpellCheckConfig();


            TextBoxBase rt = rtbDocument;
            if (useSpellChecker == false)
                NHunspellTextBoxExtender1.DisableTextBoxBase(ref rt);

            //}

        }


        private LangTool lt;
        public event Action<RightToLeft> AlignChanged;
        #endregion
        public enum RicherTextBoxToolStripGroups
        {
            SaveAndLoad = 0x1,
            FontNameAndSize = 0x2,
            BoldUnderlineItalic = 0x4,
            Alignment = 0x8,
            FontColor = 0x10,
            IndentationAndBullets = 0x20,
            Insert = 0x40,
            Zoom = 0x80
        }

        #region Changing visibility of toolstrip items

        public void HideToolstripItemsByGroup(RicherTextBoxToolStripGroups group, bool visible)
        {
            if ((group & RicherTextBoxToolStripGroups.SaveAndLoad) != 0)
            {
                tsbtnSave.Visible = visible;
                tsbtnOpen.Visible = visible;
                toolStripSeparator6.Visible = visible;
            }
            if ((group & RicherTextBoxToolStripGroups.FontNameAndSize) != 0)
            {
                tscmbFont.Visible = visible;
                tscmbFontSize.Visible = visible;
                tsbtnChooseFont.Visible = visible;
                toolStripSeparator1.Visible = visible;
            }
            if ((group & RicherTextBoxToolStripGroups.BoldUnderlineItalic) != 0)
            {
                tsbtnBold.Visible = visible;
                tsbtnItalic.Visible = visible;
                tsbtnUnderline.Visible = visible;
                toolStripSeparator2.Visible = visible;
            }
            if ((group & RicherTextBoxToolStripGroups.Alignment) != 0)
            {
                tsbtnAlignLeft.Visible = visible;
                tsbtnAlignRight.Visible = visible;
                tsbtnAlignCenter.Visible = visible;
                toolStripSeparator3.Visible = visible;
            }
            if ((group & RicherTextBoxToolStripGroups.FontColor) != 0)
            {
                tsbtnFontColor.Visible = visible;
                tsbtnWordWrap.Visible = visible;
                toolStripSeparator4.Visible = visible;
            }
            if ((group & RicherTextBoxToolStripGroups.IndentationAndBullets) != 0)
            {
                tsbtnIndent.Visible = visible;
                tsbtnOutdent.Visible = visible;
                tsbtnBullets.Visible = visible;
                toolStripSeparator5.Visible = visible;
            }
            if ((group & RicherTextBoxToolStripGroups.Insert) != 0)
            {
                tsbtnInsertPicture.Visible = visible;
                toolStripSeparator7.Visible = visible;
            }
            if ((group & RicherTextBoxToolStripGroups.Zoom) != 0)
            {
                tsbtnZoomOut.Visible = visible;
                tsbtnZoomIn.Visible = visible;
                tstxtZoomFactor.Visible = visible;
            }
        }

        public bool IsGroupVisible(RicherTextBoxToolStripGroups group)
        {
            switch (group)
            {
                case RicherTextBoxToolStripGroups.SaveAndLoad:
                    return tsbtnSave.Visible && tsbtnOpen.Visible && toolStripSeparator6.Visible;

                case RicherTextBoxToolStripGroups.FontNameAndSize:
                    return tscmbFont.Visible && tscmbFontSize.Visible && tsbtnChooseFont.Visible && toolStripSeparator1.Visible;

                case RicherTextBoxToolStripGroups.BoldUnderlineItalic:
                    return tsbtnBold.Visible && tsbtnItalic.Visible && tsbtnUnderline.Visible && toolStripSeparator2.Visible;

                case RicherTextBoxToolStripGroups.Alignment:
                    return tsbtnAlignLeft.Visible && tsbtnAlignRight.Visible && tsbtnAlignCenter.Visible && toolStripSeparator3.Visible;

                case RicherTextBoxToolStripGroups.FontColor:
                    return tsbtnFontColor.Visible && tsbtnWordWrap.Visible && toolStripSeparator4.Visible;

                case RicherTextBoxToolStripGroups.IndentationAndBullets:
                    return tsbtnIndent.Visible && tsbtnOutdent.Visible && tsbtnBullets.Visible && toolStripSeparator5.Visible;

                case RicherTextBoxToolStripGroups.Insert:
                    return tsbtnInsertPicture.Visible && toolStripSeparator7.Visible;

                case RicherTextBoxToolStripGroups.Zoom:
                    return tsbtnZoomOut.Visible && tsbtnZoomIn.Visible && tstxtZoomFactor.Visible;

                default:
                    return false;
            }
        }
        #endregion

        #region Private fields

        public Lang _defLang = Lang.OFF;
        private string _currentLang = null;
        private RchDef f;

        #endregion

        #region Private Methods

        void lt_NoneChanged()
        {

            TextBoxBase rt = rtbDocument;
            NHunspellTextBoxExtender1.DisableTextBoxBase(ref rt);
        }

        void To_heb()
        {
            if (useSpellChecker)
            {
                NHunspellTextBoxExtender1.EnableTextBoxBase(rtbDocument);
                var x = NHunspellTextBoxExtender1.GetAvailableLanguages();
                if(x != null && x.Count()>1) {
                    string heb = x[1];
                    if (_currentLang == heb)
                    {
                        return;
                    }
                    _currentLang = heb;
                    NHunspellTextBoxExtender1.SetLanguage(heb);
                }

            }
        }

        void to_eng()
        {
            if (useSpellChecker)
            {
                NHunspellTextBoxExtender1.EnableTextBoxBase(rtbDocument);
                var x = NHunspellTextBoxExtender1.GetAvailableLanguages();
                if (x != null && x.Count() >= 1)
                {
                    string eng = x[0];
                    if (_currentLang == eng)
                    {
                        return;
                    }
                    _currentLang = eng;
                    NHunspellTextBoxExtender1.SetLanguage(eng);
                }
            }
        }

        #endregion

        #region Public Methods

        public void ClearText()
        {
            this.rtbDocument.Clear();

            this.SetRichDefenitions();
        }

        public RightToLeft DocumentRtl
        {
            get { return rtbDocument.RightToLeft; }
            set
            {

                rtbDocument.RightToLeft = value;

            }
        }

        public bool DocumentBold
        {
            get { return rtbDocument.Font.Bold; }

        }
        public void SetDefaultSpelling()
        {
            _defLang = Lang.EN;
        }

        public string GetOriginalText()
        {
            return rtbDocument.Text;
        }

        public void SetRtf(string s)
        {
            rtbDocument.Rtf = s;
        }
        public void AppendText(string s)
        {
            rtbDocument.AppendText(s);
        }
        public RichTextBox DocumentBody
        {
            get
            { return rtbDocument; }
        }
        public string GetRtf()
        {
            return rtbDocument.Rtf;
        }

        #endregion

        //A flag for specific project fixing bug (reSecretry), doesn't affect the other projects. AE
        public bool formLoadingControlflag = true;

        public void Form1_Load(object sender, EventArgs e)
        {
            if(formLoadingControlflag) {
                AppendLangTool();

                // load system fonts
                foreach (FontFamily family in FontFamily.Families)
                {
                    if (IsFontInstalled(family.Name))
                        tscmbFont.Items.Add(family.Name);
                }
                if (System.Diagnostics.Process.GetCurrentProcess().ProcessName != "devenv" &&
                    System.Diagnostics.Process.GetCurrentProcess().ProcessName != "WpfApplication4")
                    this.SetRichDefenitions();

                tsbtnBold.Checked = false;

                tsbtnWordWrap.Checked = rtbDocument.WordWrap;

                return;
            }
           

        }


        public void SetRichDefenitions()
        {
            if (f == null)
                f = Config();

            if (f == null)
            {
                // defaults are "Arial", 11 ,
                this.rtbDocument.Font = new Font("Arial", 11);
                tscmbFont.SelectedItem = rtbDocument.SelectionFont.FontFamily.Name;
                int s = Convert.ToInt16(rtbDocument.SelectionFont.Size);
                tscmbFontSize.SelectedItem = s.ToString();

                //   f.ZoomNum = 140;
                tstxtZoomFactor.Text = Convert.ToString(rtbDocument.ZoomFactor * 100);
                tstxtZoomFactor_Leave(null, null);
            }
            else
            {
                this.rtbDocument.Font = new Font(f.fontFamily, f.fontSize);
                tscmbFont.SelectedItem = rtbDocument.SelectionFont.FontFamily.Name;
                int s = Convert.ToInt16(rtbDocument.SelectionFont.Size);
                tscmbFontSize.SelectedItem = s.ToString();
                SetConstZoom();

                //tstxtZoomFactor.Text = f.ZoomNum.ToString();

                //tstxtZoomFactor_Leave(null, null);

            }
        }
        public void SetConstZoom()
        {
            if (f == null)
                f = Config();

            if (f == null)
            {


                f.ZoomNum = 140;
                tstxtZoomFactor.Text = Convert.ToString(rtbDocument.ZoomFactor * 100);
                tstxtZoomFactor_Leave(null, null);
            }
            else
            {


                rtbDocument.ZoomFactor = Convert.ToSingle(f.ZoomNum / 100);
                tstxtZoomFactor.Text = String.Format("{0:F0}", rtbDocument.ZoomFactor * 100);



            }
        }
        private void AppendLangTool()
        {
            if (lt != null) return;
            //if (lt == null)
            lt = new LangTool();
            lt.HebrewChanged += To_heb;
            lt.EnglishChanged += to_eng;
            lt.NoneChanged += lt_NoneChanged;

            if (!toolStrip1.Contains(lt))
            {
                ToolStripControlHost host = new ToolStripControlHost(lt);
                toolStrip1.Items.Insert(toolStrip1.Items.Count, host);               
            }
            lt.MakeChecking(_defLang);

        }

        public class RchDef
        {

            public string fontFamily { get; set; }
            public float fontSize { get; set; }
            public float ZoomNum { get; set; }
        }
        public RchDef Config()
        {
            try
            {

                string assemblyPath = Assembly.GetExecutingAssembly().Location;
                ExeConfigurationFileMap map = new ExeConfigurationFileMap();
                map.ExeConfigFilename = assemblyPath + ".config";
                Configuration cfg = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
                var _appSettings = cfg.AppSettings;
                RchDef rchDef = new RchDef();
                rchDef.fontFamily = _appSettings.Settings["FontFamily"].Value;
                rchDef.fontSize = float.Parse(_appSettings.Settings["FontSize"].Value);
                rchDef.ZoomNum = float.Parse(_appSettings.Settings["ZoomNum"].Value);
                return rchDef;// new Font(fontFamily, fontSize);

            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #region Style

        private const int INDENT = 10;

        #region Toolstrip items handling

        private void tsbtnBIU_Click(object sender, EventArgs e)
        {
            // bold, italic, underline
            try
            {
                if (rtbDocument.SelectionFont != null)
                {
                    Font currentFont = rtbDocument.SelectionFont;
                    FontStyle newFontStyle = rtbDocument.SelectionFont.Style;
                    string txt = (sender as ToolStripButton).Name;
                    if (txt.IndexOf("Bold") >= 0)
                        newFontStyle = rtbDocument.SelectionFont.Style ^ FontStyle.Bold;
                    else if (txt.IndexOf("Italic") >= 0)
                        newFontStyle = rtbDocument.SelectionFont.Style ^ FontStyle.Italic;
                    else if (txt.IndexOf("Underline") >= 0)
                        newFontStyle = rtbDocument.SelectionFont.Style ^ FontStyle.Underline;

                    rtbDocument.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            rtbDocument.SelectAll();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            rtbDocument.Clear();
        }

        private void tsbtnAlignment_Click(object sender, EventArgs e)
        {
            // alignment: left, center, right
            try
            {
                string txt = (sender as ToolStripButton).Name;
                if (txt.IndexOf("Left") >= 0)
                {
                    rtbDocument.SelectionAlignment = HorizontalAlignment.Left;
                    tsbtnAlignLeft.Checked = true;
                    tsbtnAlignCenter.Checked = false;
                    tsbtnAlignRight.Checked = false;

                }
                else if (txt.IndexOf("Center") >= 0)
                {
                    rtbDocument.SelectionAlignment = HorizontalAlignment.Center;
                    tsbtnAlignLeft.Checked = false;
                    tsbtnAlignCenter.Checked = true;
                    tsbtnAlignRight.Checked = false;
                }
                else if (txt.IndexOf("Right") >= 0)
                {
                    rtbDocument.SelectionAlignment = HorizontalAlignment.Right;
                    tsbtnAlignLeft.Checked = false;
                    tsbtnAlignCenter.Checked = false;
                    tsbtnAlignRight.Checked = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void tsbtnFontColor_Click_1(object sender, EventArgs e)
        {
            // font color
            try
            {
                using (ColorDialog dlg = new ColorDialog())
                {
                    dlg.Color = rtbDocument.SelectionColor;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        rtbDocument.SelectionColor = dlg.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void tsbtnBulletsAndNumbering_Click(object sender, EventArgs e)
        {
            // bullets, indentation
            try
            {
                string name = (sender as ToolStripButton).Name;
                if (name.IndexOf("Bullets") >= 0)
                    rtbDocument.SelectionBullet = tsbtnBullets.Checked;
                else if (name.IndexOf("Indent") >= 0)
                    rtbDocument.SelectionIndent += INDENT;
                else if (name.IndexOf("Outdent") >= 0)
                    rtbDocument.SelectionIndent -= INDENT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }


        private void tscmbFont_Click(object sender, EventArgs e)
        {
            // font
            try
            {

                if (rtbDocument.SelectionFont != null)
                {
                    Font currentFont = rtbDocument.SelectionFont;
                    FontFamily newFamily = new FontFamily(tscmbFont.SelectedItem.ToString());
                    rtbDocument.SelectionFont = new Font(newFamily, currentFont.Size, currentFont.Style);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void tscmbFontSize_Click(object sender, EventArgs e)
        {


            // font size
            try
            {
                if (rtbDocument.SelectionFont != null)
                {
                    Font currentFont = rtbDocument.SelectionFont;
                    float newSize = Convert.ToSingle(tscmbFontSize.SelectedItem.ToString());
                    rtbDocument.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }



        private void tscmbFontSize_TextChanged(object sender, EventArgs e)
        {
            // font size custom
            try
            {
                if (rtbDocument.SelectionFont != null)
                {
                    Font currentFont = rtbDocument.SelectionFont;
                    float newSize = Convert.ToSingle(tscmbFontSize.Text);
                    rtbDocument.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void rtbDocument_SelectionChanged(object sender, EventArgs e)
        {

            if (rtbDocument.SelectionFont != null)
            {
                tsbtnBold.Checked = rtbDocument.SelectionFont.Bold;
                tsbtnItalic.Checked = rtbDocument.SelectionFont.Italic;
                tsbtnUnderline.Checked = rtbDocument.SelectionFont.Underline;

                switch (rtbDocument.SelectionAlignment)
                {
                    case HorizontalAlignment.Left:
                        tsbtnAlignLeft.Checked = true;
                        tsbtnAlignCenter.Checked = false;
                        tsbtnAlignRight.Checked = false;
                        break;

                    case HorizontalAlignment.Center:
                        tsbtnAlignLeft.Checked = false;
                        tsbtnAlignCenter.Checked = true;
                        tsbtnAlignRight.Checked = false;
                        break;

                    case HorizontalAlignment.Right:
                        tsbtnAlignLeft.Checked = false;
                        tsbtnAlignCenter.Checked = false;
                        tsbtnAlignRight.Checked = true;
                        break;
                }

                tsbtnBullets.Checked = rtbDocument.SelectionBullet;


                tscmbFont.SelectedItem = rtbDocument.SelectionFont.FontFamily.Name;
                tscmbFontSize.SelectedItem = rtbDocument.SelectionFont.Size.ToString();
            }
        }



        private void tsbtnInsertPicture_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Insert picture";
                dlg.DefaultExt = "jpg";
                dlg.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif|All files|*.*";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string strImagePath = dlg.FileName;
                        Image img = Image.FromFile(strImagePath);
                        Clipboard.SetDataObject(img);
                        DataFormats.Format df;
                        df = DataFormats.GetFormat(DataFormats.Bitmap);
                        if (this.rtbDocument.CanPaste(df))
                        {
                            this.rtbDocument.Paste(df);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Unable to insert image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsbtnSave_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Rich text format|*.rtf";
                dlg.FilterIndex = 0;
                dlg.OverwritePrompt = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rtbDocument.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText);
                    }
                    catch (IOException exc)
                    {
                        MessageBox.Show("Error writing file: \n" + exc.Message, "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    catch (ArgumentException exc_a)
                    {
                        MessageBox.Show("Error writing file: \n" + exc_a.Message, "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tsbtnOpen_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Rich text format|*.rtf";
                dlg.FilterIndex = 0;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rtbDocument.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
                    }
                    catch (IOException exc)
                    {
                        MessageBox.Show("Error reading file: \n" + exc.Message, "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    catch (ArgumentException exc_a)
                    {
                        MessageBox.Show("Error reading file: \n" + exc_a.Message, "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }

                }
            }


        }


        private void tsbtnZoomOut_Click(object sender, EventArgs e)
        {

            if (rtbDocument.ZoomFactor > 0.16f + 0.20f)
            {
                rtbDocument.ZoomFactor -= 0.20f;
                tstxtZoomFactor.Text = String.Format("{0:F0}", rtbDocument.ZoomFactor * 100);
            }
        }

        private void tsbtnZoomIn_Click(object sender, EventArgs e)
        {

            if (rtbDocument.ZoomFactor < 64.0f - 0.20f)
            {
                rtbDocument.ZoomFactor += 0.20f;
                tstxtZoomFactor.Text = String.Format("{0:F0}", rtbDocument.ZoomFactor * 100);
            }

        }


        public float GetZoom
        {
            get { return rtbDocument.ZoomFactor; }

        }

        private void tstxtZoomFactor_Leave(object sender, EventArgs e)
        {


            try
            {
                rtbDocument.ZoomFactor = Convert.ToSingle(tstxtZoomFactor.Text) / 100;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter  valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tstxtZoomFactor.Focus();
                tstxtZoomFactor.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Enter valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tstxtZoomFactor.Focus();
                tstxtZoomFactor.SelectAll();
            }
            catch (ArgumentException)
            {

                MessageBox.Show("Zoom factor should be between 20% and 6400%", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                tstxtZoomFactor.Focus();
                tstxtZoomFactor.SelectAll();
            }
        }

        private void tsbtnWordWrap_Click_1(object sender, EventArgs e)
        {
            rtbDocument.WordWrap = tsbtnWordWrap.Checked;
        }

        #endregion

        #region Find and Replace

        private void tsbtnFind_Click_1(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm();
            findForm.RtbInstance = this.rtbDocument;
            findForm.InitialText = this.tstxtSearchText.Text;
            findForm.Show();
        }

        private void tsbtnReplace_Click_1(object sender, EventArgs e)
        {
            ReplaceForm replaceForm = new ReplaceForm();
            replaceForm.RtbInstance = this.rtbDocument;
            replaceForm.InitialText = this.tstxtSearchText.Text;
            replaceForm.Show();
        }

        #endregion
        #region Public methods for accessing the functionality of the RicherTextBox

        public void SetFontFamily(FontFamily family)
        {
            if (family != null)
            {
                tscmbFont.SelectedItem = family.Name;
            }
        }

        public void SetFontSize(float newSize)
        {
            tscmbFontSize.Text = newSize.ToString();
        }

        public void ToggleBold()
        {
            tsbtnBold.PerformClick();
        }

        public void ToggleItalic()
        {
            tsbtnItalic.PerformClick();
        }

        public void ToggleUnderline()
        {
            tsbtnUnderline.PerformClick();
        }

        public void SetAlign(HorizontalAlignment alignment)
        {
            switch (alignment)
            {
                case HorizontalAlignment.Center:
                    tsbtnAlignCenter.PerformClick();
                    break;

                case HorizontalAlignment.Left:
                    tsbtnAlignLeft.PerformClick();
                    break;

                case HorizontalAlignment.Right:
                    tsbtnAlignRight.PerformClick();
                    break;
            }
        }

        public void Indent()
        {
            tsbtnIndent.PerformClick();
        }

        public void Outdent()
        {
            tsbtnOutdent.PerformClick();
        }

        public void ToggleBullets()
        {
            tsbtnBullets.PerformClick();
        }

        public void ZoomIn()
        {
            tsbtnZoomIn.PerformClick();
        }

        public void ZoomOut()
        {
            tsbtnZoomOut.PerformClick();
        }

        public void ZoomTo(float factor)
        {
            rtbDocument.ZoomFactor = factor;
        }

        public void SetWordWrap(bool activated)
        {
            rtbDocument.WordWrap = activated;
        }
        #endregion

        #endregion

        private void tsbtnChooseFont_Click(object sender, EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                if (rtbDocument.SelectionFont != null) dlg.Font = rtbDocument.SelectionFont;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    rtbDocument.SelectionFont = dlg.Font;
                }
            }
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            rtbDocument.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            rtbDocument.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            rtbDocument.Paste();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            rtbDocument.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            rtbDocument.Redo();
        }
        private void tsbtnRTL_Click(object sender, EventArgs e)
        {
            rtbDocument.RightToLeft = RightToLeft.Yes;
        }
        private void tsbtnLTR_Click(object sender, EventArgs e)
        {
            rtbDocument.RightToLeft = RightToLeft.No;
        }
        private bool IsFontInstalled(string fontName1)
        {
            string fontName = fontName1;
            float fontSize = 12;
            try
            {


                using (Font fontTester = new Font(
                        fontName,
                        fontSize,
                        FontStyle.Regular,
                        GraphicsUnit.Pixel))
                {
                    if (fontTester.Name == fontName)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        #region bulllet

        private void rightBrackets1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //     rtbDocument.BulletStyle = RichTextBoxEx.AdvRichTextBulletStyle.RightParenthesis;
        }

        private void doubleBrackets1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //      rtbDocument.BulletStyle = RichTextBoxEx.AdvRichTextBulletStyle.DoubleParenthesis;
        }

        private void period1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // rtbDocument.BulletStyle = RichTextBoxEx.AdvRichTextBulletStyle.Period;
        }

        private void plain1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   rtbDocument.BulletStyle = RichTextBoxEx.AdvRichTextBulletStyle.Plain;
        }

        private void noNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   rtbDocument.BulletStyle = RichTextBoxEx.AdvRichTextBulletStyle.NoNumber;

        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    rtbDocument.BulletType = RichTextBoxEx.AdvRichTextBulletType.Normal;

        }

        private void numberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  rtbDocument.BulletType = RichTextBoxEx.AdvRichTextBulletType.Number;

        }

        private void lowerAlphabetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    rtbDocument.BulletType = RichTextBoxEx.AdvRichTextBulletType.LowerCaseLetter;


        }

        private void uPPERALPHABETSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  rtbDocument.BulletType = RichTextBoxEx.AdvRichTextBulletType.UpperCaseLetter;

        }

        private void lowerRomansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //       rtbDocument.BulletType = RichTextBoxEx.AdvRichTextBulletType.LowerCaseRoman;

        }

        private void UPPERROMANSoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //     rtbDocument.BulletType = RichTextBoxEx.AdvRichTextBulletType.UpperCaseRoman;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Not use

        public static string GetWord(string input, int position)
        //Extracts the whole word the mouse is currently focused on.
        {
            char s = input[position];
            int sp1 = 0, sp2 = input.Length;
            for (int i = position; i > 0; i--)
            {
                char ch = input[i];
                if (ch == ' ' || ch == '\n')
                {
                    sp1 = i;
                    break;
                }
            }

            for (int i = position; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == ' ' || ch == '\n')
                {
                    sp2 = i;
                    break;
                }
            }

            return input.Substring(sp1, sp2 - sp1).Replace("\n", "");
        }



        public bool HasHebrewChar(string value)
        {
            return value.ToCharArray().Any(x => (x <= 'ת' && x >= 'א'));
        }

        #endregion

        private void RichTextBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                int cur = rtbDocument.GetCharIndexFromPosition(e.Location);
                string txt = rtbDocument.Text;
                var afterWord = txt.IndexOfAny(new char[] { ' ', '\n' }, cur);
                var beforeWord = txt.Substring(0, cur).LastIndexOfAny(new char[] { ' ', '\n' });
                if (beforeWord == -1)
                    beforeWord = 0;
                if (afterWord == -1)
                    afterWord = txt.Length;
                var full = txt.Substring(beforeWord, afterWord - beforeWord);
                if (HasHebrewChar(full))
                    To_heb();
                else
                    to_eng();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetConstZoom();
        }

        public ToolStripButton ExtraStrip
        {
            get
            { return extrBtn; }
        }


        private void extrBtn_Click(object sender, EventArgs e)
        {
            if (ExtraBtnClciked != null)
                ExtraBtnClciked();
        }

        #region Capital Letter

        private string[] separator = new[] { "\r\n", "\r", "\n", "\\par" };

        private void rtbDocument_Key_up(object sender, KeyEventArgs e)
        {
            //return;//לא עובד
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    //rtbDocument.SpellChecker.IgnoreAlphaNumericWords = true;

                    //מספר שורה נוכחי
                    var linenum = rtbDocument.GetLineFromCharIndex(rtbDocument.SelectionStart);

                    //מיקום אחרון של הסמן
                    var CursorPos = rtbDocument.GetFirstCharIndexOfCurrentLine();

                    //השורה להחלפה
                    string line2replace = rtbDocument.Lines[linenum - 1];

                    //התו הראשון בשורה להחלפה
                    var firstChar = rtbDocument.GetFirstCharIndexFromLine(linenum - 1);

                    //האם צריך או אפשרי להחליף
                    if (!First_Char_Should_be_replaced(line2replace)) return;

                    //בחירה של התו להחלפה
                    rtbDocument.Select(firstChar, 1);

                    int index = rtbDocument.Text.IndexOf(line2replace);


                    if (linenum != 1)
                        rtbDocument.Rtf =
                            rtbDocument.Rtf.Replace("\n" + line2replace, "\n" + UppercaseFirst(line2replace));

                    else//זו שורה ראשונה  
                    {
                        rtbDocument.Rtf =
                            rtbDocument.Rtf.Replace(" " + line2replace, " " + UppercaseFirst(line2replace));
                    }

                    rtbDocument.Select(CursorPos, 0);


                }
                catch (Exception ex)
                {

                }
            }



        }

        private bool First_Char_Should_be_replaced(string line4replace)
        {
            if (string.IsNullOrEmpty(line4replace)) return false;
            if (!Regex.IsMatch(line4replace.ToString(), "^[a-zA-Z0-9]*$")) return false;
            if (char.IsUpper(line4replace[0])) return false;
            return true;
        }


        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        #endregion
        public bool UseSpellCheckConfig()
        {
            try
            {

                string assemblyPath = Assembly.GetExecutingAssembly().Location;
                ExeConfigurationFileMap map = new ExeConfigurationFileMap();
                map.ExeConfigFilename = assemblyPath + ".config";
                Configuration cfg = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
                var _appSettings = cfg.AppSettings;

                var cfgVal = _appSettings.Settings["UseSpellChecker"].Value;
                if (cfgVal.ToUpper() == "TRUE")
                {
                    return true;
                }
                return false;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error on get UseSpellChecker from config" + ex.Message);
                return false;
            }
        }


     
    }
}