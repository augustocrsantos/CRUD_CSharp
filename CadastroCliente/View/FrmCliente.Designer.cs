namespace CadastroCliente.View
{
    partial class FrmCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.maskedTextBoxNome = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.maskedTextBoxEndereco = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUf = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxCidade = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.labelTotalRegistro = new System.Windows.Forms.Label();
            this.maskedTextBoxDocumento = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonProximo);
            this.panel1.Controls.Add(this.buttonAnterior);
            this.panel1.Controls.Add(this.buttonExcluir);
            this.panel1.Controls.Add(this.buttonInserir);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.buttonPesquisar);
            this.panel1.Location = new System.Drawing.Point(165, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 43);
            this.panel1.TabIndex = 0;
            // 
            // buttonProximo
            // 
            this.buttonProximo.Image = global::CadastroCliente.Properties.Resources.icons8_próximo_32;
            this.buttonProximo.Location = new System.Drawing.Point(218, 4);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(37, 36);
            this.buttonProximo.TabIndex = 6;
            this.buttonProximo.UseVisualStyleBackColor = true;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Image = global::CadastroCliente.Properties.Resources.icons8_anterior_321;
            this.buttonAnterior.Location = new System.Drawing.Point(175, 4);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(37, 36);
            this.buttonAnterior.TabIndex = 5;
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Image = global::CadastroCliente.Properties.Resources.icons8_apagar_para_sempre_32;
            this.buttonExcluir.Location = new System.Drawing.Point(132, 4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(37, 36);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Image = global::CadastroCliente.Properties.Resources.icons8_nova_janela_32;
            this.buttonInserir.Location = new System.Drawing.Point(89, 4);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(37, 36);
            this.buttonInserir.TabIndex = 3;
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = global::CadastroCliente.Properties.Resources.icons8_procurar_usuário_masculino_32;
            this.buttonBuscar.Location = new System.Drawing.Point(46, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(37, 36);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Image = global::CadastroCliente.Properties.Resources.icons8_32;
            this.buttonPesquisar.Location = new System.Drawing.Point(3, 3);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(37, 36);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(111, 175);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // maskedTextBoxNome
            // 
            this.maskedTextBoxNome.Location = new System.Drawing.Point(165, 168);
            this.maskedTextBoxNome.Name = "maskedTextBoxNome";
            this.maskedTextBoxNome.Size = new System.Drawing.Size(261, 20);
            this.maskedTextBoxNome.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maskedTextBoxDocumento);
            this.panel2.Controls.Add(this.labelTotalRegistro);
            this.panel2.Controls.Add(this.maskedTextBoxCodigo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.maskedTextBoxTelefone);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonCancelar);
            this.panel2.Controls.Add(this.buttonSalvar);
            this.panel2.Controls.Add(this.maskedTextBoxEndereco);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxUf);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.maskedTextBoxCidade);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelNome);
            this.panel2.Controls.Add(this.maskedTextBoxNome);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 486);
            this.panel2.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(351, 444);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(165, 444);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // maskedTextBoxEndereco
            // 
            this.maskedTextBoxEndereco.Location = new System.Drawing.Point(165, 352);
            this.maskedTextBoxEndereco.Name = "maskedTextBoxEndereco";
            this.maskedTextBoxEndereco.Size = new System.Drawing.Size(261, 20);
            this.maskedTextBoxEndereco.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Endereco:";
            // 
            // comboBoxUf
            // 
            this.comboBoxUf.FormattingEnabled = true;
            this.comboBoxUf.Location = new System.Drawing.Point(165, 305);
            this.comboBoxUf.Name = "comboBoxUf";
            this.comboBoxUf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUf.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "UF:";
            // 
            // maskedTextBoxCidade
            // 
            this.maskedTextBoxCidade.Location = new System.Drawing.Point(165, 258);
            this.maskedTextBoxCidade.Name = "maskedTextBoxCidade";
            this.maskedTextBoxCidade.Size = new System.Drawing.Size(261, 20);
            this.maskedTextBoxCidade.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefone:";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(165, 397);
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(126, 20);
            this.maskedTextBoxTelefone.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Codigo:";
            // 
            // maskedTextBoxCodigo
            // 
            this.maskedTextBoxCodigo.Location = new System.Drawing.Point(165, 121);
            this.maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            this.maskedTextBoxCodigo.Size = new System.Drawing.Size(95, 20);
            this.maskedTextBoxCodigo.TabIndex = 19;
            // 
            // labelTotalRegistro
            // 
            this.labelTotalRegistro.AutoSize = true;
            this.labelTotalRegistro.Location = new System.Drawing.Point(270, 78);
            this.labelTotalRegistro.Name = "labelTotalRegistro";
            this.labelTotalRegistro.Size = new System.Drawing.Size(0, 13);
            this.labelTotalRegistro.TabIndex = 20;
            // 
            // maskedTextBoxDocumento
            // 
            this.maskedTextBoxDocumento.Location = new System.Drawing.Point(165, 214);
            this.maskedTextBoxDocumento.Name = "maskedTextBoxDocumento";
            this.maskedTextBoxDocumento.Size = new System.Drawing.Size(169, 20);
            this.maskedTextBoxDocumento.TabIndex = 21;
            this.maskedTextBoxDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxDocumento_KeyPress);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 510);
            this.Controls.Add(this.panel2);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.Shown += new System.EventHandler(this.FrmCliente_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalRegistro;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDocumento;
    }
}