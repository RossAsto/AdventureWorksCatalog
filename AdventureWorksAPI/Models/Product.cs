//Create a new class called Product and add the following properties
//ProductID,Name,ProductNumber,StandardCost, ListPrice

namespace AdventureWorksAPI.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
    }
}




