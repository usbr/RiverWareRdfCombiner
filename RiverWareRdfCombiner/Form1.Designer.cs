namespace RiverWareRdfCombiner
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.rdf1Button = new System.Windows.Forms.Button();
            this.rdf2Button = new System.Windows.Forms.Button();
            this.rdfSelected1 = new System.Windows.Forms.TextBox();
            this.rdfSelected2 = new System.Windows.Forms.TextBox();
            this.combineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // rdf1Button
            // 
            this.rdf1Button.Location = new System.Drawing.Point(4, 134);
            this.rdf1Button.Name = "rdf1Button";
            this.rdf1Button.Size = new System.Drawing.Size(91, 20);
            this.rdf1Button.TabIndex = 0;
            this.rdf1Button.Text = "Select RDF 1";
            this.rdf1Button.UseVisualStyleBackColor = true;
            this.rdf1Button.Click += new System.EventHandler(this.rdf1Button_Click);
            // 
            // rdf2Button
            // 
            this.rdf2Button.Location = new System.Drawing.Point(4, 160);
            this.rdf2Button.Name = "rdf2Button";
            this.rdf2Button.Size = new System.Drawing.Size(91, 20);
            this.rdf2Button.TabIndex = 1;
            this.rdf2Button.Text = "Select RDF 2";
            this.rdf2Button.UseVisualStyleBackColor = true;
            this.rdf2Button.Click += new System.EventHandler(this.rdf2Button_Click);
            // 
            // rdfSelected1
            // 
            this.rdfSelected1.Location = new System.Drawing.Point(101, 134);
            this.rdfSelected1.Name = "rdfSelected1";
            this.rdfSelected1.Size = new System.Drawing.Size(390, 20);
            this.rdfSelected1.TabIndex = 2;
            // 
            // rdfSelected2
            // 
            this.rdfSelected2.Location = new System.Drawing.Point(101, 160);
            this.rdfSelected2.Name = "rdfSelected2";
            this.rdfSelected2.Size = new System.Drawing.Size(390, 20);
            this.rdfSelected2.TabIndex = 3;
            // 
            // combineButton
            // 
            this.combineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combineButton.Location = new System.Drawing.Point(405, 186);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(86, 32);
            this.combineButton.TabIndex = 4;
            this.combineButton.Text = "Combine";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.combineButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "This program combines RiverWare RDF files. Data from the selected RDF 2 as shown " +
    "below is ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "appended to the selected RDF 1. The run name, owner, description, and create data" +
    " from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "RDF 1 is preserved and the number of runs is incremented by the number of runs in" +
    " RDF 2. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(499, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clicking on Combine will prompt you to choose a name and directory in which to cr" +
    "eate the new RDF file.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(462, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "It is important to note that most software that read RiverWare MRM RDFs assume th" +
    "at all entries ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(455, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "within an RDF have constant run dates and time steps. Combining RDFs that have di" +
    "fferent run";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "dates and time steps will result in improper processing by these software.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 222);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.rdfSelected2);
            this.Controls.Add(this.rdfSelected1);
            this.Controls.Add(this.rdf2Button);
            this.Controls.Add(this.rdf1Button);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RiverWare RDF Combiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button rdf1Button;
        private System.Windows.Forms.Button rdf2Button;
        private System.Windows.Forms.TextBox rdfSelected1;
        private System.Windows.Forms.TextBox rdfSelected2;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

