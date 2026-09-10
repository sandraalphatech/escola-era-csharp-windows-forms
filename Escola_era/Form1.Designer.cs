namespace Escola_era
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDesativar = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAtualizar.Location = new System.Drawing.Point(3, 135);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(214, 45);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDesativar
            // 
            this.btnDesativar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDesativar.FlatAppearance.BorderSize = 0;
            this.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesativar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesativar.ForeColor = System.Drawing.Color.DimGray;
            this.btnDesativar.Location = new System.Drawing.Point(3, 195);
            this.btnDesativar.Name = "btnDesativar";
            this.btnDesativar.Size = new System.Drawing.Size(214, 45);
            this.btnDesativar.TabIndex = 14;
            this.btnDesativar.Text = "Desativar";
            this.btnDesativar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDesativar.UseVisualStyleBackColor = false;
            this.btnDesativar.Click += new System.EventHandler(this.btnDesativar_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(3, 3);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(607, 435);
            this.dgvAlunos.TabIndex = 15;
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 65);
            this.label1.TabIndex = 16;
            this.label1.Text = "Escola Era";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.AliceBlue;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.DimGray;
            this.btnImprimir.Location = new System.Drawing.Point(3, 255);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(214, 45);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.DimGray;
            this.btnPDF.Location = new System.Drawing.Point(3, 315);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(214, 45);
            this.btnPDF.TabIndex = 18;
            this.btnPDF.Text = "Exportar .pdf";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.DimGray;
            this.btnExcel.Location = new System.Drawing.Point(3, 375);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(214, 45);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "Exportar .csv";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(887, 120);
            this.pnlHeader.TabIndex = 20;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.icon1);
            this.pnlMenu.Controls.Add(this.btnAtualizar);
            this.pnlMenu.Controls.Add(this.btnAdicionar);
            this.pnlMenu.Controls.Add(this.btnDesativar);
            this.pnlMenu.Controls.Add(this.btnPDF);
            this.pnlMenu.Controls.Add(this.btnExcel);
            this.pnlMenu.Controls.Add(this.btnImprimir);
            this.pnlMenu.Location = new System.Drawing.Point(0, 156);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 532);
            this.pnlMenu.TabIndex = 21;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DimGray;
            this.btnSair.Location = new System.Drawing.Point(3, 435);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(214, 45);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // icon1
            // 
            this.icon1.BackColor = System.Drawing.Color.Transparent;
            this.icon1.Image = ((System.Drawing.Image)(resources.GetObject("icon1.Image")));
            this.icon1.Location = new System.Drawing.Point(91, 3);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(45, 42);
            this.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon1.TabIndex = 16;
            this.icon1.TabStop = false;
            this.icon1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAdicionar.Location = new System.Drawing.Point(3, 75);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(214, 45);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.dgvAlunos);
            this.pnlConteudo.Location = new System.Drawing.Point(252, 195);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(613, 441);
            this.pnlConteudo.TabIndex = 22;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(283, 156);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(429, 27);
            this.txtPesquisar.TabIndex = 23;
            this.txtPesquisar.Text = "\r\n";
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(728, 156);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(87, 29);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 683);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDesativar;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

