namespace GerenciadorVeiculos
{
    partial class Form1
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecoBase = new System.Windows.Forms.TextBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(140, 72);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(229, 20);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.Text = "Campo para digitar o modelo do veículo";
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(140, 201);
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Size = new System.Drawing.Size(229, 20);
            this.txtPrecoBase.TabIndex = 1;
            this.txtPrecoBase.Text = "Campo para digitar o preço base";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(140, 322);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(229, 20);
            this.txtParametro.TabIndex = 2;
            this.txtParametro.Text = "Campo para portas ou cilindradas";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.cmbTipo.Location = new System.Drawing.Point(570, 71);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(567, 148);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(212, 13);
            this.lblParametro.TabIndex = 4;
            this.lblParametro.Text = "Rótulo que mudará de texto dinamicamente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(570, 222);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(209, 46);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Botão com o texto \"Salvar Veículo\"";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1074, 538);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.txtPrecoBase);
            this.Controls.Add(this.txtModelo);
            this.Name = "Form1";
            this.Text = "Rótulo que mudará de texto dinamicamente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPrecoBase;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Button btnSalvar;
    }
}

