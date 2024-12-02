using System;
using System.Windows.Forms;

namespace AgendaProSolutions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agendaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonLocalizar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaMenu,
            this.cadastroMenu,
            this.sobreMenu,
            this.contatoMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu Items
            // 
            this.agendaMenu.Text = "Agenda";
            this.cadastroMenu.Text = "Cadastro";
            this.sobreMenu.Text = "Sobre";
            this.contatoMenu.Text = "Contato";
            // 
            // TextBoxes and Labels
            // 
            this.labelID.Text = "ID";
            this.labelID.Location = new System.Drawing.Point(12, 40);
            this.textBoxID.Location = new System.Drawing.Point(50, 37);
            this.textBoxID.Width = 100;

            this.labelNome.Text = "Nome";
            this.labelNome.Location = new System.Drawing.Point(12, 70);
            this.textBoxNome.Location = new System.Drawing.Point(50, 67);
            this.textBoxNome.Width = 300;

            this.labelEmail.Text = "E-mail";
            this.labelEmail.Location = new System.Drawing.Point(370, 70);
            this.textBoxEmail.Location = new System.Drawing.Point(420, 67);
            this.textBoxEmail.Width = 300;

            // Buttons
            this.buttonInserir.Text = "INSERIR";
            this.buttonInserir.Location = new System.Drawing.Point(50, 100);
            this.buttonInserir.Click += new System.EventHandler(this.ButtonInserir_Click);

            this.buttonAlterar.Text = "ALTERAR";
            this.buttonAlterar.Location = new System.Drawing.Point(150, 100);

            this.buttonExcluir.Text = "EXCLUIR";
            this.buttonExcluir.Location = new System.Drawing.Point(250, 100);

            this.buttonLocalizar.Text = "LOCALIZAR";
            this.buttonLocalizar.Location = new System.Drawing.Point(350, 100);

            // DataGridView
            this.dataGridView.Location = new System.Drawing.Point(12, 150);
            this.dataGridView.Size = new System.Drawing.Size(760, 300);

            // Status Label
            this.statusLabel.Text = "Local Onde Estão os Dados:";
            this.statusLabel.Location = new System.Drawing.Point(12, 460);
            this.statusLabel.AutoSize = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonLocalizar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Agenda - CRUD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Event Handler for Insert Button (Example)
        private void ButtonInserir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função para Inserir será implementada aqui!");
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendaMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastroMenu;
        private System.Windows.Forms.ToolStripMenuItem sobreMenu;
        private System.Windows.Forms.ToolStripMenuItem contatoMenu;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonLocalizar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label statusLabel;
    }
}
