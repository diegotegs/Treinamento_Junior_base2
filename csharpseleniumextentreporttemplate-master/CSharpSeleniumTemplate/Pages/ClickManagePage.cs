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
    public class ClickManagePage : PageBase
    {
        #region Mapping
        By msgLogin = By.XPath("//div[@id='general-home']/div/h2");
        By manageProject = By.LinkText("Gerencie seus projetos aqui");
       public By selectProject = By.Id("selected_project");
        #endregion

        #region Actions
        public void ClicarGerencieProjeto()
        {
            Click(manageProject);
        }
        public bool ClicarComSucesso()
        {
           return ReturnIfElementIsDisplayed(selectProject);
        }
        #endregion
    }
}
