using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Acesso ao banco
using DAL.Entity;//classe de entidade
using System.Configuration;//bibilioteca de configuracao da connectionstring

namespace DAL.Persistence
{ 

     public class Conexao
    {
        public SqlConnection Con;
        public SqlCommand Cmd;
        public SqlDataReader Dr;

        //Metodos 
        public void AbrirConexao()
        {
            
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["aula9"].ConnectionString);
            Con.Open();//conexao aberta
        }

        public void FecharConexao()
        {
            Con.Close();//Conexao fechada
        }
    }
}
