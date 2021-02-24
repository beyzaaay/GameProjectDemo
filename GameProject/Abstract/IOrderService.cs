using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void Order(Customer customer, Game game);
        void CampaniaOrder(Customer customer, Game game, Campania campania);
    }
}
