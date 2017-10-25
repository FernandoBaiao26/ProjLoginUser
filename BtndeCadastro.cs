using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entity;//endidade
using DAL.Persistence;//classe de persistencia

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();//intanciando a classe de entidade
                u.Nome = txtNome.Text;
                u.Login = txtLogin.Text;
                u.Senha = txtSenha.Text;

                UsuarioDal d = new UsuarioDal();//persistence
                d.Insert(u);//gravação

                //mensagem de gravação
                lblMensagem.Text = "Usuario novo " + u.Nome + ", Cadastrado com sucesso";

            }
            catch(Exception ex)
            {
                //imprimir mensagem de erro
                lblMensagem.Text = ex.Message;
            }


        }
    }
}