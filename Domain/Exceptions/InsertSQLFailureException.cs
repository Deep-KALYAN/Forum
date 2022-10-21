using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InsertSQLFailureException : Exception
    {
        public InsertSQLFailureException(Entity entity) : base($"The insertion of the entity  {entity}")
        {
            //$"L'insertion de l'entité {entity}"
        }

        public InsertSQLFailureException(string message) : base($" {message} : Your email or loginName is in use already")
        {
            //$"L'insertion de l'entité {entity}"
        }
    }
}
