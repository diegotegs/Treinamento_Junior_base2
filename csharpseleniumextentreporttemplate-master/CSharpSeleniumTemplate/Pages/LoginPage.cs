using CSharpSeleniumTemplate.Bases;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpSeleniumTemplate.Pages
{
    public class LoginPage : PageBase
    {
        #region Mapping
        By usernameField = By.Id("user_email");
        By passwordField = By.Id("user_password");
        By loginButton = By.Name("commit");
        By msgLogin = By.XPath("//div[@id='general-home']/div/h2");
        #endregion

        #region Actions
        public void PreenhcerUsuario(string usuario)
        {
            SendKeys(usernameField, usuario);
        }

        public void PreencherSenha(string senha)
        {
            SendKeys(passwordField, senha);
        }

        public void ClicarEmLogin()
        {
            Click(loginButton);
        }

       public bool MensagemSucessoLogin()
        {
            return GetText(msgLogin).Contains("tudo bem");
        }
        #endregion
    }
}
