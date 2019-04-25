using CSharpSeleniumTemplate.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTemplate.Flows
{
   public class  ClickManageFlows
    {
        #region Page Object and Constructor
        ClickManagePage clickManagePage;
        #endregion

        public ClickManageFlows()
        {
            clickManagePage = new ClickManagePage();
        }

        public void ClicarGerenciar()
        {
            clickManagePage.ClicarGerencieProjeto();
            
        }
    }
}
