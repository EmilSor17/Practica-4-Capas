using Domain_Repository.DTOs;
using System.Collections.Generic;

namespace Aplication_Repository.Service_Presentation
{
    public class Service_Presentation
    {
        public static List<ServiceDTO> ShowService()
        {
            return Data_Repository.Services_Repository.ServicesRepository.service();
        }
        public static bool AddService(ServiceDTO service)
        {
            return Data_Repository.Services_Repository.ServicesRepository.AddService(service);
        }
        public static bool DisableService(int id)
        {
            return Data_Repository.Services_Repository.ServicesRepository.DisableService(id);
        }
        public static bool EnableService(int id)
        {
            return Data_Repository.Services_Repository.ServicesRepository.EnableService(id);
        }

    }
}
