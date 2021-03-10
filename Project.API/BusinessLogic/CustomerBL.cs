using Project.API.DataAccess;
using Project.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.API.BusinessLogic
{
    public class CustomerBL
    {
        public IEntityRepository<Customer> _customerRepository { get; set; }
        public CustomerBL(IEntityRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetActiveCustomers()
        {
            var result = new List<Customer>();
            result = _customerRepository.GetAllQueryable().Where(s => s.IsDeleted == false).ToList();
            return result;
        }
        public bool GetActiveCustomers(Customer customer)
        {
            var isAdded = false;
            try
            {
                _customerRepository.Insert(customer);
                isAdded = true;
            }
            catch (Exception ex)
            {
                isAdded = false;
                throw new Exception("GetActiveCustomers",ex);
            }
            return isAdded;
        }
    }
}
