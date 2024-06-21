namespace Tela_Principal
{
    partial class frmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butSaida = new System.Windows.Forms.Button();
            this.butEntrada = new System.Windows.Forms.Button();
            this.butCadastroUsuario = new System.Windows.Forms.Button();
            this.butRegistraProduto = new System.Windows.Forms.Button();
            this.butBackup = new System.Windows.Forms.Button();
            this.butGerarRelatorio = new System.Windows.Forms.Button();
            this.butCadastroProduto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 721);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tela_Principal.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butSaida
            // 
            this.butSaida.BackColor = System.Drawing.SystemColors.Highlight;
            this.butSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSaida.Location = new System.Drawing.Point(1435, 279);
            this.butSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butSaida.Name = "butSaida";
            this.butSaida.Size = new System.Drawing.Size(289, 257);
            this.butSaida.TabIndex = 1;
            this.butSaida.Text = "Saida";
            this.butSaida.UseVisualStyleBackColor = false;
            // 
            // butEntrada
            // 
            this.butEntrada.BackColor = System.Drawing.SystemColors.Highlight;
            this.butEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEntrada.Location = new System.Drawing.Point(1435, 542);
            this.butEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butEntrada.Name = "butEntrada";
            this.butEntrada.Size = new System.Drawing.Size(289, 257);
            this.butEntrada.TabIndex = 1;
            this.butEntrada.Text = "Entrada";
            this.butEntrada.UseVisualStyleBackColor = false;
            // 
            // butCadastroUsuario
            // 
            this.butCadastroUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.butCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCadastroUsuario.Location = new System.Drawing.Point(1140, 279);
            this.butCadastroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCadastroUsuario.Name = "butCadastroUsuario";
            this.butCadastroUsuario.Size = new System.Drawing.Size(289, 257);
            this.butCadastroUsuario.TabIndex = 1;
            this.butCadastroUsuario.Text = "Cadastro Usuario";
            this.butCadastroUsuario.UseVisualStyleBackColor = false;
            // 
            // butRegistraProduto
            // 
            this.butRegistraProduto.BackColor = System.Drawing.SystemColors.Highlight;
            this.butRegistraProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegistraProduto.Location = new System.Drawing.Point(1140, 542);
            this.butRegistraProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butRegistraProduto.Name = "butRegistraProduto";
            this.butRegistraProduto.Size = new System.Drawing.Size(289, 257);
            this.butRegistraProduto.TabIndex = 1;
            this.butRegistraProduto.Text = "Registrar Produto";
            this.butRegistraProduto.UseVisualStyleBackColor = false;
            // 
            // butBackup
            // 
            this.butBackup.BackColor = System.Drawing.SystemColors.Highlight;
            this.butBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBackup.Location = new System.Drawing.Point(845, 279);
            this.butBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butBackup.Name = "butBackup";
            this.butBackup.Size = new System.Drawing.Size(289, 257);
            this.butBackup.TabIndex = 1;
            this.butBackup.Text = "Backup";
            this.butBackup.UseVisualStyleBackColor = false;
            // 
            // butGerarRelatorio
            // 
            this.butGerarRelatorio.BackColor = System.Drawing.SystemColors.Highlight;
            this.butGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGerarRelatorio.Location = new System.Drawing.Point(845, 542);
            this.butGerarRelatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butGerarRelatorio.Name = "butGerarRelatorio";
            this.butGerarRelatorio.Size = new System.Drawing.Size(289, 257);
            this.butGerarRelatorio.TabIndex = 1;
            this.butGerarRelatorio.Text = "Gerar Relatorio";
            this.butGerarRelatorio.UseVisualStyleBackColor = false;
            // 
            // butCadastroProduto
            // 
            this.butCadastroProduto.BackColor = System.Drawing.SystemColors.Highlight;
            this.butCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCadastroProduto.Location = new System.Drawing.Point(549, 542);
            this.butCadastroProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butCadastroProduto.Name = "butCadastroProduto";
            this.butCadastroProduto.Size = new System.Drawing.Size(289, 257);
            this.butCadastroProduto.TabIndex = 1;
            this.butCadastroProduto.Text = "Cadastro Produto";
            this.butCadastroProduto.UseVisualStyleBackColor = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Tela_Principal.Properties.Resources.azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.butCadastroProduto);
            this.Controls.Add(this.butGerarRelatorio);
            this.Controls.Add(this.butBackup);
            this.Controls.Add(this.butRegistraProduto);
            this.Controls.Add(this.butCadastroUsuario);
            this.Controls.Add(this.butEntrada);
            this.Controls.Add(this.butSaida);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butSaida;
        private System.Windows.Forms.Button butEntrada;
        private System.Windows.Forms.Button butCadastroUsuario;
        private System.Windows.Forms.Button butRegistraProduto;
        private System.Windows.Forms.Button butBackup;
        private System.Windows.Forms.Button butGerarRelatorio;
        private System.Windows.Forms.Button butCadastroProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

