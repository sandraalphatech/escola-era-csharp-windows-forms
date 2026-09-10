using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Escola_era
{
    public partial class Form1 : Form
    {
      PrintDocument printDocument = new PrintDocument();

        public Form1()
        {
            InitializeComponent();
            CarregarAlunos();
        }

        private void CarregarAlunos()
        {
            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=escola.db"))
            {
                con.Open();

                string sql =
                    "SELECT * FROM Alunos WHERE Ativo = 1";

                SQLiteDataAdapter da =
                    new SQLiteDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvAlunos.DataSource = dt;
            }
        }

        private void ConfigurarGrid()
        {
            dgvAlunos.BorderStyle =
                BorderStyle.None;

            dgvAlunos.BackgroundColor =
                Color.White;

            dgvAlunos.EnableHeadersVisualStyles =
                false;

            dgvAlunos.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvAlunos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 120, 215);

            dgvAlunos.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvAlunos.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold);

            dgvAlunos.ColumnHeadersHeight = 42;

            dgvAlunos.DefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10);

            dgvAlunos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 252);

            dgvAlunos.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            dgvAlunos.RowTemplate.Height = 38;

            dgvAlunos.RowHeadersVisible = false;

            dgvAlunos.AllowUserToAddRows = false;

            dgvAlunos.AllowUserToResizeRows = false;

            dgvAlunos.AllowUserToResizeColumns = false;

            dgvAlunos.MultiSelect = false;

            dgvAlunos.ReadOnly = true;

            dgvAlunos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvAlunos.GridColor =
                Color.Gainsboro;

            dgvAlunos.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvAlunos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            if (dgvAlunos.Columns["Password"] != null)
                dgvAlunos.Columns["Password"].Visible = false;

            if (dgvAlunos.Columns["Ativo"] != null)
                dgvAlunos.Columns["Ativo"].Visible = false;

            if (dgvAlunos.Columns["Nacionalidade"] != null)
                dgvAlunos.Columns["Nacionalidade"].Visible = false;

            if (dgvAlunos.Columns["Localidade"] != null)
                dgvAlunos.Columns["Localidade"].Visible = false;

            dgvAlunos.Columns["ID"].Width = 70;

            dgvAlunos.Columns["Nome"].Width = 180;

            dgvAlunos.Columns["Login"].Width = 160;

            dgvAlunos.Columns["Curso"].Width = 180;

            foreach (DataGridViewColumn coluna in dgvAlunos.Columns)
            {
                coluna.SortMode =
                    DataGridViewColumnSortMode.NotSortable;

                coluna.Resizable =
                    DataGridViewTriState.False;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarAlunos();

            ConfigurarGrid();

            this.BackColor =
                Color.FromArgb(245, 245, 245);

            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um aluno.");
                return;
            }

            int id =
                Convert.ToInt32(
                    dgvAlunos.CurrentRow.Cells["ID"].Value);

            string nome =
                dgvAlunos.CurrentRow.Cells["Nome"].Value.ToString();

            string login =
                dgvAlunos.CurrentRow.Cells["Login"].Value.ToString();

            string password =
                dgvAlunos.CurrentRow.Cells["Password"].Value.ToString();

            string Curso =
                dgvAlunos.CurrentRow.Cells["Curso"].Value.ToString();

            string nacionalidade =
                dgvAlunos.CurrentRow.Cells["Nacionalidade"].Value.ToString();

            string localidade =
                dgvAlunos.CurrentRow.Cells["Localidade"].Value.ToString();

            FormAtualizar form =
                new FormAtualizar(
                    id,
                    nome,
                    login,
                    password,
                    Curso,
                    nacionalidade,
                    localidade);

            form.ShowDialog();

            CarregarAlunos();

            dgvAlunos.Columns["ID"].Width = 60;

            dgvAlunos.Columns["Nome"].Width = 220;

            dgvAlunos.Columns["Curso"].Width = 90;

            dgvAlunos.Columns["Nacionalidade"].Width = 180;

            dgvAlunos.Columns["Localidade"].Width = 160;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionar form = new FormAdicionar();
            form.ShowDialog();

            CarregarAlunos();
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um aluno.");
                return;
            }

            int id =
                Convert.ToInt32(
                    dgvAlunos.CurrentRow.Cells["ID"].Value);

            DialogResult resposta =
                MessageBox.Show(
                    "Deseja desativar este aluno?",
                    "Confirmar",
                    MessageBoxButtons.YesNo);

            if (resposta == DialogResult.No)
                return;

            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=escola.db"))
            {
                con.Open();

                string sql = @"
        UPDATE Alunos
        SET Ativo = 0
        WHERE ID = @ID";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", id);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Aluno desativado!");

            CarregarAlunos();
        }
        
        private void PrintDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
         {
            int y = 100;

            System.Drawing.Font fonte =
                new System.Drawing.Font("Arial", 12);

            e.Graphics.DrawString(
                "Lista de Alunos",
                new System.Drawing.Font( "Arial", 16,FontStyle.Bold),
                Brushes.Black,
                100,
                50);

            foreach (DataGridViewRow row in dgvAlunos.Rows)
            {
                if (row.IsNewRow) continue;

                string linha =
                    row.Cells["Nome"].Value + " | " +
                    row.Cells["Login"].Value + " | " +
                    row.Cells["Curso"].Value;

                e.Graphics.DrawString(
                    linha,
                    fonte,
                    Brushes.Black,
                    100,
                    y);

                y += 30;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview =
                new PrintPreviewDialog();

            preview.Document = printDocument;

            preview.ShowDialog();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog save =
                new SaveFileDialog();

            save.Filter = "PDF (*.pdf)|*.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Document doc =
                    new Document(PageSize.A4);

                PdfWriter.GetInstance(
                    doc,
                    new FileStream(save.FileName, FileMode.Create));

                doc.Open();

                Paragraph titulo =
                    new Paragraph("Lista de Alunos");

                titulo.SpacingAfter = 20f;

                doc.Add(titulo);

                foreach (DataGridViewRow row in dgvAlunos.Rows)
                {
                    if (row.IsNewRow) continue;

                    string linha =
                        row.Cells["Nome"].Value + " | " +
                        row.Cells["Login"].Value + " | " +
                        row.Cells["Curso"].Value;

                    doc.Add(new Paragraph(linha));
                }

                doc.Close();

                MessageBox.Show("PDF exportado!");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save =
                new SaveFileDialog();

            save.Filter = "Excel (*.csv)|*.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw =
                    new StreamWriter(save.FileName))
                {
                    sw.WriteLine(
                        "Nome;Login;Curso;Nacionalidade;Localidade");

                    foreach (DataGridViewRow row in dgvAlunos.Rows)
                    {
                        if (row.IsNewRow) continue;

                        sw.WriteLine(
                            row.Cells["Nome"].Value + ";" +
                            row.Cells["Login"].Value + ";" +
                            row.Cells["Curso"].Value + ";" +
                            row.Cells["Nacionalidade"].Value + ";" +
                            row.Cells["Localidade"].Value);
                    }
                }

                MessageBox.Show("Excel exportado!");
            }
        }

        private void PesquisarAluno()
        {
            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=escola.db"))
            {
                con.Open();

                string sql = @"
        SELECT *
        FROM Alunos
        WHERE
        Nome LIKE @busca
        OR Login LIKE @busca";

                SQLiteDataAdapter da =
                    new SQLiteDataAdapter(sql, con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@busca",
                    "%" + txtPesquisar.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvAlunos.DataSource = dt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle =
                FormBorderStyle.FixedSingle;

            this.WindowState =
                FormWindowState.Maximized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPesquisar_TextChanged(
            object sender,
            EventArgs e)
        {
            PesquisarAluno();
        }

        private void btnPesquisar_Click(
            object sender,
            EventArgs e)
        {
            PesquisarAluno();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
   
}

