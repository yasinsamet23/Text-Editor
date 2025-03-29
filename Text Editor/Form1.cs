using System.Security.Principal;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class Text_Editor : Form
    {


        public Text_Editor()
        {
            InitializeComponent();

        }


        private void OpenFile()
        {
            openFileDialog1.Filter = "Text File | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void SaveFile()
        {
            saveFileDialog1.Filter = "Text Files | *.txt | All Files | *.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtEditor.Text);
            }
        }



        private void newMenu_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();



        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            OpenFile();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutMenu_Click(object sender, EventArgs e)
        {
            txtEditor.Cut();
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            //string wordstext = txtEditor.Text.TrimEnd();
            //string[] words = wordstext.Split(" ");
            //lblWordCount.Text = "Word Count : " + words.Length.ToString();

            string[] words = txtEditor.Text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            lblWordCount.Text = "Word Count : " + words.Length.ToString();
        }

        private void copyMenu_Click(object sender, EventArgs e)
        {
            txtEditor.Copy();
        }

        private void pasteMenu_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void fontMenu_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Font = fontDialog1.Font;
            }
        }

        private void textColorMenu_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEditor.ForeColor = colorDialog1.Color;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string texttoprrint = txtEditor.Text;
            Font font = txtEditor.Font;
            Brush brush = Brushes.Black;
            e.Graphics.DrawString(texttoprrint, font, brush, 50, 50);
        }



        private void printMenu_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printMenu_Click(sender, e);
        }

        
    }
}
