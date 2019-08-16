using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;


namespace acessoBD_incluir
{
    public partial class Form1 : Form
    {
        private OleDbConnection Conn;
        private OleDbDataAdapter da;
        private DataSet ds;
        //nome do banco de dados
        private string bd = "Cadastro.mdb";
        private int linhaAtual = 0;
        //variáveis para os campos da tabela CLientes
        private string codigoID, nome, endereco, cidade, estado, cep, telefone, sobrenome, funcao, bairro, paciente, pais, cpf, celular, telco, email, rg, obs, nascimento, data, titulo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chama rotina para exibir os dados no datagridview
            iniciaAcesso();
        }
        private void iniciaAcesso()
        {
            //define o dataset
            ds = new DataSet();
            //cria uma conexão usando a string de conexão
            Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\dados\\" + bd);
            try
            {
                //abre a conexao
                Conn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            if (Conn.State == ConnectionState.Open)
            {
                //se a conexão estiver aberta usa uma instrução SQL para selecionar os registros da tabela clientes
                //SELECT campos FROM tabela
                da = new OleDbDataAdapter("SELECT * from Clientes", Conn);
                da.Fill(ds, "Tabela");
                //exibe os dados no datagridview
                dgvDados.DataSource = ds;
                dgvDados.DataMember = "Tabela";
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //instancia o formulário para incluir e exibe-o de forma modal
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            iniciaAcesso();
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
        }
        private void obtemDadosGrid()
        {
            //obtem os dados do datagridview da linha selecionada usando as posições das colunas
            //a primeira coluna é a coluna 0 a segunda é a coluna 1 , e , assim por diante
            nome = dgvDados[1, linhaAtual].Value.ToString();
            endereco = dgvDados[2, linhaAtual].Value.ToString();
            cidade = dgvDados[3, linhaAtual].Value.ToString();
            estado = dgvDados[4, linhaAtual].Value.ToString();
            cep = dgvDados[5, linhaAtual].Value.ToString();
            telefone = dgvDados[6, linhaAtual].Value.ToString();
            sobrenome = dgvDados[7, linhaAtual].Value.ToString();
            funcao = dgvDados[8, linhaAtual].Value.ToString();
            bairro = dgvDados[9, linhaAtual].Value.ToString();
            paciente = dgvDados[10, linhaAtual].Value.ToString();
            pais = dgvDados[11, linhaAtual].Value.ToString();
            cpf = dgvDados[12, linhaAtual].Value.ToString();
            celular = dgvDados[13, linhaAtual].Value.ToString();
            telco = dgvDados[14, linhaAtual].Value.ToString();
            email = dgvDados[15, linhaAtual].Value.ToString();
            rg = dgvDados[16, linhaAtual].Value.ToString();
            obs = dgvDados[17, linhaAtual].Value.ToString();
            nascimento = dgvDados[18, linhaAtual].Value.ToString();
            data = dgvDados[19, linhaAtual].Value.ToString();
            titulo = dgvDados[20, linhaAtual].Value.ToString();

            //
        }

        private void carregaGrid(string criterioSQL)
        {
            //define o dataset
            ds = new DataSet();
            //cria uma conexão usando a string de conexão
            Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\dados\\" + bd);
            try
            {
                //abre a conexao
                Conn.Open();
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            if (Conn.State == ConnectionState.Open)
            {
                //se a conexão estiver aberta usa uma instrução SQL para selecionar os registros da tabela clientes
                //SELECT campos FROM tabela
                da = new OleDbDataAdapter(criterioSQL, Conn);
                da.Fill(ds, "Tabela");
                //exibe os dados no datagridview
                dgvDados.DataSource = ds;
                dgvDados.DataMember = "Tabela";
            }

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Cadastro",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();

            f5.ShowDialog();

            if (f5.sqlString != null && f5.sqlString != "")
                carregaGrid(f5.sqlString);
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //obtem o código do cliente a partir da linha selecionada no datagridview
                codigoID = dgvDados[0, linhaAtual].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (linhaAtual >= 0)
            {
                //obtem dados do datagridview e atribui as variáveis definidas no formulario f4
                obtemDadosGrid();
                Form4 f4 = new Form4();
                //
                f4.codigoID = codigoID;
                f4.nome = nome;
                f4.endereco = endereco;
                f4.cidade = cidade;
                f4.estado = estado;
                f4.cep = cep;
                f4.telefone = telefone;
                f4.sobrenome = sobrenome;
                f4.funcao = funcao;
                f4.bairro = bairro;
                f4.paciente = paciente;
                f4.pais = pais;
                f4.cpf = cpf;
                f4.celular = celular;
                f4.telco = telco;
                f4.email = email;
                f4.rg = rg;
                f4.obs = obs;
                f4.nascimento = nascimento;
                f4.data = data;
                f4.titulo = titulo;
                //exibe o formulário para exclusão
                f4.ShowDialog();
                //atualiza o grid e reexibe os dados 
                dgvDados.Update();
                iniciaAcesso();
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //obtem o código do cliente a partir da linha selecionada no datagridview
                codigoID = dgvDados[0, linhaAtual].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (linhaAtual >= 0)
            {
                //obtem dados do datagridview e atribui as variáveis definidas no formulario f3
                obtemDadosGrid();
                Form3 f3 = new Form3();
                //
                f3.codigoID = codigoID;
                f3.nome = nome;
                f3.endereco = endereco;
                f3.cidade = cidade;
                f3.estado = estado;
                f3.cep = cep;
                f3.telefone = telefone;
                f3.sobrenome = sobrenome;
                f3.funcao = funcao;
                f3.bairro = bairro;
                f3.paciente = paciente;
                f3.pais = pais;
                f3.cpf = cpf;
                f3.celular = celular;
                f3.telco = telco;
                f3.email = email;
                f3.rg = rg;
                f3.obs = obs;
                f3.nascimento = nascimento;
                f3.data = data;
                f3.titulo = titulo;

                //exibe o formulário para alteração
                f3.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgvDados.Update();
                iniciaAcesso();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia o formulário para incluir e exibe-o de forma modal
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            iniciaAcesso();
        }

        private void cEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();


            f6.ShowDialog();


            if (f6.sqlString != null && f6.sqlString != "")

                carregaGrid(f6.sqlString);
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();


            f7.ShowDialog();


            if (f7.sqlString != null && f7.sqlString != "")

                carregaGrid(f7.sqlString);
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();


            f8.ShowDialog();


            if (f8.sqlString != null && f8.sqlString != "")

                carregaGrid(f8.sqlString);
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();


            f9.ShowDialog();


            if (f9.sqlString != null && f9.sqlString != "")

                carregaGrid(f9.sqlString);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //obtem o código do cliente a partir da linha selecionada no datagridview
                codigoID = dgvDados[0, linhaAtual].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
            if (linhaAtual >= 0)
            {
                //obtem dados do datagridview e atribui as variáveis definidas no formulario f3
                obtemDadosGrid();
                Form11 f11 = new Form11();
                //
                f11.codigoID = codigoID;
                f11.nome = nome;
                f11.endereco = endereco;
                f11.cidade = cidade;
                f11.estado = estado;
                f11.cep = cep;
                f11.telefone = telefone;
                f11.sobrenome = sobrenome;
                f11.funcao = funcao;
                f11.bairro = bairro;
                f11.paciente = paciente;
                f11.pais = pais;
                f11.cpf = cpf;
                f11.celular = celular;
                f11.telco = telco;
                f11.email = email;
                f11.rg = rg;
                f11.obs = obs;
                f11.nascimento = nascimento;
                f11.data = data;
                f11.titulo = titulo;

                //exibe o formulário para alteração
                f11.ShowDialog();
                //atualiza o grid e reexibe os dados
                dgvDados.Update();
                iniciaAcesso();
            }
        }
