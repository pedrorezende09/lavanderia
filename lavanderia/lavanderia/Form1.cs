using MySql.Data.MySqlClient;
using System.Data;

namespace lavanderia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            MySQL mysql = new MySQL();
            if (!mysql.conectar()) return;
            string nome_cliente = textBoxNome.Text;
            string cpf_cliente = textBoxCPF.Text;
            string peso_roupa_kg = textBoxPeso.Text;
            string valor_total = textBoxValor.Text;
            string tipo_servico = comboBoxServico.Text;
            string query = "INSERT INTO Servicos (nome_cliente, cpf_cliente, peso_roupa_kg, valor_total, tipo_servico)";
            query += "VALUES (@nome_cliente, @cpf_cliente, @peso_roupa_kg, @valor_total, @tipo_servico)";
            MySqlCommand cmd = new MySqlCommand(query, mysql.conexao);
            cmd.Parameters.AddWithValue("@nome_cliente", nome_cliente);
            cmd.Parameters.AddWithValue("@cpf_cliente", cpf_cliente);
            cmd.Parameters.AddWithValue("@tipo_servico", tipo_servico);
            cmd.Parameters.AddWithValue("@peso_roupa_kg", peso_roupa_kg);
            cmd.Parameters.AddWithValue("@valor_total", valor_total);
            try
            {
                cmd.ExecuteNonQuery();
                mysql.desconectar();
                PesquisarRegistros("");
                MessageBox.Show("Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar registro: " + ex.Message);
            }

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MySQL mysql = new MySQL();
            if (!mysql.conectar()) return;
            string nome_cliente = textBoxNome.Text;
            string cpf_cliente = textBoxCPF.Text;
            string peso_roupa_kg = textBoxPeso.Text;
            string valor_total = textBoxValor.Text;
            string id = textBoxID.Text;
            string tipo_servico = comboBoxServico.Text;
            string query = "UPDATE Servicos SET " +
            "nome_cliente = @nome_cliente, " +
            "cpf_cliente = @cpf_cliente, " +
            "peso_roupa_kg = @peso_roupa_kg, " +
            "valor_total = @valor_total, " +
            "tipo_servico = @tipo_servico " +
            "WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, mysql.conexao);
            cmd.Parameters.AddWithValue("@nome_cliente", nome_cliente);
            cmd.Parameters.AddWithValue("@cpf_cliente", cpf_cliente);
            cmd.Parameters.AddWithValue("@tipo_servico", tipo_servico);
            cmd.Parameters.AddWithValue("@valor_total", decimal.Parse(valor_total));
            cmd.Parameters.AddWithValue("@peso_roupa_kg", peso_roupa_kg);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.ExecuteNonQuery();
                mysql.desconectar();
                PesquisarRegistros("");
                MessageBox.Show("Registro editado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar registro: " + ex.Message);
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            MySQL mysql = new MySQL();
            if (!mysql.conectar()) return;
            string query = "DELETE FROM servicos WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, mysql.conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.ExecuteNonQuery();
                mysql.desconectar();
                PesquisarRegistros("");
                MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir registro: " + ex.Message);
            }

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarRegistros("");
        }
        private void PesquisarRegistros(string pesquisa)
        {
            MySQL mysql = new MySQL();
            if (!mysql.conectar()) return;
            string query = $"SELECT * FROM Servicos WHERE id LIKE '%{pesquisa}%'";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, mysql.conexao);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            mysql.desconectar();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                textBoxID.Text = row.Cells["id"].Value.ToString();
                textBoxNome.Text = row.Cells["nome_cliente"].Value.ToString();
                textBoxCPF.Text = row.Cells["cpf_cliente"].Value.ToString();
                textBoxPeso.Text = row.Cells["peso_roupa_kg"].Value.ToString();
                textBoxValor.Text = row.Cells["valor_total"].Value.ToString();
                comboBoxServico.Text = row.Cells["tipo_servico"].Value.ToString();
            }
        }
    }
}
