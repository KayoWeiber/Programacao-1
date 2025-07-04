using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula_03_07_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nome = "";
            string email = "";
            int id;
            cliente.ListarClientes();
            Console.Write("Alteração por ID\nQual ID a ser alterado: ");
            id = int.Parse(Console.ReadLine());
            cliente.AlteraCliente(id);


            Console.Write("Exclusão por ID\nQual ID a ser excluido: ");
            id = int.Parse(Console.ReadLine());
            cliente.Excluir(id);


            cliente incluir = new cliente();
            Console.Write("Incluir registro\nDigite o nome: "); nome = Console.ReadLine();
            Console.Write("Digite o e-mail: "); email = Console.ReadLine();
            incluir.Nome = nome;
            incluir.Email = email;
            cliente.InserirCliente(incluir);

            cliente.ListarClientes();
            Console.Write("Qual nome buscar? ");nome=Console.ReadLine();
            cliente.BuscarClientes(nome);

            



           // MySqlConnection conexao = bdcomum.fazconexao(); //faz a conexão com a classe do banco de dados

            //try
            //{
            //    conexao.Open();
            //    Console.WriteLine("Conectado");
            //    MySqlCommand cmd = new MySqlCommand();
            //    cmd.Connection = conexao;
            //    cmd.CommandText = "Select * from clientes limit 1";
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows) {
            //        dr.Read();
            //        cliente pessoa = new cliente();
            //        pessoa.PreencherCliente(dr);
            //        pessoa.Mostrar();
            //    }
            //    conexao.Close();
            //}catch(MySqlException erro)
            //{
            //    Console.WriteLine(erro.Message);
            //    return;
            //}
        }
    }
}
