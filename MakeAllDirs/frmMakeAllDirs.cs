using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using gamon;

namespace LaunchAll
{
    public partial class frmMakeAllDirs : Form
    {
        private string fileConfigurazioneIniziale = "";
        private ToolTip toolTipControlli;
        private string ultimaRicercaNodi = "";

        string versione = "V." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public frmMakeAllDirs()
        {
            InitializeComponent();
            InizializzaToolTipControlli();
        }

        public frmMakeAllDirs(string FileConfigurazione)
        {
            InitializeComponent();
            InizializzaToolTipControlli();
            fileConfigurazioneIniziale = FileConfigurazione;
        }

        public frmMakeAllDirs(string FileConfigurazione, string PathCopia)
        {
            InitializeComponent();
            InizializzaToolTipControlli();
            txtRootDir.Text = Path.GetDirectoryName(FileConfigurazione) ?? "";
            txtCartellaCopia.Text = PathCopia;
            fileConfigurazioneIniziale = FileConfigurazione.Replace(".lall", ".mall");
        }

        private void frmMakeAllDirs_Load(object sender, EventArgs e)
        {
            this.Text += " " + versione;

            gamon.frmAbout f = new gamon.frmAbout();
            f.Visible = false;
            f.ShowDialog();

            AssicuraCartellaConfigurazioneDefault();

            txtFileConfigurazione.Text = fileConfigurazioneIniziale;
            ForzaAbilitazioneBottoni(LeggiFile(txtFileConfigurazione.Text, true));

            try
            {
                txtDiscoNuovo.Text = Path.GetPathRoot(txtFileConfigurazione.Text) ?? "";
                txtDiscoVecchio.Text = Path.GetPathRoot(txtRootDir.Text) ?? "";
            }
            catch { }

        }

        private string RicavaCartellaConfigurazioneDefault()
        {
            string cartellaDocumenti = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(cartellaDocumenti, "MakeAllDirs");
        }

        private string RicavaCartellaDialogoConfigurazione()
        {
            string? cartellaDaTesto = Path.GetDirectoryName(txtFileConfigurazione.Text);
            if (!string.IsNullOrWhiteSpace(cartellaDaTesto))
                return cartellaDaTesto;

            return RicavaCartellaConfigurazioneDefault();
        }

        private void AssicuraCartellaConfigurazioneDefault()
        {
            Directory.CreateDirectory(RicavaCartellaConfigurazioneDefault());
        }

        private void InizializzaToolTipControlli()
        {
            if (toolTipControlli != null)
                return;

            toolTipControlli = new ToolTip();
            toolTipControlli.AutoPopDelay = 10000;
            toolTipControlli.InitialDelay = 250;
            toolTipControlli.ReshowDelay = 100;
            toolTipControlli.ShowAlways = true;

            ApplicaToolTipRicorsivo(this);
        }

        private void ApplicaToolTipRicorsivo(Control contenitore)
        {
            foreach (Control controllo in contenitore.Controls)
            {
                if (EControlloInterattivo(controllo))
                {
                    string tooltip = RecuperaToolTip(controllo);
                    if (tooltip != "")
                        toolTipControlli.SetToolTip(controllo, tooltip);
                }

                if (controllo.HasChildren)
                    ApplicaToolTipRicorsivo(controllo);
            }
        }

        private bool EControlloInterattivo(Control controllo)
        {
            return controllo is Button ||
                   controllo is TextBox ||
                   controllo is ListView ||
                   controllo is TreeView ||
                   controllo is CheckBox ||
                   controllo is RadioButton ||
                   controllo is ComboBox ||
                   controllo is DateTimePicker ||
                   controllo is NumericUpDown ||
                   controllo is LinkLabel;
        }

        private string RecuperaToolTip(Control controllo)
        {
            string tooltipSpecifico = RecuperaToolTipSpecifico(controllo.Name);
            if (tooltipSpecifico != "")
                return tooltipSpecifico;

            return RecuperaToolTipGenerico(controllo);
        }

        private string RecuperaToolTipSpecifico(string nomeControllo)
        {
            switch (nomeControllo)
            {
                case "txtRootDir": return "Cartella base dove creare la struttura e copiare i file.";
                case "txtCartellaCopia": return "Cartella sorgente da cui leggere i file da copiare.";
                case "txtFileConfigurazione": return "Percorso del file di configurazione (.mall).";
                case "txtNuova": return "Nome della nuova cartella da aggiungere all'albero.";
                case "txtPathDestinazione": return "Cartella di destinazione dei file che verranno aggiunti, scelta con 'Scegli cartella'. Se vuota, ogni file va nella stessa sottocartella in cui si trova rispetto alla cartella di origine. Doppio clic per aprirla.";
                case "btnApplicaDestinazione": return "Assegna alle righe selezionate la cartella di destinazione corrente (quella scelta, o la cartella d'origine di ogni file se non ne è scelta nessuna).";
                case "btnCartellaOutDefault": return "Svuota la cartella scelta: i file aggiunti in seguito verranno copiati nella stessa sottocartella in cui si trovano rispetto alla cartella di origine.";
                case "txtStringaDa": return "Testo da cercare nei nomi file durante la copia.";
                case "txtStringaA": return "Testo sostitutivo per la prima regola di rinomina.";
                case "txtStringa2Da": return "Secondo testo da cercare nei nomi file.";
                case "txtStringa2A": return "Secondo testo sostitutivo nei nomi file.";
                case "txtDiscoVecchio": return "Unità/disco attuale da sostituire nei percorsi.";
                case "txtDiscoNuovo": return "Nuova unità/disco da applicare ai percorsi.";
                case "trwCartelleDaCreare": return "Albero delle cartelle da creare: seleziona, modifica, abilita/disabilita i nodi.";
                case "lstvwFileDaCopiare": return "Elenco file da copiare. Seleziona, spunta e assegna la cartella di destinazione.";
                case "btnCreaECopia": return "Crea le cartelle e copia subito i file selezionati.";
                case "btnCreaCartelle": return "Crea su disco le cartelle selezionate nell'albero.";
                case "btnCopia": return "Copia i file selezionati nelle cartelle di destinazione.";
                case "btnCopiaStruttura": return "Importa la struttura di sottocartelle da una cartella modello.";
                case "btnPiuAlbero": return "Aggiunge una sottocartella al nodo selezionato.";
                case "btnPiuInizio": return "Aggiunge una cartella radice all'albero.";
                case "btnMenoAlbero": return "Rimuove il nodo selezionato dall'albero.";
                case "btnDisabilitaCreare": return "Disabilita la creazione di tutti i nodi.";
                case "btnAbilitaCreare": return "Abilita la creazione di tutti i nodi.";
                case "txtCercaNodo": return "Testo da cercare nei nomi delle cartelle dell'albero (max 20 caratteri).";
                case "btnCercaNodo": return "Cerca il testo nell'albero; premendo di nuovo trova l'occorrenza successiva.";
                case "btnOrdina": return "Ordina alfabeticamente i nodi dell'albero.";
                case "btnPiuPiu": return "Espande tutti i nodi dell'albero.";
                case "btnMenoMeno": return "Comprime tutti i nodi dell'albero.";
                case "btnPiuCopia": return "Aggiunge file all'elenco da copiare.";
                case "btnMenoCopia": return "Rimuove i file selezionati dall'elenco.";
                case "btnCartellaPerCopiare": return "Usa la cartella selezionata nell'albero come destinazione dei file che verranno aggiunti.";
                case "btnCheckAll": return "Seleziona (check) tutti i file in elenco.";
                case "btnDeCheckAll": return "Deseleziona (uncheck) tutti i file in elenco.";
                case "btnCheckOn": return "Spunta le righe evidenziate in elenco (tutte, se nessuna è evidenziata).";
                case "btnCheckOff": return "Toglie la spunta alle righe evidenziate in elenco (a tutte, se nessuna è evidenziata).";
                case "btnCartellaRoot": return "Apre la scelta della cartella di destinazione principale.";
                case "btnCartellaCopia": return "Apre la scelta della cartella sorgente dei file.";
                case "btnApriFile": return "Apre un file di configurazione esistente.";
                case "btnSalva": return "Salva la configurazione corrente.";
                case "btnNuovo": return "Pulisce i dati correnti e crea una nuova configurazione.";
                case "btnEsporta": return "Esporta la configurazione in un file *.mall.";
                case "btnImporta": return "Importa dati da un file di configurazione.";
                case "btnApriFileConfigurazione": return "Apre la cartella del file di configurazione corrente.";
                case "btnTrovaESostituisci": return "Apre la finestra di ricerca e sostituzione sul file selezionato.";
                case "btnLaunchAll": return "Avvia LaunchAll con la configurazione corrente.";
                case "btnCreaCartella": return "Crea fisicamente la cartella root indicata.";
                case "btnCambiaDisco": return "Sostituisce il disco nei percorsi della configurazione.";
                default: return "";
            }
        }

        private string RecuperaToolTipGenerico(Control controllo)
        {
            if (controllo is Button)
                return "Esegue l'azione: " + controllo.Text;
            if (controllo is TextBox)
                return "Campo di testo modificabile.";
            if (controllo is ListView)
                return "Elenco elementi.";
            if (controllo is TreeView)
                return "Albero cartelle.";
            if (controllo is CheckBox)
                return "Opzione attivabile/disattivabile.";
            if (controllo is RadioButton)
                return "Selezione modalità.";
            if (controllo is ComboBox)
                return "Seleziona un valore dall'elenco.";
            if (controllo is DateTimePicker)
                return "Seleziona una data.";
            if (controllo is NumericUpDown)
                return "Inserisci un valore numerico.";
            if (controllo is LinkLabel)
                return "Apri collegamento.";

            return "";
        }

        private void btnCartellaRoot_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtRootDir.Text;
            DialogResult r = folderBrowserDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtRootDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCartellaCopia_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtCartellaCopia.Text;
            DialogResult r = folderBrowserDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtCartellaCopia.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnPiuAlbero_Click(object sender, EventArgs e)
        {
            string etichetta;
            if (txtNuova.Text != "")
                etichetta = txtNuova.Text;
            else
                etichetta = "Nuova cartella";
            if (trwCartelleDaCreare.SelectedNode != null)
            {
                // figlio
                TreeNode temp = new TreeNode(etichetta);
                trwCartelleDaCreare.SelectedNode.Nodes.Add(temp);
                trwCartelleDaCreare.SelectedNode = temp;
                temp.Checked = true;
                temp.BeginEdit();
            }
        }

        private void btnPiuCopia_Click(object sender, EventArgs e)
        {
            // Use the legacy CommonDialog implementation to avoid failures in the
            // native IFileDialog interop used by the Vista-style dialog.
            opfilScelta.AutoUpgradeEnabled = false;

            string initialDirectory = txtCartellaCopia.Text.Trim();
            opfilScelta.InitialDirectory = Directory.Exists(initialDirectory)
                ? initialDirectory
                : string.Empty;
            opfilScelta.Multiselect = true;
            opfilScelta.FileName = string.Empty;
            opfilScelta.RestoreDirectory = true;

            DialogResult r = opfilScelta.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                List<string> fileScartati = new List<string>();
                foreach (string file in opfilScelta.FileNames)
                {
                    string cartellaDestinazione = RicavaCartellaDestinazione(file);
                    if (TrovaDuplicato(file, cartellaDestinazione, null) != null)
                    {
                        fileScartati.Add(file + "  ->  " + cartellaDestinazione);
                        continue;
                    }

                    ListViewItem nuovaRiga = new ListViewItem(file);
                    nuovaRiga.SubItems.Add(cartellaDestinazione);
                    nuovaRiga.Checked = true;
                    lstvwFileDaCopiare.Items.Add(nuovaRiga);
                }
                if (fileScartati.Count > 0)
                    MessageBox.Show("I seguenti file sono già in elenco con la stessa cartella di destinazione e non sono stati aggiunti:\n\n" +
                        string.Join("\n", fileScartati) +
                        "\n\nPer copiare un file in una cartella diversa, selezionare la cartella nell'albero, " +
                        "premere 'Scegli cartella' e poi aggiungere di nuovo il file.",
                        "File già presenti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lstvwFileDaCopiare.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// Cartella di destinazione per un file che si sta aggiungendo: quella scelta
        /// con "Scegli cartella" (scritta in txtPathDestinazione) oppure, se txtPathDestinazione è vuoto,
        /// la stessa sottocartella che il file ha rispetto alla cartella di origine.
        /// </summary>
        private string RicavaCartellaDestinazione(string percorsoFile)
        {
            return string.IsNullOrWhiteSpace(txtPathDestinazione.Text)
                ? RicavaCartellaDestinazioneDefault(percorsoFile)
                : txtPathDestinazione.Text;
        }

        /// <summary>
        /// Ricava la cartella di destinazione relativa di default per un file sorgente:
        /// la sottocartella del file rispetto alla cartella sorgente (".\sub\cartella"),
        /// oppure ".\" se il file è nella cartella sorgente o al di fuori di essa.
        /// </summary>
        private string RicavaCartellaDestinazioneDefault(string percorsoFile)
        {
            string cartellaSorgente = txtCartellaCopia.Text;
            string? cartellaFile = Path.GetDirectoryName(percorsoFile);
            if (string.IsNullOrWhiteSpace(cartellaSorgente) || string.IsNullOrWhiteSpace(cartellaFile))
                return PrefissoRelativo();

            string relativo;
            try
            {
                relativo = Path.GetRelativePath(cartellaSorgente, cartellaFile);
            }
            catch (ArgumentException)
            {
                return PrefissoRelativo();
            }

            if (relativo == "." || relativo == ".." || Path.IsPathRooted(relativo) ||
                relativo.StartsWith(".." + Path.DirectorySeparatorChar, StringComparison.Ordinal))
                return PrefissoRelativo();

            return Path.Combine(".", relativo);
        }

        /// <summary>Percorso assoluto del file sorgente, usato per confrontare le righe.</summary>
        private string ChiaveSorgente(string testoSorgente)
        {
            string normalizzato = NormalizzaPercorsoSorgente(testoSorgente);
            string completo = Path.IsPathRooted(normalizzato)
                ? normalizzato
                : Path.Combine(txtCartellaCopia.Text, normalizzato);
            try
            {
                return Path.GetFullPath(completo);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is NotSupportedException || ex is PathTooLongException)
            {
                return completo;
            }
        }

        /// <summary>Cartella di destinazione normalizzata ("" = root), usata per confrontare le righe.</summary>
        private static string ChiaveDestinazione(string testoDestinazione)
        {
            string normalizzata = Path.TrimEndingDirectorySeparator(NormalizzaPercorsoRelativo(testoDestinazione));
            return normalizzata == "." ? "" : normalizzata;
        }

        /// <summary>
        /// Cerca in griglia una riga con lo stesso file sorgente e la stessa destinazione.
        /// La riga <paramref name="rigaDaEscludere"/> (se non null) non viene considerata.
        /// </summary>
        private ListViewItem? TrovaDuplicato(string sorgente, string destinazione, ListViewItem? rigaDaEscludere)
        {
            string chiaveSorgente = ChiaveSorgente(sorgente);
            string chiaveDestinazione = ChiaveDestinazione(destinazione);
            foreach (ListViewItem riga in lstvwFileDaCopiare.Items)
            {
                if (riga == rigaDaEscludere)
                    continue;
                string destinazioneRiga = riga.SubItems.Count > 1 ? riga.SubItems[1].Text : "";
                if (string.Equals(ChiaveSorgente(riga.Text), chiaveSorgente, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(ChiaveDestinazione(destinazioneRiga), chiaveDestinazione, StringComparison.OrdinalIgnoreCase))
                    return riga;
            }
            return null;
        }

        private void btnMenoCopia_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvwFileDaCopiare.SelectedItems)
                lstvwFileDaCopiare.Items.Remove(item);
        }

        private void btnCreaECopia_Click(object sender, EventArgs e)
        {
            CreaCartelle(false);
            btnCopia_Click(null, null);
        }

        private void btnMenoAlbero_Click(object sender, EventArgs e)
        {
            if (trwCartelleDaCreare.SelectedNode != null)
                trwCartelleDaCreare.SelectedNode.Remove();
        }

        private void btnCartellaPerCopiare_Click(object sender, EventArgs e)
        {
            if (trwCartelleDaCreare.SelectedNode == null)
            {
                MessageBox.Show("Selezionare nell'albero la cartella in cui copiare i file.");
                return;
            }

            // la cartella scelta diventa la destinazione dei file aggiunti da ora in poi
            txtPathDestinazione.Text = Path.Combine(".", trwCartelleDaCreare.SelectedNode.FullPath);
        }

        /// <summary>
        /// Assegna alle righe selezionate la destinazione corrente: quella in txtPathDestinazione,
        /// oppure (txtPathDestinazione vuoto) la sottocartella d'origine di ciascun file.
        /// Le righe che diventerebbero doppioni restano invariate e vengono segnalate.
        /// </summary>
        private void btnApplicaDestinazione_Click(object sender, EventArgs e)
        {
            if (lstvwFileDaCopiare.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selezionare le righe a cui cambiare la destinazione.");
                return;
            }

            List<string> fileScartati = new List<string>();
            foreach (ListViewItem riga in lstvwFileDaCopiare.SelectedItems)
            {
                string nuovaDestinazione = RicavaCartellaDestinazione(ChiaveSorgente(riga.Text));
                if (TrovaDuplicato(riga.Text, nuovaDestinazione, riga) != null)
                {
                    fileScartati.Add(riga.Text + "  ->  " + nuovaDestinazione);
                    continue;
                }
                if (riga.SubItems.Count > 1)
                    riga.SubItems[1].Text = nuovaDestinazione;
                else
                    riga.SubItems.Add(nuovaDestinazione);
            }
            lstvwFileDaCopiare.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            if (fileScartati.Count > 0)
                MessageBox.Show("Le seguenti righe non sono state modificate perché esiste già una riga con lo stesso file e la stessa destinazione:\n\n" +
                    string.Join("\n", fileScartati),
                    "File già presenti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCartellaOutDefault_Click(object sender, EventArgs e)
        {
            // txtPathDestinazione vuoto = modalità "stessa cartella dell'origine"
            txtPathDestinazione.Text = "";
        }

        private void txtRootDir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtRootDir.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire la cartella " + txtRootDir.Text);
                //+ "\nErrore: " + er.ToString());
            }
        }

        private void txtCartellaCopia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtCartellaCopia.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire il file " + txtCartellaCopia.Text);
                //+ "\nErrore: " + er.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string etichetta;
            if (txtNuova.Text != "")
                etichetta = txtNuova.Text;
            else
                etichetta = "Nuova cartella";
            // padre
            TreeNode temp = new TreeNode(etichetta);
            trwCartelleDaCreare.Nodes.Add(temp);
            temp.Checked = true;
            temp.BeginEdit();
        }

        private void btnCreaCartelle_Click(object sender, EventArgs e)
        {
            CreaCartelle(true);
        }

        private void CreaCartelle(bool mostraMessaggioFinale)
        {
            foreach (TreeNode nodoRadice in trwCartelleDaCreare.Nodes)
            {
                CreaFiglio(nodoRadice);
            }

            if (mostraMessaggioFinale)
                MessageBox.Show("Fatto");
        }

        private void CreaFiglio(TreeNode NodoCorrente)
        {
            // Un nodo non selezionato non viene creato di per sé, ma i suoi figli selezionati sì:
            // Directory.CreateDirectory crea anche le cartelle padre mancanti.
            if (NodoCorrente.Checked)
                Directory.CreateDirectory(Path.Combine(txtRootDir.Text, NodoCorrente.FullPath));

            foreach (TreeNode figlio in NodoCorrente.Nodes)
            {
                CreaFiglio(figlio);
            }
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem fileDaCopiare in lstvwFileDaCopiare.Items)
            {
                string filePartenza = "";
                string fileDestinazione = "";
                try
                {
                    if (fileDaCopiare.Checked)
                    {
                        string percorsoSorgenteNormalizzato = NormalizzaPercorsoSorgente(fileDaCopiare.Text);
                        filePartenza = Path.IsPathRooted(percorsoSorgenteNormalizzato)
                            ? percorsoSorgenteNormalizzato
                            : Path.Combine(txtCartellaCopia.Text, percorsoSorgenteNormalizzato);

                        string soloNomeFileDaCopiare;
                        if (txtStringaDa.Text != "")
                        {
                            soloNomeFileDaCopiare = Path.GetFileName(fileDaCopiare.SubItems[0].Text).Replace(
                                                txtStringaDa.Text, txtStringaA.Text);
                        }
                        else
                        {
                            soloNomeFileDaCopiare = Path.GetFileName(fileDaCopiare.SubItems[0].Text);
                        }
                        if (txtStringa2Da.Text != "")
                        {
                            soloNomeFileDaCopiare = Path.GetFileName(soloNomeFileDaCopiare).Replace(
                                                txtStringa2Da.Text, txtStringa2A.Text);
                        }

                        string cartellaDestinazioneRelativa = NormalizzaPercorsoRelativo(fileDaCopiare.SubItems[1].Text);
                        string pathCartellaDestinazione = Path.Combine(txtRootDir.Text, cartellaDestinazioneRelativa);
                        fileDestinazione = Path.Combine(pathCartellaDestinazione, soloNomeFileDaCopiare);

                        // la cartella di destinazione potrebbe non essere nell'albero da creare
                        Directory.CreateDirectory(pathCartellaDestinazione);
                        File.Copy(filePartenza, fileDestinazione);
                    }
                }
                catch (Exception ex)
                {
                    if (!File.Exists(fileDestinazione))
                        MessageBox.Show("Impossibile copiare il file " + fileDestinazione);
                    else
                        if (MessageBox.Show("Il file " + fileDestinazione + " esiste già. Lo si vuole copiare comunque?",
                            "Errore", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                            == DialogResult.Yes)
                            File.Copy(filePartenza, fileDestinazione, true);
                }
            }
            MessageBox.Show("Fatto");
        }

        private void btnPiuPiu_Click(object sender, EventArgs e)
        {
            trwCartelleDaCreare.ExpandAll();
        }

        private void btnMenoMeno_Click(object sender, EventArgs e)
        {
            trwCartelleDaCreare.CollapseAll();
        }

        private void trwCartelleDaCreare_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Propaga solo i cambi fatti dall'utente (mouse/tastiera): i cambi da codice
            // (caricamento file, propagazione stessa) hanno Action == Unknown e vengono ignorati.
            if (e.Action == TreeViewAction.Unknown || e.Node == null)
                return;

            ImpostaCheckDiscendenti(e.Node, e.Node.Checked);
        }

        private static void ImpostaCheckDiscendenti(TreeNode nodo, bool stato)
        {
            foreach (TreeNode figlio in nodo.Nodes)
            {
                figlio.Checked = stato;
                ImpostaCheckDiscendenti(figlio, stato);
            }
        }

        private void btnLaunchAll_Click(object sender, EventArgs e)
        {
            try
            {
                // chiama l'altro programma con una shell passandogli un parametro
                // passa FileConfigurazione 
                string stringaArgomenti = txtFileConfigurazione.Text;
                string percorsoLaunchAll = Path.Combine(AppContext.BaseDirectory, "LaunchAll.exe");
                System.Diagnostics.Process.Start(percorsoLaunchAll, stringaArgomenti);
            }
            catch (Exception ur)
            {
                MessageBox.Show("Il programma LaunchAll non è eseguibile");
            }
        }

        private void TagliaBackSlash()
        {
            if (!string.IsNullOrEmpty(txtCartellaCopia.Text) && Path.EndsInDirectorySeparator(txtCartellaCopia.Text))
                txtCartellaCopia.Text = Path.TrimEndingDirectorySeparator(txtCartellaCopia.Text);

            if (!string.IsNullOrEmpty(txtRootDir.Text) && Path.EndsInDirectorySeparator(txtRootDir.Text))
                txtRootDir.Text = Path.TrimEndingDirectorySeparator(txtRootDir.Text);
        }

        private static StreamWriter openFileOut(string NomeFile, bool appendi)
        {
            if (string.IsNullOrWhiteSpace(NomeFile))
                return null;

            Encoding fileEncoding = Encoding.Default;
            try
            {
                FileStream fsOut;
                if (appendi)
                    fsOut = new FileStream(NomeFile, FileMode.Append, FileAccess.Write, FileShare.Read);
                else
                    fsOut = new FileStream(NomeFile, FileMode.Create, FileAccess.Write, FileShare.Read);

                return new StreamWriter(fsOut, fileEncoding);
            }
            catch (Exception e)
            {
                Console.WriteLine("Non si riesce ad aprire il file " + NomeFile + ". Errore:" + e.Message);
                return null;
            }
        }

        private bool SalvaFile()
        {
            // taglia un eventuale \ in fondo nelle box di directory
            //TODO fare un metodo e lanciarlo anche prima di ogni parte che include la composizione di cartella e nome del file 

            // taglia eventuali \ nelle cartelle delle directory
            TagliaBackSlash();
            // apertura file di uscita 
            StreamWriter fileOut = openFileOut(txtFileConfigurazione.Text, false);

            if (fileOut != null)
            {
                fileOut.WriteLine("CartellaRootPerCreazione");
                fileOut.WriteLine(txtRootDir.Text);
                fileOut.WriteLine("CartellaDefaultPerCopia");
                fileOut.WriteLine(txtCartellaCopia.Text);
                fileOut.WriteLine("FilesDaCopiare");
                for (int i = 0; i < lstvwFileDaCopiare.Items.Count; i++)
                {
                    fileOut.Write(RicavaPercorsoSorgentePerSalvataggio(lstvwFileDaCopiare.Items[i].Text));
                    if (lstvwFileDaCopiare.Items[i].Checked)
                        fileOut.Write("|AB");
                    else
                        fileOut.Write("|NAB");
                    // aggiunge la cartella di destinazione
                    // se c'è qualcosa nella seconda colonna copia nel file la seconda colonna
                    // se non c'è niente nella seconda colonna, mette nel file l'indicazione di root
                    if (lstvwFileDaCopiare.Items[i].SubItems.Count > 1 && lstvwFileDaCopiare.Items[i].SubItems[1].Text != "")
                        fileOut.WriteLine("|" + lstvwFileDaCopiare.Items[i].SubItems[1].Text);
                    else
                        fileOut.WriteLine("|" + PrefissoRelativo());
                }
                // copia dell'albero delle cartelle da creare, dal form nascosto 
                fileOut.WriteLine("AlberoCartelleDaCreare");
                foreach (TreeNode nodoRadice in trwCartelleDaCreare.Nodes)
                {
                    SalvaFiglio(nodoRadice, fileOut);
                }
            }
            else // file non apribile 
            {
                MessageBox.Show("File non creabile");
                return false;
            }

            fileOut.Close();
            return true;
        }

        private void SalvaFiglio(TreeNode NodoCorrente, StreamWriter fileOut)
        {
            fileOut.WriteLine(NodoCorrente.FullPath + (NodoCorrente.Checked ? "|AB" : "|NAB"));

            foreach (TreeNode figlio in NodoCorrente.Nodes)
            {
                SalvaFiglio(figlio, fileOut);
            }
        }

        private bool LeggiFile(string PathENome, bool CancellaPrecedenti)
        {
            StreamReader sr;
            int riga = 0;
            string Line;
            string[] campi;

            try
            {
                // apertura del file 
                FileStream fsIn = new FileStream(PathENome,
                                    FileMode.Open, FileAccess.Read, FileShare.Read);
                sr = new StreamReader(fsIn);
            }
            catch
            {
                return false;
            }

            // butta via la prima riga
            sr.ReadLine();
            // ora nella linea c'è CartellaRootPerCreazione

            // legge la prima cartella
            txtRootDir.Text = sr.ReadLine();
            //????
            //if (txtRootDir.Text == "")
            //    txtRootDir.Text = txtCartella1.Text;

            // butta via la scritta CartellaDefaultPerCopia
            Line = sr.ReadLine();
            txtCartellaCopia.Text = sr.ReadLine();
            if (CancellaPrecedenti)
                lstvwFileDaCopiare.Items.Clear();

            //????
            //if (txtCartellaCopia.Text == "")
            //    txtCartellaCopia.Text = txtCartella2.Text;

            // butta via la scritta FilesDaCopiare
            Line = sr.ReadLine();

            lstvwFileDaCopiare.View = View.Details;
            riga = 0;
            while ((Line = sr.ReadLine()) != null && Line != "AlberoCartelleDaCreare")
            {
                if (!string.IsNullOrEmpty(Line))
                {
                    campi = Line.Split('|');
                    if (campi.Length < 3)
                        continue;
                    // non aggiunge righe con stesso file e stessa destinazione già presenti
                    if (TrovaDuplicato(campi[0], campi[2], null) != null)
                        continue;
                    ListViewItem item1 = new ListViewItem(campi[0], riga);
                    // mette in seconda colonna le directory di destinazione
                    item1.SubItems.Add(campi[2]);
                    item1.Checked = campi[1] != "NAB";
                    lstvwFileDaCopiare.Items.Add(item1);
                    riga++;
                }
            }
            // riempimento dell'albero

            TreeView albero = trwCartelleDaCreare;
            // lettura della struttura di cartelle da creare
            if (CancellaPrecedenti)
                trwCartelleDaCreare.Nodes.Clear();

            string fullPath;
            while ((fullPath = sr.ReadLine()) != null)
            {
                if (fullPath != "")
                {
                    bool pathAbilitata = (fullPath.Substring(fullPath.LastIndexOf("|")) == "|AB");
                    fullPath = fullPath.Remove(fullPath.LastIndexOf("|"));
                    TreeNode nodoRadice = null;
                    ElaboraNodo(nodoRadice, fullPath, pathAbilitata);
                }
            }
            trwCartelleDaCreare.ExpandAll();
            // chiusura dello StreamReader
            sr.Close();
            return true;
        }

        private void ElaboraNodo(TreeNode NodoCorrente, string Path, bool Abilitata)
        {
            string cartellaFiglia;
            int slash = Path.IndexOf(System.IO.Path.DirectorySeparatorChar);
            if (slash >= 0)
                cartellaFiglia = Path.Substring(0, slash);
            else
                cartellaFiglia = Path;

            TreeNode figlio = null; // nodo figlio nell'albero
            bool trovato;
            if (NodoCorrente == null)
            {   // è un nodo iniziale
                trovato = false;
                foreach (TreeNode temp in trwCartelleDaCreare.Nodes)
                {
                    if (cartellaFiglia == temp.Text)
                    {
                        trovato = true;
                        figlio = temp;
                        break;
                    }
                }
                if (!trovato)
                {
                    figlio = new TreeNode(cartellaFiglia);
                    trwCartelleDaCreare.Nodes.Add(figlio);
                }
            }
            else
            {
                // cerca fra i figli del nodo corrente cerca se c'è la cartella che è stata passata
                trovato = false;
                if (NodoCorrente.Nodes != null)
                {
                    foreach (TreeNode temp in NodoCorrente.Nodes)
                    {
                        if (cartellaFiglia == temp.Text)
                        {
                            trovato = true;
                            figlio = temp;
                            break;
                        }
                    }
                }
                else
                {
                    // è un nodo 

                }
                // se la trova, non fa niente perchè c'è gia
                if (!trovato)
                {
                    // se non c'è crea un nodo e lo mette come figlio corrente
                    figlio = new TreeNode(cartellaFiglia);
                    NodoCorrente.Nodes.Add(figlio);
                }
            }

            // Applica lo stato solo al nodo della riga corrente: i nodi antenati
            // hanno un proprio record nel file e non devono essere sovrascritti.
            if (slash < 0)
                figlio.Checked = Abilitata;

            // se la path passata ha nuovi figli, taglia il nodo appena elaborato e passa al prossimo
            if (slash >= 0)
            {
                string nuovaPath = Path.Substring(slash + 1);
                ElaboraNodo(figlio, nuovaPath, Abilitata);
            }
        }

        private void btnApriFileConfigurazione_Click(object sender, EventArgs e)
        {
            AssicuraCartellaConfigurazioneDefault();
            opfilConfigurazione.Title = "Scelta file da aprire";
            opfilConfigurazione.Filter = "File di ApriTutto|*.mall";
            opfilConfigurazione.InitialDirectory = RicavaCartellaDialogoConfigurazione();
            opfilConfigurazione.FileName = "*.mall";
            opfilConfigurazione.Multiselect = false;
            DialogResult r = opfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtFileConfigurazione.Text = opfilConfigurazione.FileName;
                LeggiFileConfigurazione();
            }
        }

        private void LeggiFileConfigurazione()
        {
            if (File.Exists(txtFileConfigurazione.Text))
            {
                LeggiFile(txtFileConfigurazione.Text, true);
                ForzaAbilitazioneBottoni(true);
                lstvwFileDaCopiare.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                MessageBox.Show("Il file non esiste");
            }
        }

        private void ForzaAbilitazioneBottoni(bool Stato)
        {
            btnTrovaESostituisci.Enabled = Stato;
            btnEsporta.Enabled = Stato;
            btnImporta.Enabled = Stato;
            btnSalva.Enabled = Stato;
            btnApriFile.Enabled = Stato;
            btnCreaCartelle.Enabled = Stato;
            //foreach (Button b in btnConfigura)
            //{
            //    b.Enabled = stato;
            //}
            btnPiuCopia.Enabled = Stato;
            btnMenoCopia.Enabled = Stato;
            btnCopia.Enabled = Stato;
            btnCartellaPerCopiare.Enabled = Stato;
            btnApplicaDestinazione.Enabled = Stato;
            btnPiuInizio.Enabled = Stato;
            btnPiuAlbero.Enabled = Stato;
            btnMenoAlbero.Enabled = Stato;
            btnPiuPiu.Enabled = Stato;
            btnMenoMeno.Enabled = Stato;
            btnCreaCartelle.Enabled = Stato;
            btnDeCheckAll.Enabled = Stato;
            btnCheckAll.Enabled = Stato;
            btnDisabilitaCreare.Enabled = Stato;
            btnAbilitaCreare.Enabled = Stato;
            btnCheckOff.Enabled = Stato;
            btnCheckOn.Enabled = Stato;
            btnOrdina.Enabled = Stato;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            SalvaFile();
            LeggiFileConfigurazione();
        }

        private void btnApriFile_Click(object sender, EventArgs e)
        {
            LeggiFileConfigurazione();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            AssicuraCartellaConfigurazioneDefault();
            svfilConfigurazione.Filter = "File di MakeAllDirs|*.mall";
            svfilConfigurazione.InitialDirectory = RicavaCartellaDialogoConfigurazione();
            if (string.IsNullOrWhiteSpace(txtFileConfigurazione.Text))
                svfilConfigurazione.FileName = Path.Combine(RicavaCartellaConfigurazioneDefault(), "NuovaConfigurazione.mall");
            DialogResult r = svfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtFileConfigurazione.Text = svfilConfigurazione.FileName;
                lstvwFileDaCopiare.Items.Clear();
                SalvaFile();
                LeggiFileConfigurazione();
            }
        }

        private void btnImporta_Click(object sender, EventArgs e)
        {
            AssicuraCartellaConfigurazioneDefault();
            opfilConfigurazione.Title = "Scelta file da importare";
            // scelta del file da importare
            opfilConfigurazione.Filter = "File di MakeAllDirs|*.mall";
            opfilConfigurazione.InitialDirectory = RicavaCartellaDialogoConfigurazione();
            opfilConfigurazione.Multiselect = false;
            DialogResult r = opfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                LeggiFile(opfilConfigurazione.FileName, false);
            }
        }

        private void btnEsporta_Click(object sender, EventArgs e)
        {
            AssicuraCartellaConfigurazioneDefault();
            svfilConfigurazione.Filter = "File di MakeAllDirs|*.mall";
            svfilConfigurazione.InitialDirectory = RicavaCartellaDialogoConfigurazione();
            svfilConfigurazione.FileName = txtFileConfigurazione.Text;
            DialogResult r = svfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                //if (txtFileConfigurazione.Text == svfilConfigurazione.FileName)
                //{
                //    MessageBox.Show("Salva con nome non permesso con lo stesso nome");
                //    return; 
                //}
                txtFileConfigurazione.Text = svfilConfigurazione.FileName;
                SalvaFile();
                LeggiFileConfigurazione();
            }
        }

        private void txtFileConfigurazione_TextChanged(object sender, EventArgs e)
        {
            string pathDefault = "";

            ForzaAbilitazioneBottoni(File.Exists(txtFileConfigurazione.Text));
            this.Text = Path.GetFileName(txtFileConfigurazione.Text) + " | " + this.Text.Substring(this.Text.IndexOf("|") + 1).Trim(); ;
            //if (txtFileConfigurazione.Text != "")
            //    pathDefault = Path.GetDirectoryName(txtFileConfigurazione.Text);
        }

        private void btnTrovaESostituisci_Click(object sender, EventArgs e)
        {
            frmSostituzione f = new frmSostituzione(txtFileConfigurazione.Text);
            f.ShowDialog();
            LeggiFile(txtFileConfigurazione.Text, true);
        }

        private void txtEdit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // apre la cartella di destinazione scelta (o la root se è "stessa cartella")
            string cartella = Path.Combine(txtRootDir.Text, NormalizzaPercorsoRelativo(txtPathDestinazione.Text));
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(cartella) { UseShellExecute = true });
            }
            catch (Exception ex) when (ex is System.ComponentModel.Win32Exception || ex is InvalidOperationException)
            {
                MessageBox.Show("Errore nell'aprire la cartella " + cartella + "\n(potrebbe non essere ancora stata creata)");
            }
        }

        private void trwCartelleDaCreare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                trwCartelleDaCreare.SelectedNode.BeginEdit();
        }

        private void lstvwFileDaCopiare_DoubleClick(object sender, EventArgs e)
        {
            ListView lista = (ListView)sender;
            string nomeFile = Path.Combine(txtCartellaCopia.Text, RimuoviPrefissoRelativo(lista.SelectedItems[0].Text));
            try
            {
                System.Diagnostics.Process.Start(nomeFile);
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire il file " + nomeFile);
                //+ "\nErrore: " + er.ToString());
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem nodo in lstvwFileDaCopiare.Items)
                nodo.Checked = true;
        }

        private void btnDeCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem nodo in lstvwFileDaCopiare.Items)
                nodo.Checked = false;
        }

        private void btnAbilitaCreare_Click(object sender, EventArgs e)
        {
            foreach (TreeNode nodo in trwCartelleDaCreare.Nodes)
            {
                AbilitaAlbero(nodo, true);
                nodo.Checked = true;
            }
        }

        private void btnDisabilitaCreare_Click(object sender, EventArgs e)
        {
            foreach (TreeNode nodo in trwCartelleDaCreare.Nodes)
            {
                AbilitaAlbero(nodo, false);
                nodo.Checked = false;
            }
        }

        private void AbilitaAlbero(TreeNode Nodo, bool Abilita)
        {
            foreach (TreeNode n in Nodo.Nodes)
            {
                AbilitaAlbero(n, false);
                n.Checked = Abilita;
            }
        }

        private int colonnaOrdinamento = -1;
        private bool ordinamentoCrescente = true;

        /// <summary>
        /// Ordina la griglia per la colonna cliccata; un secondo clic sulla stessa colonna inverte l'ordine.
        /// </summary>
        private void lstvwFileDaCopiare_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ordinamentoCrescente = e.Column != colonnaOrdinamento || !ordinamentoCrescente;
            colonnaOrdinamento = e.Column;

            lstvwFileDaCopiare.ListViewItemSorter = new ConfrontoRighe(e.Column, ordinamentoCrescente);
            lstvwFileDaCopiare.Sort();
            // si toglie il sorter: l'ordine resta, ma le righe aggiunte dopo non vengono riordinate da sole
            lstvwFileDaCopiare.ListViewItemSorter = null;

            AggiornaIndicatoriOrdinamento();
        }

        private void AggiornaIndicatoriOrdinamento()
        {
            foreach (ColumnHeader colonna in lstvwFileDaCopiare.Columns)
            {
                string testoBase = colonna.Tag as string ?? colonna.Text;
                colonna.Tag = testoBase;
                colonna.Text = colonna.Index == colonnaOrdinamento
                    ? testoBase + (ordinamentoCrescente ? " ▲" : " ▼")
                    : testoBase;
            }
        }

        private sealed class ConfrontoRighe : System.Collections.IComparer
        {
            private readonly int colonna;
            private readonly bool crescente;

            public ConfrontoRighe(int colonna, bool crescente)
            {
                this.colonna = colonna;
                this.crescente = crescente;
            }

            public int Compare(object? x, object? y)
            {
                string a = Testo(x as ListViewItem);
                string b = Testo(y as ListViewItem);
                int risultato = string.Compare(a, b, StringComparison.CurrentCultureIgnoreCase);
                return crescente ? risultato : -risultato;
            }

            private string Testo(ListViewItem? riga)
            {
                if (riga == null || colonna >= riga.SubItems.Count)
                    return "";
                return riga.SubItems[colonna].Text;
            }
        }

        private void btnCheckOff_Click(object sender, EventArgs e)
        {
            ImpostaCheckRighe(false);
        }

        private void btnCheckOn_Click(object sender, EventArgs e)
        {
            ImpostaCheckRighe(true);
        }

        /// <summary>
        /// Imposta il check sulle righe selezionate nella griglia;
        /// se nessuna riga è selezionata lo imposta su tutte le righe.
        /// </summary>
        private void ImpostaCheckRighe(bool stato)
        {
            System.Collections.IEnumerable righe = lstvwFileDaCopiare.SelectedItems.Count > 0
                ? lstvwFileDaCopiare.SelectedItems
                : lstvwFileDaCopiare.Items;
            foreach (ListViewItem riga in righe)
                riga.Checked = stato;
        }

        private void txtDisco_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscoNuovo.Text.Length > 1)
            {
                Console.Beep();
                txtDiscoNuovo.Text = txtDiscoNuovo.Text.Substring(1, 1);
            }
        }

        private void btnCambiaDisco_Click(object sender, EventArgs e)
        {
            txtDiscoVecchio.Text = AssicuraSeparatoreFinale(txtDiscoVecchio.Text);
            txtDiscoNuovo.Text = AssicuraSeparatoreFinale(txtDiscoNuovo.Text);

            if (txtRootDir.Text != "" && txtDiscoNuovo.Text != "")
            {
                txtRootDir.Text = txtRootDir.Text.Replace(txtDiscoVecchio.Text, txtDiscoNuovo.Text);
                txtCartellaCopia.Text = txtCartellaCopia.Text.Replace(txtDiscoVecchio.Text, txtDiscoNuovo.Text);
            }

            string vecchioPrefissoDisco = RicavaPrefissoDisco(txtDiscoVecchio.Text);
            string nuovoPrefissoDisco = RicavaPrefissoDisco(txtDiscoNuovo.Text);
            foreach (ListViewItem it in lstvwFileDaCopiare.Items)
            {
                it.Text = it.Text.Replace(vecchioPrefissoDisco, nuovoPrefissoDisco);
            }
        }

        private void btnCreaCartella_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.Directory.CreateDirectory(txtRootDir.Text);
            }
            catch
            {
                Console.Beep(); ;
            }
        }

        private void lstvwFileDaCopiare_Enter(object sender, EventArgs e)
        {
            lstvwFileDaCopiare.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void txtDiscoVecchio_Leave(object sender, EventArgs e)
        {
            txtDiscoVecchio.Text = AssicuraSeparatoreFinale(txtDiscoVecchio.Text);
        }

        private void txtDiscoNuovo_Leave(object sender, EventArgs e)
        {
            txtDiscoNuovo.Text = AssicuraSeparatoreFinale(txtDiscoNuovo.Text);
        }

        private static string AssicuraSeparatoreFinale(string valore)
        {
            if (string.IsNullOrWhiteSpace(valore))
                return valore;

            return Path.EndsInDirectorySeparator(valore)
                ? valore
                : valore + Path.DirectorySeparatorChar;
        }

        private static string RicavaPrefissoDisco(string valore)
        {
            if (string.IsNullOrWhiteSpace(valore))
                return valore;

            string normalizzato = AssicuraSeparatoreFinale(valore).Trim();
            if (normalizzato.Length == 1 && char.IsLetter(normalizzato[0]))
                normalizzato = normalizzato + ":" + Path.DirectorySeparatorChar;

            return normalizzato;
        }

        private static string PrefissoRelativo()
        {
            return "." + Path.DirectorySeparatorChar;
        }

        private static string RimuoviPrefissoRelativo(string valore)
        {
            if (string.IsNullOrWhiteSpace(valore))
                return valore;

            string percorso = valore.Trim();
            string prefissoDirectory = "." + Path.DirectorySeparatorChar;
            string prefissoAlternativo = "." + Path.AltDirectorySeparatorChar;

            if (percorso.StartsWith(prefissoDirectory, StringComparison.Ordinal) ||
                percorso.StartsWith(prefissoAlternativo, StringComparison.Ordinal))
                return percorso.Substring(2);

            return percorso;
        }

        private static string NormalizzaPercorsoRelativo(string valore)
        {
            if (string.IsNullOrWhiteSpace(valore))
                return "";

            string percorso = RimuoviPrefissoRelativo(valore.Trim());
            return percorso.TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        }

        private string NormalizzaPercorsoSorgente(string valore)
        {
            if (string.IsNullOrWhiteSpace(valore))
                return "";

            string testo = RimuoviPrefissoRelativo(valore);
            if (!Path.IsPathRooted(testo))
                return NormalizzaPercorsoRelativo(testo);

            if (Path.IsPathFullyQualified(testo))
                return testo;

            return testo.TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
        }

        private string RicavaPercorsoSorgentePerSalvataggio(string valore)
        {
            string percorsoNormalizzato = NormalizzaPercorsoSorgente(valore);
            if (percorsoNormalizzato == "")
                return PrefissoRelativo();

            if (Path.IsPathRooted(percorsoNormalizzato))
            {
                if (string.IsNullOrWhiteSpace(txtCartellaCopia.Text))
                    return percorsoNormalizzato;

                string relativo = Path.GetRelativePath(txtCartellaCopia.Text, percorsoNormalizzato);
                if (relativo.StartsWith(".." + Path.DirectorySeparatorChar, StringComparison.Ordinal) || relativo == "..")
                    return percorsoNormalizzato;

                return Path.Combine(PrefissoRelativo(), relativo);
            }

            return Path.Combine(PrefissoRelativo(), percorsoNormalizzato);
        }

        private void btnCopiaStruttura_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "Seleziona la cartella modello";
            folderBrowserDialog.ShowNewFolderButton = false;
            folderBrowserDialog.SelectedPath = Directory.Exists(txtRootDir.Text) ? txtRootDir.Text : "";

            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;

            CopiaStrutturaCartellaModello(folderBrowserDialog.SelectedPath);
        }

        private void CopiaStrutturaCartellaModello(string cartellaModello)
        {
            if (cartellaModello == null || cartellaModello == "")
            {
                MessageBox.Show("Selezionare una cartella modello valida.");
                return;
            }

            if (!Directory.Exists(cartellaModello))
            {
                MessageBox.Show("La cartella modello selezionata non esiste.");
                return;
            }

            trwCartelleDaCreare.BeginUpdate();
            try
            {
                trwCartelleDaCreare.Nodes.Clear();
                string[] sottocartelle = Directory.GetDirectories(cartellaModello, "*", SearchOption.AllDirectories);

                foreach (string sottocartella in sottocartelle)
                {
                    string pathRelativa = sottocartella.Substring(cartellaModello.Length).TrimStart('\\');
                    if (pathRelativa != "")
                    {
                        TreeNode nodoRadice = null;
                        ElaboraNodo(nodoRadice, pathRelativa, true);
                    }
                }

                trwCartelleDaCreare.ExpandAll();
                if (trwCartelleDaCreare.Nodes.Count > 0)
                    trwCartelleDaCreare.SelectedNode = trwCartelleDaCreare.Nodes[0];
                else
                    MessageBox.Show("La cartella modello non contiene sottocartelle.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Accesso negato durante la lettura della cartella modello.");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("La cartella modello non è stata trovata.");
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("Uno o più percorsi nella cartella modello sono troppo lunghi.");
            }
            catch (IOException)
            {
                MessageBox.Show("Errore di I/O durante la lettura della cartella modello.");
            }
            finally
            {
                trwCartelleDaCreare.EndUpdate();
            }
        }

        private void btnCercaNodo_Click(object sender, EventArgs e)
        {
            CercaNodoSuccessivo();
        }

        private void txtCercaNodo_KeyDown(object sender, KeyEventArgs e)
        {
            // Invio nella casella equivale a premere "Cerca"
            if (e.KeyCode != Keys.Enter)
                return;
            e.SuppressKeyPress = true;
            CercaNodoSuccessivo();
        }

        /// <summary>
        /// Cerca il testo di txtCercaNodo nei nodi dell'albero, a partire dal nodo
        /// successivo a quello selezionato se la ricerca è la stessa della volta precedente,
        /// altrimenti dall'inizio. Se non trova più nulla avvisa e la ricerca successiva riparte dall'inizio.
        /// </summary>
        private void CercaNodoSuccessivo()
        {
            string testoCercato = txtCercaNodo.Text.Trim();
            if (testoCercato == "")
                return;

            List<TreeNode> nodi = new List<TreeNode>();
            foreach (TreeNode radice in trwCartelleDaCreare.Nodes)
                AccodaNodiInOrdine(radice, nodi);

            bool continuaRicerca = string.Equals(testoCercato, ultimaRicercaNodi, StringComparison.OrdinalIgnoreCase);
            int inizio = continuaRicerca && trwCartelleDaCreare.SelectedNode != null
                ? nodi.IndexOf(trwCartelleDaCreare.SelectedNode) + 1
                : 0;

            for (int i = inizio; i < nodi.Count; i++)
            {
                if (nodi[i].Text.Contains(testoCercato, StringComparison.OrdinalIgnoreCase))
                {
                    ultimaRicercaNodi = testoCercato;
                    trwCartelleDaCreare.SelectedNode = nodi[i];
                    nodi[i].EnsureVisible();
                    return;
                }
            }

            ultimaRicercaNodi = "";
            MessageBox.Show("Non trovata", "Ricerca nodi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void AccodaNodiInOrdine(TreeNode nodo, List<TreeNode> nodi)
        {
            nodi.Add(nodo);
            foreach (TreeNode figlio in nodo.Nodes)
                AccodaNodiInOrdine(figlio, nodi);
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            trwCartelleDaCreare.Sort();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form About = new frmAbout();
            About.Show();
        }
    }
}
