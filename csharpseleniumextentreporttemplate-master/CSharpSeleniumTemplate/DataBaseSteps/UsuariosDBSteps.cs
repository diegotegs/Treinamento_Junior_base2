using CSharpSeleniumTemplate.Helpers;
using CSharpSeleniumTemplate.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeleniumTemplate.DataBaseSteps
{
    public class UsuariosDBSteps
    {
        public static string RetornaSenhaDoUsuario(string username)
        {
            string query = UsuariosQueries.RetornaSenhaUsuario.Replace("$username", username);

            return DataBaseHelpers.RetornaDadosQuery(query)[0];
        }
    }
}
