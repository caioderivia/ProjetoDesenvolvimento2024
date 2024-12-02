using System;
using System.Windows.Forms;

namespace AgendaProSolutions
{
    public partial class FormContato : Form
    {
        public FormContato()
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.linkLabelMaps = new System.Windows.Forms.LinkLabel();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
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
            // Labels for Email, Phone, Address
            // 
            this.labelEmail.Text = "Email: AgendaProSolutions@gmail.com";
            this.labelEmail.Location = new System.Drawing.Point(12, 40);
            this.labelEmail.AutoSize = true;

            this.labelTelefone.Text = "Telefone: 11996653354";
            this.labelTelefone.Location = new System.Drawing.Point(12, 70);
            this.labelTelefone.AutoSize = true;

            this.labelEndereco.Text = "Endereço: Avenida São João, 633 - República - São Paulo - SP Brazil";
            this.labelEndereco.Location = new System.Drawing.Point(12, 100);
            this.labelEndereco.AutoSize = true;

            // Link to Google Maps
            this.linkLabelMaps.Text = "Link do Maps";
            this.linkLabelMaps.Location = new System.Drawing.Point(12, 130);
            this.linkLabelMaps.AutoSize = true;
            this.linkLabelMaps.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMaps_LinkClicked);

            // PictureBox for Map Image
            this.pictureBoxMap.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?center=-23.55052,-46.633308&zoom=15&size=600x400&markers=color:red|label:C|-23.55052,-46.633308";
            this.pictureBoxMap.Location = new System.Drawing.Point(12, 160);
            this.pictureBoxMap.Size = new System.Drawing.Size(760, 400);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // FormContato
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.linkLabelMaps);
            this.Controls.Add(this.pictureBoxMap);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormContato";
            this.Text = "Contato";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Event handler to open the Google Maps link when clicked
        private void LinkLabelMaps_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps?q=Avenida+São+João,+633,+República,+São+Paulo,+SP,+Brazil");
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendaMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastroMenu;
        private System.Windows.Forms.ToolStripMenuItem sobreMenu;
        private System.Windows.Forms.ToolStripMenuItem contatoMenu;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.LinkLabel linkLabelMaps;
        private System.Windows.Forms.PictureBox pictureBoxMap;
    }
}
