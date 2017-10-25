using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entity;//entidade
using DAL.Persistence;//persistencia
using System.Web.Security;/// <summary>
/// 
/// </summary>


namespace Site.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                string Login = txtLogin.Text;//resgatando conteudo do campo

                string Senha = txtSenha.Text;//resgatando conteudo do campo

                UsuarioDal d = new UsuarioDal();//persitence
                Usuario u = d.Find(Login, Senha);
                //verificar se usuario foi encontrado
                if(u != null)//usurio diferente nulo
                {
                    //conceder a permissão de acesso
                    FormsAuthentication.SetAuthCookie(u.Login,false);
                    //cracha de acesso
                    //redirecionar para a pagina do Admin
                    Response.Redirect("/Admin/Home.aspx");
                    //lblMensagem.Text = "Login correto";//provisorio

                }
                else
                {
                    lblMensagem.Text = "Acesso Negado.";
                }

            }
            catch(Exception ex)
            {
                //imprimindo mensagem de erro
                lblMensagem.Text = ex.Message;
            }

        }
    }
}