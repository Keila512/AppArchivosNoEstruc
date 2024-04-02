using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace AppArchivosNoEstruc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpenTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogTXT = new OpenFileDialog();
            openFileDialogTXT.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialogTXT.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialogTXT.FileName);
                    rtbDataTxt.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex.Message);
                }
            }
        }
        private void btnOpenPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogPDF = new OpenFileDialog();
            openFileDialogPDF.Filter = "Files PDF (*.pdf)|*.pdf|All Files (*.*)|*.*";
            openFileDialogPDF.FilterIndex = 1;
            openFileDialogPDF.Multiselect = false;

            if (openFileDialogPDF.ShowDialog() == DialogResult.OK)
            {
                string filePathPDF = openFileDialogPDF.FileName;
                Process.Start(filePathPDF);
            }
        }
        private void btnOpenDOCX_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogDOCX = new OpenFileDialog();
            openFileDialogDOCX.Filter = "Files Word (*.doc;*.docx)|*.doc;*.docx|All Files (*.*)|*.*";
            openFileDialogDOCX.FilterIndex = 1;
            openFileDialogDOCX.Multiselect = false;

            if (openFileDialogDOCX.ShowDialog() == DialogResult.OK)
            {
                string filePathDOCX = openFileDialogDOCX.FileName;
                Process.Start(filePathDOCX);
            }
        }
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImage = new OpenFileDialog();
            openFileDialogImage.Filter = "Files Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";
            openFileDialogImage.Title = "Select Image";

            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                string pathImage = openFileDialogImage.FileName;
                try
                {
                    Bitmap image = new Bitmap(pathImage);
                    pictureBoxImage.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnOpenWEBSITE_Click(object sender, EventArgs e)
        {
            // URL of the webpage you want to open
            string url = "https://mexico-u.talento-cloud.com/#/";
            System.Diagnostics.Process.Start(url);
            Application.Exit();
        }
    }
}
