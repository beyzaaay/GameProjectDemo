using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    partial class Program
    {
        private static Customer customer;
        private static Game game;
        private static Campania campania;

        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(new Customer { DateOfBirth = new DateTime(2000, 8, 3), GameName = "Beyza Nur", GameSurname = "Ay", NationalityId = "12345" });

            CampaniaManager campaniaManager = new CampaniaManager();
            campaniaManager.Add(new Campania { CampaniaId = 1, CampaniaName = "Yıl Sonu İndirimi", DiscountRate = 0.50M });

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { GameId = 1, GameName = "Among us", GamePrice = 200 });

           
           
            

        }
    }
}
