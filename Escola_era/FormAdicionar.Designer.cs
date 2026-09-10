namespace Escola_era
{
    partial class FormAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionar));
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelLocalidade = new System.Windows.Forms.Label();
            this.labelNacionalidade = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRegisto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidade.Location = new System.Drawing.Point(138, 282);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(189, 24);
            this.txtLocalidade.TabIndex = 23;
            this.txtLocalidade.TextChanged += new System.EventHandler(this.txtLocalidade_TextChanged);
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidade.Location = new System.Drawing.Point(138, 242);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(189, 24);
            this.txtNacionalidade.TabIndex = 22;
            // 
            // txtCurso
            // 
            this.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(138, 202);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(189, 24);
            this.txtCurso.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(138, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(189, 24);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(138, 122);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(189, 24);
            this.txtLogin.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(138, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 24);
            this.txtNome.TabIndex = 18;
            // 
            // labelLocalidade
            // 
            this.labelLocalidade.AutoSize = true;
            this.labelLocalidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLocalidade.ForeColor = System.Drawing.Color.DimGray;
            this.labelLocalidade.Location = new System.Drawing.Point(81, 285);
            this.labelLocalidade.Name = "labelLocalidade";
            this.labelLocalidade.Size = new System.Drawing.Size(43, 19);
            this.labelLocalidade.TabIndex = 17;
            this.labelLocalidade.Text = "Local:";
            // 
            // labelNacionalidade
            // 
            this.labelNacionalidade.AutoSize = true;
            this.labelNacionalidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNacionalidade.ForeColor = System.Drawing.Color.DimGray;
            this.labelNacionalidade.Location = new System.Drawing.Point(32, 245);
            this.labelNacionalidade.Name = "labelNacionalidade";
            this.labelNacionalidade.Size = new System.Drawing.Size(97, 19);
            this.labelNacionalidade.TabIndex = 16;
            this.labelNacionalidade.Text = "Nacionalidade:";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCurso.ForeColor = System.Drawing.Color.DimGray;
            this.labelCurso.Location = new System.Drawing.Point(81, 207);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(48, 19);
            this.labelCurso.TabIndex = 15;
            this.labelCurso.Text = "Curso:";
            this.labelCurso.Click += new System.EventHandler(this.labelCurso_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPassword.ForeColor = System.Drawing.Color.DimGray;
            this.labelPassword.Location = new System.Drawing.Point(81, 167);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(49, 19);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Senha:";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.labelLogin.Location = new System.Drawing.Point(84, 127);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(46, 19);
            this.labelLogin.TabIndex = 13;
            this.labelLogin.Text = "Login:";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNome.ForeColor = System.Drawing.Color.DimGray;
            this.labelNome.Location = new System.Drawing.Point(81, 87);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(49, 19);
            this.labelNome.TabIndex = 12;
            this.labelNome.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(72, 339);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 40);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(213, 339);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lbRegisto);
            this.panel1.Controls.Add(this.txtLocalidade);
            this.panel1.Controls.Add(this.labelLocalidade);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.labelNacionalidade);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.labelCurso);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.txtCurso);
            this.panel1.Controls.Add(this.labelLogin);
            this.panel1.Controls.Add(this.txtNacionalidade);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Location = new System.Drawing.Point(236, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 411);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbRegisto
            // 
            this.lbRegisto.AutoSize = true;
            this.lbRegisto.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbRegisto.ForeColor = System.Drawing.Color.DimGray;
            this.lbRegisto.Location = new System.Drawing.Point(118, 33);
            this.lbRegisto.Name = "lbRegisto";
            this.lbRegisto.Size = new System.Drawing.Size(190, 25);
            this.lbRegisto.TabIndex = 27;
            this.lbRegisto.Text = "Registo de Formando";
            // 
            // FormAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormAdicionar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelLocalidade;
        private System.Windows.Forms.Label labelNacionalidade;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRegisto;
    }
}