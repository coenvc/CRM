using System.Windows.Forms;

namespace Test
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSortSalary = new System.Windows.Forms.Button();
            this.GoToBackend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(368, 251);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(195, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 29);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Exporteer";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(298, 7);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(85, 29);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Importeer";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSortSalary
            // 
            this.btnSortSalary.Location = new System.Drawing.Point(101, 7);
            this.btnSortSalary.Name = "btnSortSalary";
            this.btnSortSalary.Size = new System.Drawing.Size(88, 29);
            this.btnSortSalary.TabIndex = 13;
            this.btnSortSalary.Text = "Sorteer Salaris";
            this.btnSortSalary.UseVisualStyleBackColor = true;
            this.btnSortSalary.Click += new System.EventHandler(this.btnSortSalary_Click);
            // 
            // GoToBackend
            // 
            this.GoToBackend.Location = new System.Drawing.Point(12, 7);
            this.GoToBackend.Name = "GoToBackend";
            this.GoToBackend.Size = new System.Drawing.Size(83, 29);
            this.GoToBackend.TabIndex = 14;
            this.GoToBackend.Text = "Backend";
            this.GoToBackend.UseVisualStyleBackColor = true;
            this.GoToBackend.Click += new System.EventHandler(this.GoToBackend_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 320);
            this.Controls.Add(this.GoToBackend);
            this.Controls.Add(this.btnSortSalary);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.listBox1);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSortSalary;
        private Button GoToBackend;
    }
}

