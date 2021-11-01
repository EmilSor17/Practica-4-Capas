using Domain_Repository.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication_Repository.Client_Presentation
{
    public class ClientPresentation
    {
        public static List<ClientDTO> ShowClient()
        {
            return Data_Repository.Client_Repository.ClientRepository.ShowClient();
        }
        public static bool AddClient(ClientDTO client)
        {
            return Data_Repository.Client_Repository.ClientRepository.Addclient(client);
        }
        public static bool DisableClient(int id)
        {
            return Data_Repository.Client_Repository.ClientRepository.Disableclient(id);
        }
        public static bool EnableClient(int id)
        {
            return Data_Repository.Client_Repository.ClientRepository.Enableclient(id);
        }
    }
}
