using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpSeleniumTemplate.Bases;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CSharpSeleniumTemplate.Pages
{
    public class CaseTestPage : PageBase
    {
        #region maping
        By caseTest = By.XPath("//li[@id='li-test-cases-link']/a/span");
        By iconTrash = By.XPath("//td[5]/a[3]");
        By msgTabEmpty = By.XPath("//div[2]/div[2]/div/table/tbody/tr/td");
        #endregion

        #region Actions
        public void ClicarCasoDeTeste()
        {
            Click(caseTest);
        }
        public void ClicarLixeira()
        {
            Click(iconTrash);
        }
        
        public string ValidarExisteCasoDeTest()
        {
            return GetText(msgTabEmpty);
        }
        #endregion

    }
}

