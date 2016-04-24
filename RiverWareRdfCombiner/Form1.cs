using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RiverWareRdfCombiner
{
    public partial class Form1 : Form
    {
        public string rdf1 = "";
        public string rdf2 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void rdf1Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "RiverWare RDF (*.rdf)|*.rdf";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                this.rdfSelected1.Text = choofdlog.FileName;
            }
        }

        private void rdf2Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "RiverWare RDF (*.rdf)|*.rdf";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            DialogResult result = choofdlog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                this.rdfSelected2.Text = choofdlog.FileName;
            }
        }
                
        private void combineButton_Click(object sender, EventArgs e)
        {
            var newRDF = new List<string>();
            // Copy RDF1
            foreach (string line in File.ReadLines(this.rdfSelected1.Text, Encoding.UTF8))
            { newRDF.Add(line); }
            // Get RDF1 number_of_runs
            var nRuns1Line = newRDF.Find(item => item.Contains("number_of_runs:"));
            int nRuns1LineIdx = newRDF.IndexOf(nRuns1Line);
            int nRunsRdf1 = Convert.ToInt16(nRuns1Line.Split(':')[1]);
            // Append RDF2
            bool pkgPreambleSwitch = false;
            int nRunsRdf2 = 0;
            foreach (string line in File.ReadLines(this.rdfSelected2.Text, Encoding.UTF8))
            {
                // Get RDF2 number_of_runs
                if (line.Contains("number_of_runs:"))
                { nRunsRdf2 = Convert.ToInt16(line.Split(':')[1]); }
                if (pkgPreambleSwitch)
                { newRDF.Add(line); }
                if (line == "END_PACKAGE_PREAMBLE")
                { pkgPreambleSwitch = true; }
            }
            // Increment number_of_runs
            newRDF[nRuns1LineIdx] = "number_of_runs:" + (nRunsRdf1 + nRunsRdf2).ToString("F0");
            // Save New RDF
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "CombinedRDF.rdf";
            savefile.Filter = "RiverWare RDF (*.rdf)|*.rdf";
            if (savefile.ShowDialog() == DialogResult.OK)
            { File.WriteAllLines(savefile.FileName, newRDF.ToArray()); }
        }
        
    }
}
