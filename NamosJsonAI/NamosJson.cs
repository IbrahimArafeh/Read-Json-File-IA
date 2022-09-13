using NamosJsonAI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NamosJsonAI
{
    public partial class NamosJson : MetroFramework.Forms.MetroForm
    {
        public NamosJson()
        {
            InitializeComponent();
            loadDataOnStart();
        }

        private void titleOpenJsonFile_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void btnBrowseJsonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string jsonFilePath = openFileDialog1.FileName;
                txtPathJsonFile.Text = jsonFilePath;
                Properties.Settings.Default.FilePath = jsonFilePath;
                Properties.Settings.Default.Save();
            }
        }
        private void loadDataOnStart()
        {
            txtPathJsonFile.Text = Properties.Settings.Default.FilePath;
        }

        private void btnUploadJsonFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPathJsonFile.Text))
            {
                try
                {
                    Process z = Process.Start(txtPathJsonFile.Text);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File Does not exist", "Not exsit", MessageBoxButtons.OK);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPathJsonFile.Text))
            {
                string sourceFile = txtPathJsonFile.Text;
                string destinationFile = txtPathJsonFile.Text + "_OldVersion.json";
                try
                {
                    File.Copy(sourceFile, destinationFile, true);
                    MessageBox.Show("Json file has Duplicated in the same path by adding OlDVserion in the end of name", "Duplicate File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                }
            }
            else
            {
                MessageBox.Show("There is no file please Add json file", "No file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPathJsonFile.Text))
            {
                string sourceFile = txtPathJsonFile.Text;
                string destinationFile = txtPathJsonFile.Text + "_OldVersion.json";
                try
                {
                    if (File.Exists(destinationFile))
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete new version and restore old one", "Restore File", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if(dialogResult == DialogResult.Yes)
                        {
                            File.Delete(sourceFile);
                            System.IO.File.Move(destinationFile, sourceFile);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please you have to duplicate the file before restore it", "Restore File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                       
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                }
            }
            else
            {
                MessageBox.Show("There is no file please Add json file", "No file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
