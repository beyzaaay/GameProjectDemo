using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void CampaniaOrder(Customer customer, Game game, Campania campania)
        {

            Console.WriteLine(customer.GameName + " " + customer.GameSurname + " adlı oyuncu" + " " + game.GameName + " isimli oyunu kampanya fiyatında satın aldı");
        }

        public void Order(Customer customer, Game game)
        {
            Console.WriteLine(customer.GameName + " " + customer.GameSurname + " adlı oyuncu" + " " + game.GameName + " isimli oyunu satın aldı");
        }

       
    }
}
