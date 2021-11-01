using Domain_Repository.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication_Repository.Order_Presentation
{
    public class ApplicationOrder
    {
        public static List<OrderDTO> order()
        {
            return Data_Repository.OrderRepository.OrderRepository.ShowOrders();
        }
        public static List<cbbOrderDTO> cbbm()
        {
            return Data_Repository.OrderRepository.OrderRepository.cbbm();
        }
        public static List<cbbOrderDTO> cbbs()
        {
            return Data_Repository.OrderRepository.OrderRepository.cbbs();
        }
        public static List<cbbOrderDTO> cbbcc()
        {
            return Data_Repository.OrderRepository.OrderRepository.cbbCC();
        }
        public static List<cbbOrderDTO> cbbCar()
        {
            return Data_Repository.OrderRepository.OrderRepository.cbbCars();
        }
        public static bool PlaceOrder(cbbOrderDTO order)
        {
            return Data_Repository.OrderRepository.OrderRepository.PlaceOrder(order);
        }
    }
}
