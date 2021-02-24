using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapter
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        ICustomerCheckService _customerCheckService;
        public bool CheckIfRealPerson(Customer customer)
        {
            _customerCheckService = new MernisServiceAdapter();
            return true;
        }
    }
}
