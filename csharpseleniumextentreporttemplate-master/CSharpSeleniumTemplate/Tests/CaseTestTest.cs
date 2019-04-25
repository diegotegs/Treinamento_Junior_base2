using CSharpSeleniumTemplate.Bases;
using CSharpSeleniumTemplate.Flows;
using CSharpSeleniumTemplate.Helpers;
using CSharpSeleniumTemplate.Pages;
using NUnit.Framework;


namespace CSharpSeleniumTemplate.Tests
{
    [TestFixture]
    class CaseTestTest :TestBase
    {
        #region Pages and Flows Objects
        [AutoInstance] LoginFlows loginFlows;
        [AutoInstance] SelectProjectFlows selectProjectFlows;
        [AutoInstance] ClickManageFlows clickManageFlows;
        [AutoInstance] ProjectPageFlows projectPageFlows;
        [AutoInstance] CaseTestPage casoTestPage;
        #endregion

        #region Actions
        [Test]
        public void ValidarExistenciaCasoDeTest()
        {
            #region Parameters
            string usuario = Properties.Settings.Default.DEFAUL_USER;
            string senha = Properties.Settings.Default.DEFAUL_PASSWORD;
            #endregion

            loginFlows.EfetuarLogin(usuario,senha);

            clickManageFlows.ClicarGerenciar();

            projectPageFlows.ClicarMenuProjeto();

            selectProjectFlows.ClicarProjeto();

            casoTestPage.ClicarCasoDeTeste();     
            
            Assert.AreNotEqual("Nenhum caso de teste encontrado",casoTestPage.ValidarExisteCasoDeTest());


        }
        #endregion
    }
}
