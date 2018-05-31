using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetAspMvcEcommerce.Models
{
    public interface IServiceClients
    {

        IEnumerable<Client> getClients();
        Client getClient(int? id);
        void putClient(Client client);
        void postClient(Client client);
        void deleteClient(int id);

        Client getClient(String login);

    }
}