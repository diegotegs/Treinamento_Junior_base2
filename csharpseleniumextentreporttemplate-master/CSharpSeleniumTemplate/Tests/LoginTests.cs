using CSharpSeleniumTemplate.Bases;
using CSharpSeleniumTemplate.DataBaseSteps;
using CSharpSeleniumTemplate.Flows;
using CSharpSeleniumTemplate.Helpers;
using CSharpSeleniumTemplate.Pages;
using NUnit.Framework;


namespace CSharpSeleniumTemplate.Tests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        #region Pages and Flows Objects
        [AutoInstance] LoginFlows loginFlows;
        [AutoInstance] LoginPage loginPage;
        #endregion
      

        #region Actions
        [Test]
        public void EfetuarLoginComSucesso()
        {
            #region Parameters
            string usuario = Properties.Settings.Default.DEFAUL_USER;
            string senha = Properties.Settings.Default.DEFAUL_PASSWORD;         
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            Assert.That(loginPage.MensagemSucessoLogin());
           
        }

     
        #endregion
    }
}





