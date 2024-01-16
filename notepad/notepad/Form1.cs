using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog var = new OpenFileDialog();
            var.Title = "Open";
            var.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (var.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(var.FileName,
            RichTextBoxStreamType.PlainText);
            this.Text = var.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog var = new SaveFileDialog();
            var.Title = "Save";
            var.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (var.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(var.FileName,
            RichTextBoxStreamType.PlainText);
            this.Text = var.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = richTextBox1.SelectionFont;
            dlg.Color = richTextBox1.SelectionColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
            richTextBox1.SelectionFont = dlg.Font;
            richTextBox1.SelectionColor = dlg.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = richTextBox1.SelectionColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = dlg.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {}

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.DocumentName = "My Document";
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
                printDocument.Print();
            }
        }
       }
}

