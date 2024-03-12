using System.ComponentModel;
using System.Linq;

namespace KKInventorySystem.Models
{
    public static class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();

        // Parts
        public static void AddPart(Part part) => AllParts.Add(part);
        public static bool DeletePart(Part part) => AllParts.Remove(part);
        public static Part LookupPart(int partId) => AllParts.FirstOrDefault(p => p.PartID == partId);

        // Products
        public static void AddProduct(Product product) => Products.Add(product);
        public static bool DeleteProduct(Product product) => Products.Remove(product);
        public static Product LookupProduct(int productId) => Products.FirstOrDefault(p => p.ProductID == productId);
    }
}
