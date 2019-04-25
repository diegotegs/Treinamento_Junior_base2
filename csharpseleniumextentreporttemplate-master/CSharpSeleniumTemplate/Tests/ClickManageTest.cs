using NUnit.Framework;
using CSharpSeleniumTemplate.Helpers;
using CSharpSeleniumTemplate.Bases;
using CSharpSeleniumTemplate.Flows;
using CSharpSeleniumTemplate.Pages;

namespace CSharpSeleniumTemplate.Tests
{
    [TestFixture]
    class ClickManageTest : TestBase
    {
       
        #region Pages and Flows Objects
        [AutoInstance] ClickManageFlows clickManageFlows;
        [AutoInstance] LoginFlows loginFlows;
        [AutoInstance] ClickManagePage clickManagePage;
        #endregion

        #region Actions
        [Test]
        public void ClicarEmGerenciar()
        {
            #region Parameters
            string usuario = Properties.Settings.Default.DEFAUL_USER;
            string senha = Properties.Settings.Default.DEFAUL_PASSWORD;
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            clickManageFlows.ClicarGerenciar();

            Assert.True(clickManagePage.ClicarComSucesso());
        }
        #endregion
    }
}
