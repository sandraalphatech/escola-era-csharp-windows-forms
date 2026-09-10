using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Escola_era
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();

            CriarBanco();

            this.StartPosition =
                FormStartPosition.CenterScreen;

            txtPassword.UseSystemPasswordChar = true;
        }

        private void CriarBanco()
        {
            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=escola.db"))
            {
                con.Open();

                string sqlUsuarios = @"
        CREATE TABLE IF NOT EXISTS Usuarios(
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            Login TEXT,
            Password TEXT,
            Tipo TEXT,
            Ativo INTEGER DEFAULT 1
        )";

                SQLiteCommand cmdUsuarios =
                    new SQLiteCommand(sqlUsuarios, con);

                cmdUsuarios.ExecuteNonQuery();

                string sqlAdmin = @"
        INSERT INTO Usuarios
        (
            Login,
            Password,
            Tipo,
            Ativo
        )

        SELECT
            'admin',
            '123',
            'Administrador',
            1

        WHERE NOT EXISTS
        (
            SELECT 1
            FROM Usuarios
            WHERE Login = 'admin'
        )";

                SQLiteCommand cmdAdmin =
                    new SQLiteCommand(sqlAdmin, con);

                cmdAdmin.ExecuteNonQuery();

                string sqlAlunos = @"
              CREATE TABLE IF NOT EXISTS Alunos(
              ID INTEGER PRIMARY KEY AUTOINCREMENT,
              Nome TEXT,Login TEXT, Password TEXT, Curso TEXT,Nacionalidade TEXT, Localidade TEXT, Ativo INTEGER DEFAULT 1)";

                SQLiteCommand cmdAlunos =
                    new SQLiteCommand(sqlAlunos, con);

                cmdAlunos.ExecuteNonQuery();
            }
        }

        private void btnEntrar_Click(
            object sender,
            EventArgs e)
        {
            using (SQLiteConnection con =
                new SQLiteConnection("Data Source=escola.db"))
            {
                con.Open();

                string sql = @"
        SELECT COUNT(*)
        FROM Usuarios
        WHERE
            Login = @Login
            AND Password = @Password
            AND Ativo = 1";

                SQLiteCommand cmd =
                    new SQLiteCommand(sql, con);

                cmd.Parameters.AddWithValue(
                    "@Login",
                    txtLogin.Text);

                cmd.Parameters.AddWithValue(
                    "@Password",
                    txtPassword.Text);

                int resultado =
                    Convert.ToInt32(
                        cmd.ExecuteScalar());

                if (resultado > 0)
                {
                    Form1 form = new Form1();

                    form.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Login inválido.");
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
