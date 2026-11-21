using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LaunchAll
{
    public partial class frmSostituzione : Form
    {
        string nomeEPath;
        private ToolTip toolTipControlli;

        public frmSostituzione(string NomeEPath)
        {
            InitializeComponent();
            InizializzaToolTipControlli();
            nomeEPath = NomeEPath;
        }

        private void InizializzaToolTipControlli()
        {
            if (toolTipControlli != null)
                return;

            toolTipControlli = new ToolTip(components);
            toolTipControlli.AutoPopDelay = 10000;
            toolTipControlli.InitialDelay = 250;
            toolTipControlli.ReshowDelay = 100;
            toolTipControlli.ShowAlways = true;

            toolTipControlli.SetToolTip(txtCerca, "Stringa da cercare nel file.");
            toolTipControlli.SetToolTip(txtSostituisce, "Stringa da usare in sostituzione.");
            toolTipControlli.SetToolTip(rdDovunque, "Sostituisce tutte le occorrenze della stringa cercata.");
            toolTipControlli.SetToolTip(radioButton1, "Opzione non disponibile in questa versione.");
            toolTipControlli.SetToolTip(btnSostituisci, "Esegue la sostituzione nel file selezionato.");
            toolTipControlli.SetToolTip(btnAnnulla, "Chiude la finestra senza applicare modifiche.");
        }

        private void btnSostituisci_Click(object sender, EventArgs e)
        {
            //string fileContent = gamon.FileDiTesto.FileInStringa(nomeEPath);
            //fileContent.Replace(txtCerca.Text, txtSostituisce.Text);
            //gamon.FileDiTesto.StringaInFile(nomeEPath,fileContent,false);

            Encoding fileEncoding = Encoding.Default;
            FileStream fs = new FileStream(nomeEPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fs, fileEncoding, true);

            string tuttoIlfile = sr.ReadToEnd(); 
            sr.Close();
            
            fs = new FileStream(nomeEPath, FileMode.Open, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs, fileEncoding);

            sw.Write(tuttoIlfile.Replace(txtCerca.Text, txtSostituisce.Text)); 
            sw.Close();

            this.Hide();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
