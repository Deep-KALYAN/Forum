using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class UpdateSQLFailureException : Exception
    {
       
        public UpdateSQLFailureException(Entity entity) : base($"The update of the entity {entity} has failed")
        {
            //L'update de l'entité {entity} à échouée"
        }

        public UpdateSQLFailureException() : base($"An error occurred while processing your request.")
        {
            //L'update de l'entité {entity} à échouée"
        }
    }
}
