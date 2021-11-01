using Domain_Repository.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication_Repository
{
    public class MechanicalApplication
    {
        public static List<MechanicalDTO> mechanicals()
        {
            return Data_Repository.Mechanical_Repository.MechanicalRepository.mechanicals();
        }
        public static bool Addmechanicals(MechanicalDTO mechanical)
        {
            return Data_Repository.Mechanical_Repository.MechanicalRepository.AddMechanical(mechanical);
        }
        public static bool DisableMechanical(int id)
        {
            return Data_Repository.Mechanical_Repository.MechanicalRepository.DisableMechanical(id);
        }
        public static bool EnableMechanical(int id)
        {
            return Data_Repository.Mechanical_Repository.MechanicalRepository.EnableMechanical(id);
        }
    }
}
