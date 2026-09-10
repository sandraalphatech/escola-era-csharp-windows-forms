using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Escola_era
{
    public partial class FormAdicionar : Form
    {
        public FormAdicionar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=escola.db"))
            {
                con.Open();

                string sql = @"
        INSERT INTO Alunos
        (
            Nome,
            Login,
            Password,
            Curso,
            Nacionalidade,
            Localidade,
            Ativo
        )
        VALUES
        (
            @Nome,
            @Login,
            @Password,
            @Curso,
            @Nacionalidade,
            @Localidade,
            1
        )";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, con);

                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Curso", txtCurso.Text);
                cmd.Parameters.AddWithValue("@Nacionalidade", txtNacionalidade.Text);
                cmd.Parameters.AddWithValue("@Localidade", txtLocalidade.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno salvo com sucesso!");
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdicionar_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCurso_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
