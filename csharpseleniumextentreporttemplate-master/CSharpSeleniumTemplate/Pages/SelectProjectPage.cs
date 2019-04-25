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
   public class SelectProjectPage : PageBase
    {
        #region        
        By selectProject = By.XPath("//td[2]");
        By caseTest = By.XPath("//li[@id='li-test-cases-link']/a/span");
        #endregion

        #region Actions       
        public void SelecionarProjeto()
        {
            Click(selectProject);
        }
        public bool ValidarSelectComSucesso()
        {
            return ReturnIfElementIsDisplayed(caseTest);
        }

        #endregion
    }
}

 
