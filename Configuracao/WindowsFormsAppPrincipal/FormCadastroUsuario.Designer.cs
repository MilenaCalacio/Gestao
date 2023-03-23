namespace WindowsFormsAppPrincipal
{
    partial class FormCadastroUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.confirmacaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 62);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(44, 16);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(249, 62);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(41, 16);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(478, 62);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(33, 16);
            cPFLabel.TabIndex = 7;
            cPFLabel.Text = "CPF";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(12, 119);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(91, 16);
            nomeUsuarioLabel.TabIndex = 11;
            nomeUsuarioLabel.Text = "Nome usuário";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(249, 119);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(46, 16);
            senhaLabel.TabIndex = 13;
            senhaLabel.Text = "Senha";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSalvar.Location = new System.Drawing.Point(527, 251);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonCancelar.Location = new System.Drawing.Point(620, 251);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(10, 81);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(217, 22);
            this.nomeTextBox.TabIndex = 4;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(252, 81);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(223, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(481, 81);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(210, 22);
            this.cPFTextBox.TabIndex = 8;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(636, 138);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(76, 22);
            this.ativoCheckBox.TabIndex = 10;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(9, 138);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(218, 22);
            this.nomeUsuarioTextBox.TabIndex = 12;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(252, 138);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(200, 22);
            this.senhaTextBox.TabIndex = 14;
            // 
            // confirmacaoTextBox
            // 
            this.confirmacaoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.confirmacaoTextBox.Location = new System.Drawing.Point(458, 138);
            this.confirmacaoTextBox.Name = "confirmacaoTextBox";
            this.confirmacaoTextBox.Size = new System.Drawing.Size(172, 22);
            this.confirmacaoTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Confirmação de senha";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(715, 43);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = " Cadastro de usuário";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 294);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmacaoTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de usuário";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox confirmacaoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}