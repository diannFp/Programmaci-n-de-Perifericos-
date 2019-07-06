using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO.Ports;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace portada_UPT
{
    public partial class PRINCIPAL : Form
    {

        public PRINCIPAL()
        {
            InitializeComponent();

        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AcercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Acerca_de acerca_D = new Acerca_de();
            acerca_D.ShowDialog();
        }

        private void PRINCIPAL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, " desea terminar la aplicación?", "Mi aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, " desea terminar la aplicación?", "Mi aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        string elArchivo = "name.txt";
        private void AbrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (richTextBox1.Modified)
                {


                    if (MessageBox.Show("Desea guardar los cambios", "atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SaveFileDialog saveFile1 = new SaveFileDialog();
                        saveFile1.DefaultExt = "*.rtf";
                        saveFile1.Filter = "RTF Files|*.rtf|HTML Files|*.html|Text Files|*.txt";
                        if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                           saveFile1.FileName.Length > 0)
                        {
                            richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                        }
                        richTextBox1.Clear();
                    }
                    else if (DialogResult == DialogResult.No)
                    {
                        richTextBox1.Clear();
                    }

                }
            }
            richTextBox1.Clear();

        }


        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ubicacion = elArchivo;
            File.WriteAllText(ubicacion, richTextBox1.Text);

        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf|HTML Files|*.html|Text Files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0) ;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = narchivo;
        }
    }
}
