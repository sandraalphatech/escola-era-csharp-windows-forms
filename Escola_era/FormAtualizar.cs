using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Escola_era
{
    using System.Data.SQLite;

    public partial class FormAtualizar : Form
    {
        int idAluno;

        public FormAtualizar(
            int id,
            string nome,
            string login,
            string password,
            string Curso,
            string nacionalidade,
            string localidade)
        {
            InitializeComponent();

            idAluno = id;

            txtNome.Text = nome;
            txtLogin.Text = login;
            txtPassword.Text = password;
            txtCurso.Text = Curso;
            txtNacionalidade.Text = nacionalidade;
            txtLocalidade.Text = localidade;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=escola.db"))
            {
                con.Open();

                string sql = @"
        UPDATE Alunos
        SET
            Nome = @Nome,
            Login = @Login,
            Password = @Password,
            Curso = @Curso,
            Nacionalidade = @Nacionalidade,
            Localidade = @Localidade
        WHERE ID = @ID";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, con);

                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Curso", txtCurso.Text);
                cmd.Parameters.AddWithValue("@Nacionalidade", txtNacionalidade.Text);
                cmd.Parameters.AddWithValue("@Localidade", txtLocalidade.Text);
                cmd.Parameters.AddWithValue("@ID", idAluno);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno atualizado!");
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAtualizar_Load(object sender, EventArgs e)
        {

        }

        private void lbRegisto_Click(object sender, EventArgs e)
        {

        }
    }
}
