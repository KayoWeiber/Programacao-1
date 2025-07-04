using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula_03_07_2025
{
    internal class bdcomum
    {
        public static MySqlConnection fazconexao()
        {
            return new MySqlConnection("server=localhost;port=3306;database=aula25;uid=root;pwd=;"); //removi a senha "pwd";
        }
            
    }
}
