using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;/// <summary>

/// </summary>

namespace Site.Admin
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //destruindo a permissao de acesso
            FormsAuthentication.SignOut();

            //rediirecionamento de voltar a pagina de login
            Response.Redirect("/Pages/Login.aspx");
        }
    }
}