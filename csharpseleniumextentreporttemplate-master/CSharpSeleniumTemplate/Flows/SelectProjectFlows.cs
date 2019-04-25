using CSharpSeleniumTemplate.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTemplate.Flows
{
   public class SelectProjectFlows
    {
        #region Page Object and Constructor
        SelectProjectPage selectProjectPage;
        #endregion

        public SelectProjectFlows()
        {
            selectProjectPage = new SelectProjectPage();
        }

        public void ClicarProjeto()
        {
            selectProjectPage.SelecionarProjeto();
            
        }
    }
}
