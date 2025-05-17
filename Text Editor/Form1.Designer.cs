namespace Text_Editor
{
    partial class Text_Editor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Text_Editor));
            menuStrip1 = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            newMenu = new ToolStripMenuItem();
            openMenu = new ToolStripMenuItem();
            saveMenu = new ToolStripMenuItem();
            printMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitMenu = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            cutMenu = new ToolStripMenuItem();
            copyMenu = new ToolStripMenuItem();
            pasteMenu = new ToolStripMenuItem();
            formatMenu = new ToolStripMenuItem();
            fontMenu = new ToolStripMenuItem();
            textColorMenu = new ToolStripMenuItem();
            txtEditor = new TextBox();
            statusStrip1 = new StatusStrip();
            lblWordCount = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            openButton = new ToolStripButton();
            saveButton = new ToolStripButton();
            printButton = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, formatMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(568, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newMenu, openMenu, saveMenu, printMenu, toolStripSeparator1, exitMenu });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(46, 24);
            fileMenu.Text = "File";
            // 
            // newMenu
            // 
            newMenu.Name = "newMenu";
            newMenu.Size = new Size(128, 26);
            newMenu.Text = "New";
            newMenu.Click += newMenu_Click;
            // 
            // openMenu
            // 
            openMenu.Name = "openMenu";
            openMenu.Size = new Size(128, 26);
            openMenu.Text = "Open";
            openMenu.Click += openMenu_Click;
            // 
            // saveMenu
            // 
            saveMenu.Name = "saveMenu";
            saveMenu.Size = new Size(128, 26);
            saveMenu.Text = "Save";
            saveMenu.Click += saveMenu_Click;
            // 
            // printMenu
            // 
            printMenu.Name = "printMenu";
            printMenu.Size = new Size(128, 26);
            printMenu.Text = "Print";
            printMenu.Click += printMenu_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);
            // 
            // exitMenu
            // 
            exitMenu.Name = "exitMenu";
            exitMenu.Size = new Size(128, 26);
            exitMenu.Text = "Exit";
            exitMenu.Click += exitMenu_Click;
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { cutMenu, copyMenu, pasteMenu });
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(49, 24);
            editMenu.Text = "Edit";
            // 
            // cutMenu
            // 
            cutMenu.Name = "cutMenu";
            cutMenu.Size = new Size(224, 26);
            cutMenu.Text = "Cut";
            cutMenu.Click += cutMenu_Click;
            // 
            // copyMenu
            // 
            copyMenu.Name = "copyMenu";
            copyMenu.Size = new Size(224, 26);
            copyMenu.Text = "Copy";
            copyMenu.Click += copyMenu_Click;
            // 
            // pasteMenu
            // 
            pasteMenu.Name = "pasteMenu";
            pasteMenu.Size = new Size(224, 26);
            pasteMenu.Text = "Paste";
            pasteMenu.Click += pasteMenu_Click;
            // 
            // formatMenu
            // 
            formatMenu.DropDownItems.AddRange(new ToolStripItem[] { fontMenu, textColorMenu });
            formatMenu.Name = "formatMenu";
            formatMenu.Size = new Size(70, 24);
            formatMenu.Text = "Format";
            // 
            // fontMenu
            // 
            fontMenu.Name = "fontMenu";
            fontMenu.Size = new Size(224, 26);
            fontMenu.Text = "Font";
            fontMenu.Click += fontMenu_Click;
            // 
            // textColorMenu
            // 
            textColorMenu.Name = "textColorMenu";
            textColorMenu.Size = new Size(224, 26);
            textColorMenu.Text = "Text  Color";
            textColorMenu.Click += textColorMenu_Click;
            // 
            // txtEditor
            // 
            txtEditor.Location = new Point(0, 58);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.Size = new Size(544, 344);
            txtEditor.TabIndex = 1;
            txtEditor.TextChanged += txtEditor_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblWordCount });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(568, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            
            // 
            // lblWordCount
            // 
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(0, 18);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { openButton, saveButton, printButton });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(568, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // openButton
            // 
            openButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openButton.Image = (Image)resources.GetObject("openButton.Image");
            openButton.ImageTransparentColor = Color.Magenta;
            openButton.Name = "openButton";
            openButton.Size = new Size(49, 24);
            openButton.Text = "Open";
            openButton.Click += openButton_Click;
            // 
            // saveButton
            // 
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveButton.Image = (Image)resources.GetObject("saveButton.Image");
            saveButton.ImageTransparentColor = Color.Magenta;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(44, 24);
            saveButton.Text = "Save";
            saveButton.Click += saveButton_Click;
            // 
            // printButton
            // 
            printButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            printButton.Image = (Image)resources.GetObject("printButton.Image");
            printButton.ImageTransparentColor = Color.Magenta;
            printButton.Name = "printButton";
            printButton.Size = new Size(43, 24);
            printButton.Text = "Print";
            printButton.Click += printButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Text_Editor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(txtEditor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Text_Editor";
            Text = "Text Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem formatMenu;
        private ToolStripMenuItem newMenu;
        private ToolStripMenuItem openMenu;
        private ToolStripMenuItem saveMenu;
        private ToolStripMenuItem printMenu;
        private ToolStripMenuItem exitMenu;
        private ToolStripMenuItem cutMenu;
        private ToolStripMenuItem copyMenu;
        private ToolStripMenuItem pasteMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fontMenu;
        private ToolStripMenuItem textColorMenu;
        private TextBox txtEditor;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton openButton;
        private ToolStripButton saveButton;
        private ToolStripButton printButton;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ToolStripStatusLabel lblWordCount;
    }
}
