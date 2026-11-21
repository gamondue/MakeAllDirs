namespace LaunchAll
{
    partial class frmSostituzione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSostituzione));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.txtSostituisce = new System.Windows.Forms.TextBox();
            this.rdDovunque = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnSostituisci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stringa da cercare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stringa con cui sostituire";
            // 
            // txtCerca
            // 
            this.txtCerca.Location = new System.Drawing.Point(16, 30);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(489, 20);
            this.txtCerca.TabIndex = 2;
            // 
            // txtSostituisce
            // 
            this.txtSostituisce.Location = new System.Drawing.Point(16, 69);
            this.txtSostituisce.Name = "txtSostituisce";
            this.txtSostituisce.Size = new System.Drawing.Size(489, 20);
            this.txtSostituisce.TabIndex = 3;
            // 
            // rdDovunque
            // 
            this.rdDovunque.AutoSize = true;
            this.rdDovunque.Checked = true;
            this.rdDovunque.Location = new System.Drawing.Point(16, 95);
            this.rdDovunque.Name = "rdDovunque";
            this.rdDovunque.Size = new System.Drawing.Size(224, 17);
            this.rdDovunque.TabIndex = 4;
            this.rdDovunque.TabStop = true;
            this.rdDovunque.Text = "sostituisce dappertutto (case SenNsiTive!)";
            this.rdDovunque.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(16, 118);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(210, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "sostituisce solo nel riquadro selezionato";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(365, 106);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(66, 29);
            this.btnAnnulla.TabIndex = 6;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnSostituisci
            // 
            this.btnSostituisci.Location = new System.Drawing.Point(439, 106);
            this.btnSostituisci.Name = "btnSostituisci";
            this.btnSostituisci.Size = new System.Drawing.Size(66, 29);
            this.btnSostituisci.TabIndex = 7;
            this.btnSostituisci.Text = "Sostituisci";
            this.btnSostituisci.UseVisualStyleBackColor = true;
            this.btnSostituisci.Click += new System.EventHandler(this.btnSostituisci_Click);
            // 
            // frmSostituzione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(517, 148);
            this.Controls.Add(this.btnSostituisci);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdDovunque);
            this.Controls.Add(this.txtSostituisce);
            this.Controls.Add(this.txtCerca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSostituzione";
            this.Text = "Ricerca e sostituzione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.TextBox txtSostituisce;
        private System.Windows.Forms.RadioButton rdDovunque;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnSostituisci;
    }
}