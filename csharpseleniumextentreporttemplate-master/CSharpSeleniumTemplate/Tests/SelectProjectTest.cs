using CSharpSeleniumTemplate.Bases;
using CSharpSeleniumTemplate.Flows;
using CSharpSeleniumTemplate.Helpers;
using CSharpSeleniumTemplate.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTemplate.Tests
{
    [TestFixture]
   public class SelectProjectTest : TestBase
    {
        #region Pages and Flows Objects
        [AutoInstance] LoginFlows loginFlows;
        [AutoInstance] SelectProjectFlows selectProjectFlows;
        [AutoInstance] ClickManageFlows clickManageFlows;
        [AutoInstance] ProjectPageFlows projectPageFlows;
        [AutoInstance] SelectProjectPage selectProjectPage;
        #endregion

        [Test]
        public void SelecionarProjeto()
        {
            #region Parameters
            string usuario = Properties.Settings.Default.DEFAUL_USER;
            string senha = Properties.Settings.Default.DEFAUL_PASSWORD;
            #endregion

            loginFlows.EfetuarLogin(usuario, senha);
            clickManageFlows.ClicarGerenciar();
            projectPageFlows.ClicarMenuProjeto();
            selectProjectFlows.ClicarProjeto();

            Assert.That(selectProjectPage.ValidarSelectComSucesso());



        }
    }
}
