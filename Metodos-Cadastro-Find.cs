using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;//classe de entidade
using System.Data.SqlClient;//conexao com o banco

namespace DAL.Persistence
{
    public class UsuarioDal: Conexao
    {
        //Metodo para cadastrar Usuario
        public void Insert(Usuario u)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("insert into Usuario(Nome,Login,Senha)values(@v1,@v2,@v3)",Con);
                Cmd.Parameters.AddWithValue("@v1", u.Nome);
                Cmd.Parameters.AddWithValue("@v2",u.Login);
                Cmd.Parameters.AddWithValue("@v3",u.Senha);
                Cmd.ExecuteNonQuery();//executar
            }
            catch
            {
                throw;//deixar o erro correr na web
            }
            finally
            {
                FecharConexao();
            }

            
            
        }
        //Metodo para buscar usuario da base de dados pelo login e senha
        //Select * from usuario where Login@v1 and Senha@v2
        public Usuario Find(string Login, string Senha)
        {
            try
            {
                AbrirConexao();//Abrir a conexao com o banco
                Cmd = new SqlCommand("select * from Usuario where Login=@v1 and Senha=@v2",Con);
                
                Cmd.Parameters.AddWithValue("@v1", Login);
                Cmd.Parameters.AddWithValue("@v2", Senha);
                Dr = Cmd.ExecuteReader();//executar a consulta

                if(Dr.Read())
                {
                    Usuario u = new Usuario();//entidade
                    u.IdUsuario = Convert.ToInt32(Dr["IdUsuario"]);
                    u.Nome = Convert.ToString(Dr["Nome"]);
                    u.Login = Convert.ToString(Dr["Login"]);
                    u.Senha = Convert.ToString(Dr["Senha"]);


                    return u;
                }
                return null;
                
            }
            catch
            {
                throw;
            }
            finally
            {
                FecharConexao();//fechar a conexao
            }
        }
    }
}
