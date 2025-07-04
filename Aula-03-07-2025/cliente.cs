using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace Aula_03_07_2025
{
    public class cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("{0}\t{1}\t{2}", this.Id, this.Nome, this.Email);
        }
        public void PreencherCliente(MySqlDataReader dados)
        {
            this.Id = int.Parse(dados["id"].ToString());
            this.Nome = dados["nome"].ToString();
            this.Email = dados["email"].ToString();
        }
        public static void ListarClientes()
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from clientes";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Console.WriteLine("Lista todos os clientes");
                    Console.WriteLine("Id\tNome\tE-mail");
                    while (dr.Read())
                    {
                        cliente pessoa = new cliente();
                        pessoa.PreencherCliente(dr);
                        pessoa.Mostrar();
                    }
                    dr.Close();
                    cn.Close();
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
                Environment.Exit(0); //fecha programa
            }
        }
        public static void BuscarClientes(string nome)
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from clientes where nome like '%" + nome + "%'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Console.WriteLine("Lista o cliente");
                    Console.WriteLine("Id\tNome\tE-mail");
                    while (dr.Read())
                    {
                        cliente pessoa = new cliente();
                        pessoa.PreencherCliente(dr);
                        pessoa.Mostrar();
                    }
                    dr.Close();
                    cn.Close();
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado!");
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
                Environment.Exit(0); //fecha programa
            }
        }
        public static void InserirCliente(cliente novo)
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Insert into clientes(nome, email) values('" + novo.Nome + "', '" + novo.Email + "')";
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
                Environment.Exit(0); //fecha programa }

            }

        }
        public static void Excluir(int id)
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "delete from clientes where id = " + id;
                cmd.ExecuteNonQuery ();
                Console.WriteLine("Excluido o id: " + id);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
                Environment.Exit(0); //fecha programa }

            }
        }
        public static void AlteraCliente(int id)
        {
            MySqlConnection cn = bdcomum.fazconexao();
            try
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from clientes where id = "+id;
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string nome = "";
                    String email = "";
                    Console.Write("Nome: {0}\nNovo Nome (em branco para não alterar):");
                    nome=Console.ReadLine();
                    Console.Write("email: {0}\nNovo Nome (em branco para não alterar):");
                    email = Console.ReadLine();
                    dr.Close();
                    string sql = "update clientes set ";
                    if (nome == "" & email == "")
                    {
                        Console.WriteLine("Nenhuma alterãção realizada");
                        return;
                    }
                    else
                    {
                        if(nome != "")
                        {
                            sql += "nome+ '" + nome + "'";
                            if(email != "")
                            {
                                sql += ",";
                            }
                        }
                        
                        if(email != "")
                        {
                            sql += " email= '" + email + "' ";
                        }
                    }
                    sql += " where id = "+id;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Cliente {0} alterado",id);
                    cn.Close();
                }
                else
                {
                    Console.WriteLine("Cliente com id {0} não encontrado!",id.ToString());
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Impossível conectar.\n" + ex.Message);
                Environment.Exit(0); //fecha programa }

            }
        }
    }
}
