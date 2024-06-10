using MongoDB.Driver;
using ProjMongoDBAPI10062024.Models;
using ProjMongoDBAPI10062024.Utils;

namespace ProjMongoDBAPI10062024.Services
{
    public class CustomerService
    {
        private readonly IMongoCollection<Customer> _customer;
        public CustomerService(IProjMongoDBAPIDataBaseSettings settings) { 
        
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _customer = database.GetCollection<Customer>(settings.CustomerCollectionName);
        }

        public List<Customer> Get() => _customer.Find(customer => true).ToList();
        public Customer Get(string id) => _customer.Find<Customer>(customer => customer.Id == id).FirstOrDefault();

        public Customer Create(Customer customer)
        {
            _customer.InsertOne(customer);
            return customer;
        }
        
    }
}
