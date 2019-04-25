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
    public class ProjectPage : PageBase
    {
        #region       
        By selectProject = By.XPath("//td[2]");      
        By menuProject = By.XPath("//a[2]/li/div");        
        #endregion

        #region Actions
        public void ClicarProjeto()
        {
            Click(menuProject);
        } 

        public bool ValidarMenuProjeto()
        {
            return ReturnIfElementIsDisplayed(selectProject);
        }
       

        #endregion
    }
}
