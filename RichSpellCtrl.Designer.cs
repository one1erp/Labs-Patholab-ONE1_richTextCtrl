using System.Windows.Forms;
using NHunspellExtender;

namespace ONE1_richTextCtrl
{
    partial class RichSpellCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichSpellCtrl));
            this.toolStripFindReplace = new System.Windows.Forms.ToolStrip();
            this.tstxtSearchText = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFind = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReplace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnLTR = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRTL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.extrBtn = new System.Windows.Forms.ToolStripButton();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tscmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tscmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBold = new System.Windows.Forms.ToolStripButton();
            this.tsbtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtZoomFactor = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnChooseFont = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlignRight = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFontColor = new System.Windows.Forms.ToolStripButton();
            this.tsbtnWordWrap = new System.Windows.Forms.ToolStripButton();
            this.tsbtnIndent = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOutdent = new System.Windows.Forms.ToolStripButton();
            this.tsbtnBullets = new System.Windows.Forms.ToolStripButton();
            this.tsbtnInsertPicture = new System.Windows.Forms.ToolStripButton();
            this.tsbtnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.rtbDocument = new System.Windows.Forms.RichTextBox();
            this.NHunspellTextBoxExtender1 = new NHunspellExtender.NHunspellTextBoxExtender();
            this.toolStripFindReplace.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHunspellTextBoxExtender1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripFindReplace
            // 
            this.toolStripFindReplace.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFindReplace.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripFindReplace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstxtSearchText,
            this.tsbtnFind,
            this.tsbtnReplace,
            this.toolStripSeparator12,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator9,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator8,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator10,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator11,
            this.toolStripMenuItem1,
            this.tsbtnLTR,
            this.tsbtnRTL,
            this.toolStripSeparator13,
            this.toolStripSeparator14,
            this.extrBtn});
            this.toolStripFindReplace.Location = new System.Drawing.Point(0, 30);
            this.toolStripFindReplace.Name = "toolStripFindReplace";
            this.toolStripFindReplace.Size = new System.Drawing.Size(885, 27);
            this.toolStripFindReplace.TabIndex = 10;
            this.toolStripFindReplace.Text = "toolStrip2";
            // 
            // tstxtSearchText
            // 
            this.tstxtSearchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtSearchText.Name = "tstxtSearchText";
            this.tstxtSearchText.Size = new System.Drawing.Size(100, 27);
            // 
            // tsbtnFind
            // 
            this.tsbtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFind.Image = global::ONE1_richTextCtrl.Properties.Resources.FindHS;
            this.tsbtnFind.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnFind.Name = "tsbtnFind";
            this.tsbtnFind.Size = new System.Drawing.Size(29, 24);
            this.tsbtnFind.Text = "toolStripButton1";
            this.tsbtnFind.ToolTipText = "Find";
            this.tsbtnFind.Click += new System.EventHandler(this.tsbtnFind_Click_1);
            // 
            // tsbtnReplace
            // 
            this.tsbtnReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnReplace.Image = global::ONE1_richTextCtrl.Properties.Resources.FindNextHS;
            this.tsbtnReplace.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnReplace.Name = "tsbtnReplace";
            this.tsbtnReplace.Size = new System.Drawing.Size(29, 24);
            this.tsbtnReplace.Text = "toolStripButton2";
            this.tsbtnReplace.ToolTipText = "Replace";
            this.tsbtnReplace.Click += new System.EventHandler(this.tsbtnReplace_Click_1);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.deleteToolStripMenuItem.Text = "Clear";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnLTR
            // 
            this.tsbtnLTR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLTR.Image = global::ONE1_richTextCtrl.Properties.Resources.left;
            this.tsbtnLTR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLTR.Name = "tsbtnLTR";
            this.tsbtnLTR.Size = new System.Drawing.Size(29, 24);
            this.tsbtnLTR.Text = "Left to right";
            this.tsbtnLTR.Click += new System.EventHandler(this.tsbtnLTR_Click);
            // 
            // tsbtnRTL
            // 
            this.tsbtnRTL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRTL.Image = global::ONE1_richTextCtrl.Properties.Resources.RIGHT;
            this.tsbtnRTL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRTL.Name = "tsbtnRTL";
            this.tsbtnRTL.Size = new System.Drawing.Size(29, 24);
            this.tsbtnRTL.Text = "Right to Left";
            this.tsbtnRTL.Click += new System.EventHandler(this.tsbtnRTL_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 27);
            // 
            // extrBtn
            // 
            this.extrBtn.Image = ((System.Drawing.Image)(resources.GetObject("extrBtn.Image")));
            this.extrBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.extrBtn.Name = "extrBtn";
            this.extrBtn.Size = new System.Drawing.Size(88, 24);
            this.extrBtn.Text = "Extrabtn";
            this.extrBtn.Click += new System.EventHandler(this.extrBtn_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 30);
            // 
            // tscmbFont
            // 
            this.tscmbFont.Name = "tscmbFont";
            this.tscmbFont.Size = new System.Drawing.Size(121, 30);
            this.tscmbFont.SelectedIndexChanged += new System.EventHandler(this.tscmbFont_Click);
            // 
            // tscmbFontSize
            // 
            this.tscmbFontSize.AutoSize = false;
            this.tscmbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.tscmbFontSize.Name = "tscmbFontSize";
            this.tscmbFontSize.Size = new System.Drawing.Size(44, 28);
            this.tscmbFontSize.Click += new System.EventHandler(this.tscmbFontSize_Click);
            this.tscmbFontSize.TextChanged += new System.EventHandler(this.tscmbFontSize_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbtnBold
            // 
            this.tsbtnBold.CheckOnClick = true;
            this.tsbtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnBold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsbtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBold.Name = "tsbtnBold";
            this.tsbtnBold.Size = new System.Drawing.Size(29, 27);
            this.tsbtnBold.Text = "B";
            this.tsbtnBold.ToolTipText = "Toggle Bold";
            this.tsbtnBold.Click += new System.EventHandler(this.tsbtnBIU_Click);
            // 
            // tsbtnItalic
            // 
            this.tsbtnItalic.CheckOnClick = true;
            this.tsbtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnItalic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.tsbtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnItalic.Name = "tsbtnItalic";
            this.tsbtnItalic.Size = new System.Drawing.Size(29, 27);
            this.tsbtnItalic.Text = "I";
            this.tsbtnItalic.ToolTipText = "Toggle Italic";
            this.tsbtnItalic.Click += new System.EventHandler(this.tsbtnBIU_Click);
            // 
            // tsbtnUnderline
            // 
            this.tsbtnUnderline.CheckOnClick = true;
            this.tsbtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnUnderline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline);
            this.tsbtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUnderline.Name = "tsbtnUnderline";
            this.tsbtnUnderline.Size = new System.Drawing.Size(29, 27);
            this.tsbtnUnderline.Text = "U";
            this.tsbtnUnderline.ToolTipText = "Toggle Underline";
            this.tsbtnUnderline.Click += new System.EventHandler(this.tsbtnBIU_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 30);
            // 
            // tstxtZoomFactor
            // 
            this.tstxtZoomFactor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtZoomFactor.Name = "tstxtZoomFactor";
            this.tstxtZoomFactor.Size = new System.Drawing.Size(30, 30);
            this.tstxtZoomFactor.Leave += new System.EventHandler(this.tstxtZoomFactor_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSave,
            this.tsbtnOpen,
            this.toolStripSeparator6,
            this.tscmbFont,
            this.tscmbFontSize,
            this.tsbtnChooseFont,
            this.toolStripSeparator1,
            this.tsbtnBold,
            this.tsbtnItalic,
            this.tsbtnUnderline,
            this.toolStripSeparator2,
            this.tsbtnAlignLeft,
            this.tsbtnAlignCenter,
            this.tsbtnAlignRight,
            this.toolStripSeparator3,
            this.tsbtnFontColor,
            this.tsbtnWordWrap,
            this.toolStripSeparator4,
            this.tsbtnIndent,
            this.tsbtnOutdent,
            this.tsbtnBullets,
            this.toolStripSeparator5,
            this.tsbtnInsertPicture,
            this.toolStripSeparator7,
            this.tsbtnZoomIn,
            this.tsbtnZoomOut,
            this.tstxtZoomFactor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(885, 30);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(29, 27);
            this.tsbtnSave.Text = "toolStripButton1";
            this.tsbtnSave.ToolTipText = "Save Document";
            this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click_1);
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpen.Image")));
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(29, 27);
            this.tsbtnOpen.Text = "toolStripButton2";
            this.tsbtnOpen.ToolTipText = "Load Document";
            this.tsbtnOpen.Click += new System.EventHandler(this.tsbtnOpen_Click_1);
            // 
            // tsbtnChooseFont
            // 
            this.tsbtnChooseFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnChooseFont.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnChooseFont.Image")));
            this.tsbtnChooseFont.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnChooseFont.Name = "tsbtnChooseFont";
            this.tsbtnChooseFont.Size = new System.Drawing.Size(29, 27);
            this.tsbtnChooseFont.Text = "toolStripButton1";
            this.tsbtnChooseFont.ToolTipText = "Select Font";
            this.tsbtnChooseFont.Click += new System.EventHandler(this.tsbtnChooseFont_Click);
            // 
            // tsbtnAlignLeft
            // 
            this.tsbtnAlignLeft.CheckOnClick = true;
            this.tsbtnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlignLeft.Image")));
            this.tsbtnAlignLeft.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnAlignLeft.Name = "tsbtnAlignLeft";
            this.tsbtnAlignLeft.Size = new System.Drawing.Size(29, 27);
            this.tsbtnAlignLeft.Text = "toolStripButton1";
            this.tsbtnAlignLeft.ToolTipText = "Align Left";
            this.tsbtnAlignLeft.Click += new System.EventHandler(this.tsbtnAlignment_Click);
            // 
            // tsbtnAlignCenter
            // 
            this.tsbtnAlignCenter.CheckOnClick = true;
            this.tsbtnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlignCenter.Image")));
            this.tsbtnAlignCenter.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnAlignCenter.Name = "tsbtnAlignCenter";
            this.tsbtnAlignCenter.Size = new System.Drawing.Size(29, 27);
            this.tsbtnAlignCenter.Text = "toolStripButton2";
            this.tsbtnAlignCenter.ToolTipText = "Align Center";
            this.tsbtnAlignCenter.Click += new System.EventHandler(this.tsbtnAlignment_Click);
            // 
            // tsbtnAlignRight
            // 
            this.tsbtnAlignRight.CheckOnClick = true;
            this.tsbtnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlignRight.Image")));
            this.tsbtnAlignRight.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnAlignRight.Name = "tsbtnAlignRight";
            this.tsbtnAlignRight.Size = new System.Drawing.Size(29, 27);
            this.tsbtnAlignRight.Text = "toolStripButton3";
            this.tsbtnAlignRight.ToolTipText = "Align Right";
            this.tsbtnAlignRight.Click += new System.EventHandler(this.tsbtnAlignment_Click);
            // 
            // tsbtnFontColor
            // 
            this.tsbtnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFontColor.Image")));
            this.tsbtnFontColor.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnFontColor.Name = "tsbtnFontColor";
            this.tsbtnFontColor.Size = new System.Drawing.Size(29, 27);
            this.tsbtnFontColor.Text = "toolStripButton4";
            this.tsbtnFontColor.ToolTipText = "Pick Font Color";
            this.tsbtnFontColor.Click += new System.EventHandler(this.tsbtnFontColor_Click_1);
            // 
            // tsbtnWordWrap
            // 
            this.tsbtnWordWrap.CheckOnClick = true;
            this.tsbtnWordWrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnWordWrap.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnWordWrap.Image")));
            this.tsbtnWordWrap.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnWordWrap.Name = "tsbtnWordWrap";
            this.tsbtnWordWrap.Size = new System.Drawing.Size(29, 27);
            this.tsbtnWordWrap.Text = "toolStripButton1";
            this.tsbtnWordWrap.ToolTipText = "Word Wrap";
            this.tsbtnWordWrap.Click += new System.EventHandler(this.tsbtnWordWrap_Click_1);
            // 
            // tsbtnIndent
            // 
            this.tsbtnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnIndent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnIndent.Image")));
            this.tsbtnIndent.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnIndent.Name = "tsbtnIndent";
            this.tsbtnIndent.Size = new System.Drawing.Size(29, 27);
            this.tsbtnIndent.Text = "toolStripButton1";
            this.tsbtnIndent.ToolTipText = "Indent";
            this.tsbtnIndent.Click += new System.EventHandler(this.tsbtnBulletsAndNumbering_Click);
            // 
            // tsbtnOutdent
            // 
            this.tsbtnOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOutdent.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOutdent.Image")));
            this.tsbtnOutdent.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnOutdent.Name = "tsbtnOutdent";
            this.tsbtnOutdent.Size = new System.Drawing.Size(29, 27);
            this.tsbtnOutdent.Text = "toolStripButton3";
            this.tsbtnOutdent.ToolTipText = "Outdent";
            this.tsbtnOutdent.Click += new System.EventHandler(this.tsbtnBulletsAndNumbering_Click);
            // 
            // tsbtnBullets
            // 
            this.tsbtnBullets.CheckOnClick = true;
            this.tsbtnBullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnBullets.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBullets.Image")));
            this.tsbtnBullets.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnBullets.Name = "tsbtnBullets";
            this.tsbtnBullets.Size = new System.Drawing.Size(29, 27);
            this.tsbtnBullets.Text = "toolStripButton2";
            this.tsbtnBullets.ToolTipText = "Toggle Bullets";
            this.tsbtnBullets.Click += new System.EventHandler(this.tsbtnBulletsAndNumbering_Click);
            // 
            // tsbtnInsertPicture
            // 
            this.tsbtnInsertPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInsertPicture.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsertPicture.Image")));
            this.tsbtnInsertPicture.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbtnInsertPicture.Name = "tsbtnInsertPicture";
            this.tsbtnInsertPicture.Size = new System.Drawing.Size(29, 27);
            this.tsbtnInsertPicture.Text = "toolStripButton1";
            this.tsbtnInsertPicture.ToolTipText = "Insert Picture";
            this.tsbtnInsertPicture.Click += new System.EventHandler(this.tsbtnInsertPicture_Click_1);
            // 
            // tsbtnZoomIn
            // 
            this.tsbtnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnZoomIn.Image")));
            this.tsbtnZoomIn.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnZoomIn.Name = "tsbtnZoomIn";
            this.tsbtnZoomIn.Size = new System.Drawing.Size(29, 27);
            this.tsbtnZoomIn.Text = "toolStripButton1";
            this.tsbtnZoomIn.ToolTipText = "Zoom In";
            this.tsbtnZoomIn.Click += new System.EventHandler(this.tsbtnZoomIn_Click);
            // 
            // tsbtnZoomOut
            // 
            this.tsbtnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnZoomOut.Image")));
            this.tsbtnZoomOut.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbtnZoomOut.Name = "tsbtnZoomOut";
            this.tsbtnZoomOut.Size = new System.Drawing.Size(29, 27);
            this.tsbtnZoomOut.Text = "toolStripButton2";
            this.tsbtnZoomOut.ToolTipText = "Zoom Out";
            this.tsbtnZoomOut.Click += new System.EventHandler(this.tsbtnZoomOut_Click);
            // 
            // rtbDocument
            // 
            this.rtbDocument.AcceptsTab = true;
            this.rtbDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtbDocument.Location = new System.Drawing.Point(0, 57);
            this.rtbDocument.Name = "rtbDocument";
            this.rtbDocument.Size = new System.Drawing.Size(885, 521);
            this.rtbDocument.TabIndex = 12;
            this.rtbDocument.Text = "";
            this.rtbDocument.SelectionChanged += new System.EventHandler(this.rtbDocument_SelectionChanged);

            this.rtbDocument.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbDocument_Key_up);
            // 
            // NHunspellTextBoxExtender1
            // 
            this.NHunspellTextBoxExtender1.Language = "English";
            this.NHunspellTextBoxExtender1.MaintainUserChoice = true;
            this.NHunspellTextBoxExtender1.ShortcutKey = System.Windows.Forms.Shortcut.F7;
            this.NHunspellTextBoxExtender1.SpellAsYouType = true;
            // 
            // RichSpellCtrl
            // 
            this.Controls.Add(this.rtbDocument);
            this.Controls.Add(this.toolStripFindReplace);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RichSpellCtrl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(885, 578);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripFindReplace.ResumeLayout(false);
            this.toolStripFindReplace.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHunspellTextBoxExtender1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripFindReplace;
        private System.Windows.Forms.ToolStripTextBox tstxtSearchText;
        private System.Windows.Forms.ToolStripButton tsbtnFind;
        private System.Windows.Forms.ToolStripButton tsbtnReplace;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox tscmbFont;
        private System.Windows.Forms.ToolStripComboBox tscmbFontSize;
        private System.Windows.Forms.ToolStripButton tsbtnChooseFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnBold;
        private System.Windows.Forms.ToolStripButton tsbtnItalic;
        private System.Windows.Forms.ToolStripButton tsbtnUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnAlignLeft;
        private System.Windows.Forms.ToolStripButton tsbtnAlignCenter;
        private System.Windows.Forms.ToolStripButton tsbtnAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;

        private System.Windows.Forms.ToolStripButton tsbtnFontColor;
        private System.Windows.Forms.ToolStripButton tsbtnWordWrap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnIndent;
        private System.Windows.Forms.ToolStripButton tsbtnOutdent;
        private System.Windows.Forms.ToolStripButton tsbtnBullets;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnInsertPicture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbtnZoomIn;
        private System.Windows.Forms.ToolStripButton tsbtnZoomOut;
        private System.Windows.Forms.ToolStripTextBox tstxtZoomFactor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private ToolStripButton cutToolStripMenuItem;
        private ToolStripButton copyToolStripMenuItem;
        private ToolStripButton pasteToolStripMenuItem;
        private ToolStripButton selectAllToolStripMenuItem;
        private ToolStripButton undoToolStripMenuItem;
        private ToolStripButton redoToolStripMenuItem;
        private ToolStripButton deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator10;
        private RichTextBox rtbDocument;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton tsbtnLTR;
        private ToolStripButton tsbtnRTL;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripButton extrBtn;
        internal NHunspellTextBoxExtender NHunspellTextBoxExtender1;
    }
}