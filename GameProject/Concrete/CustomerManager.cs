using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer)==true)
            {
                Console.WriteLine("Added Gamer" + customer.GameName + " " + customer);
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
        }

    }
}
