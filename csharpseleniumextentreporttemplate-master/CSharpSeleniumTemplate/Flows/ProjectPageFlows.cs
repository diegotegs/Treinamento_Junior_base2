using CSharpSeleniumTemplate.Bases;
using CSharpSeleniumTemplate.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTemplate.Flows
{
    public class ProjectPageFlows 
    {
        #region Page Object and Constructor
        ProjectPage projectPage;
        #endregion
        public ProjectPageFlows()
        {
            projectPage = new ProjectPage();
        }
        public void ClicarMenuProjeto()
        {
            projectPage.ClicarProjeto();
            
        }
    }
}
