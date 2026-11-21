namespace gamon
{
    partial class frmAbout
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            panel1 = new Panel();
            lblPaese = new Label();
            lblEMail = new Label();
            label2 = new Label();
            lblAutore = new Label();
            lblCittà = new Label();
            lblData = new Label();
            lblProgramTitle = new Label();
            lblVersione = new Label();
            lblProgramDescription = new Label();
            pictureBox1 = new PictureBox();
            ToolTip1 = new ToolTip(components);
            Timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblPaese);
            panel1.Controls.Add(lblEMail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblAutore);
            panel1.Controls.Add(lblCittà);
            panel1.Controls.Add(lblData);
            panel1.Controls.Add(lblProgramTitle);
            panel1.Controls.Add(lblVersione);
            panel1.Controls.Add(lblProgramDescription);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 360);
            panel1.TabIndex = 25;
            // 
            // lblPaese
            // 
            lblPaese.BackColor = Color.White;
            lblPaese.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaese.ForeColor = Color.Black;
            lblPaese.Location = new Point(253, 288);
            lblPaese.Margin = new Padding(4, 0, 4, 0);
            lblPaese.Name = "lblPaese";
            lblPaese.RightToLeft = RightToLeft.No;
            lblPaese.Size = new Size(372, 24);
            lblPaese.TabIndex = 27;
            lblPaese.Text = "ITALIA";
            lblPaese.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblEMail
            // 
            lblEMail.BackColor = Color.White;
            lblEMail.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEMail.ForeColor = Color.Black;
            lblEMail.Location = new Point(253, 323);
            lblEMail.Margin = new Padding(4, 0, 4, 0);
            lblEMail.Name = "lblEMail";
            lblEMail.RightToLeft = RightToLeft.No;
            lblEMail.Size = new Size(372, 28);
            lblEMail.TabIndex = 26;
            lblEMail.Text = "ing@ingmonti.it";
            lblEMail.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(5, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(624, 44);
            label2.TabIndex = 25;
            label2.Text = "Questo programma è gratuito. L'Autore non fornisce alcuna forma di garanzia, nè di funzionalità, nè di rispondenza alle esigenze dell'utente.  ";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAutore
            // 
            lblAutore.BackColor = Color.White;
            lblAutore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutore.ForeColor = Color.Black;
            lblAutore.Location = new Point(253, 216);
            lblAutore.Margin = new Padding(4, 0, 4, 0);
            lblAutore.Name = "lblAutore";
            lblAutore.RightToLeft = RightToLeft.No;
            lblAutore.Size = new Size(372, 28);
            lblAutore.TabIndex = 23;
            lblAutore.Text = "Ing. Gabriele MONTI";
            lblAutore.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCittà
            // 
            lblCittà.BackColor = Color.White;
            lblCittà.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCittà.ForeColor = Color.Black;
            lblCittà.Location = new Point(253, 254);
            lblCittà.Margin = new Padding(4, 0, 4, 0);
            lblCittà.Name = "lblCittà";
            lblCittà.RightToLeft = RightToLeft.No;
            lblCittà.Size = new Size(372, 24);
            lblCittà.TabIndex = 21;
            lblCittà.Text = "Forlì";
            lblCittà.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblData
            // 
            lblData.BackColor = Color.White;
            lblData.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.ForeColor = Color.Black;
            lblData.Location = new Point(253, 193);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.RightToLeft = RightToLeft.No;
            lblData.Size = new Size(372, 23);
            lblData.TabIndex = 16;
            lblData.Text = "lblData";
            lblData.TextAlign = ContentAlignment.TopCenter;
            lblData.Visible = false;
            // 
            // lblProgramTitle
            // 
            lblProgramTitle.BackColor = Color.White;
            lblProgramTitle.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgramTitle.ForeColor = Color.Black;
            lblProgramTitle.Location = new Point(253, 69);
            lblProgramTitle.Margin = new Padding(4, 0, 4, 0);
            lblProgramTitle.Name = "lblProgramTitle";
            lblProgramTitle.RightToLeft = RightToLeft.No;
            lblProgramTitle.Size = new Size(376, 44);
            lblProgramTitle.TabIndex = 17;
            lblProgramTitle.Text = "lblAssemblyTitle";
            lblProgramTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVersione
            // 
            lblVersione.BackColor = Color.White;
            lblVersione.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersione.ForeColor = Color.Black;
            lblVersione.Location = new Point(253, 159);
            lblVersione.Margin = new Padding(4, 0, 4, 0);
            lblVersione.Name = "lblVersione";
            lblVersione.RightToLeft = RightToLeft.No;
            lblVersione.Size = new Size(372, 33);
            lblVersione.TabIndex = 11;
            lblVersione.Text = "Versione ";
            lblVersione.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblProgramDescription
            // 
            lblProgramDescription.BackColor = Color.White;
            lblProgramDescription.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgramDescription.ForeColor = Color.Black;
            lblProgramDescription.Location = new Point(253, 113);
            lblProgramDescription.Margin = new Padding(4, 0, 4, 0);
            lblProgramDescription.Name = "lblProgramDescription";
            lblProgramDescription.RightToLeft = RightToLeft.No;
            lblProgramDescription.Size = new Size(372, 46);
            lblProgramDescription.TabIndex = 10;
            lblProgramDescription.Text = "lblAssemblyDescription";
            lblProgramDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 13);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 294);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 2000;
            Timer1.Tick += Timer1_Tick;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 363);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblPaese;
        public System.Windows.Forms.Label lblEMail;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblAutore;
        public System.Windows.Forms.Label lblCittà;
        public System.Windows.Forms.Label lblData;
        public System.Windows.Forms.Label lblProgramTitle;
        public System.Windows.Forms.Label lblVersione;
        public System.Windows.Forms.Label lblProgramDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Timer Timer1;
    }
}