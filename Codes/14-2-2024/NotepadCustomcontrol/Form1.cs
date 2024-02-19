using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadCustomcontrol
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
            OpenFileDialog  x=new OpenFileDialog();
            x.Title = "Open";
            x.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if(x.ShowDialog() == DialogResult.OK)
            {
                    richTextBox1.LoadFile(x.FileName,RichTextBoxStreamType.PlainText);
                    
            }
            this.Text = x.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog y = new SaveFileDialog();
            y.Title = "Save";
            y.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (y.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(y.FileName, RichTextBoxStreamType.PlainText);
               
            }
            this.Text = y.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
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

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt=new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font= fnt.Font;
             }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = fnt.Color;
            }
        }

        
    }
}
