namespace Test.GUI_s
{
    partial class Backend
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
            this.cbBetaald = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbSirName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.rtbAboutMe = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnProfilePic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbBetaald
            // 
            this.cbBetaald.AutoSize = true;
            this.cbBetaald.Location = new System.Drawing.Point(310, 88);
            this.cbBetaald.Name = "cbBetaald";
            this.cbBetaald.Size = new System.Drawing.Size(37, 17);
            this.cbBetaald.TabIndex = 24;
            this.cbBetaald.Text = "Ja";
            this.cbBetaald.UseVisualStyleBackColor = true;
            this.cbBetaald.CheckedChanged += new System.EventHandler(this.cbBetaald_CheckedChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(130, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Betaald";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 297);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 29);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "voeg toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Afdeling";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Achternaam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Voornaam";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 15;
            // 
            // tbSirName
            // 
            this.tbSirName.Location = new System.Drawing.Point(130, 33);
            this.tbSirName.Name = "tbSirName";
            this.tbSirName.Size = new System.Drawing.Size(174, 20);
            this.tbSirName.TabIndex = 14;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(130, 6);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(174, 20);
            this.tbFirstName.TabIndex = 13;
            // 
            // rtbAboutMe
            // 
            this.rtbAboutMe.Location = new System.Drawing.Point(27, 155);
            this.rtbAboutMe.Name = "rtbAboutMe";
            this.rtbAboutMe.Size = new System.Drawing.Size(284, 131);
            this.rtbAboutMe.TabIndex = 25;
            this.rtbAboutMe.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Over jezelf";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 9);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(34, 23);
            this.btnTerug.TabIndex = 27;
            this.btnTerug.Text = "<--";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnProfilePic
            // 
            this.btnProfilePic.Location = new System.Drawing.Point(169, 297);
            this.btnProfilePic.Name = "btnProfilePic";
            this.btnProfilePic.Size = new System.Drawing.Size(142, 29);
            this.btnProfilePic.TabIndex = 28;
            this.btnProfilePic.Text = "Profielfoto";
            this.btnProfilePic.UseVisualStyleBackColor = true;
            this.btnProfilePic.Click += new System.EventHandler(this.btnProfilePic_Click);
            // 
            // Backend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 338);
            this.Controls.Add(this.btnProfilePic);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbAboutMe);
            this.Controls.Add(this.cbBetaald);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbSirName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "Backend";
            this.Text = "Backend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbBetaald;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbSirName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.RichTextBox rtbAboutMe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnProfilePic;
    }
}