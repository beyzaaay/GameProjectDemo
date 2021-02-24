using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("save to db : "+ customer.GameName);
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
