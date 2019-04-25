using CSharpSeleniumTemplate.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTemplate.Flows
{
    public class LoginFlows
    {
        #region Page Object and Constructor
        LoginPage loginPage;     
        
        public LoginFlows()
        {
            loginPage = new LoginPage();
        }
        #endregion

        public void EfetuarLogin(string usuario, string senha)
        {
            loginPage.PreenhcerUsuario(usuario);
            loginPage.PreencherSenha(senha);
            loginPage.ClicarEmLogin();
            }
               
    }
}
