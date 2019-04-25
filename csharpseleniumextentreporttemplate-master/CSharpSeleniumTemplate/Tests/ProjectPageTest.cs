using NUnit.Framework;
using CSharpSeleniumTemplate.Bases;
using CSharpSeleniumTemplate.Helpers;
using CSharpSeleniumTemplate.Flows;
using CSharpSeleniumTemplate.Pages;

namespace CSharpSeleniumTemplate.Tests
{
    [TestFixture]
    class ProjectTest : TestBase
    {
        #region Pages and Flows Objects
        [AutoInstance] ProjectPageFlows projectPageFlows;
        [AutoInstance] LoginFlows loginFlows;
        [AutoInstance] ClickManageFlows clickManageFlows;
        [AutoInstance] ProjectPage projectPage;

        #endregion

        #region Actions
        [Test]
        public void ClicarMenuProjeto()
        {
            #region Parameters
            string usuario = Properties.Settings.Default.DEFAUL_USER;
            string senha = Properties.Settings.Default.DEFAUL_PASSWORD;
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            clickManageFlows.ClicarGerenciar();
            projectPageFlows.ClicarMenuProjeto();

            Assert.That(projectPage.ValidarMenuProjeto());

        }

        #endregion
    }
}
