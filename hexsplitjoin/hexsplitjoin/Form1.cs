using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace hexsplitjoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            configurationDataSet1.Clear();

            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                configurationDataSet1.ReadXml(sr);
            }
        }

        private void saveConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
            {
                configurationDataSet1.WriteXml(sw);
            }
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ConfigurationDataSet.ConfigurationRow confRow in configurationDataSet1.Configuration.Rows)
            {
                int srcStartAddress = int.Parse(confRow.SourceStartAddress, NumberStyles.HexNumber);
                int srcEndAddress = int.Parse(confRow.SourceEndAddress, NumberStyles.HexNumber);
                int dstStartAddress = int.Parse(confRow.DestinationStartAddress, NumberStyles.HexNumber);
                HexHelper.Copy(confRow.SourceFilePath, confRow.DestinationFilePath, srcStartAddress, srcEndAddress, dstStartAddress);
            }

            MessageBox.Show("Data was moved", this.Text, MessageBoxButtons.OK);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configurationDataSet1.Clear();
        }

        private void defaultSourcetoolStripLabel1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;

            defaultSourcePath.Text = openFileDialog2.FileName;
        }

        private void defaultDestinationtoolStripLabel2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;

            defaultDestinationPath.Text = saveFileDialog2.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void ConfigurationbindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            configurationDataSet1.Configuration.SourceFilePathColumn.DefaultValue = defaultSourcePath.Text;
            configurationDataSet1.Configuration.DestinationFilePathColumn.DefaultValue = defaultDestinationPath.Text;
        }
    }
}
