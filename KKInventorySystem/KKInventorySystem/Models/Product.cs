using System.ComponentModel;
using System.Linq;

namespace KKInventorySystem.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        private static BindingList<Part> associatedParts = new BindingList<Part>();
        public static BindingList<Part> AssociatedParts => associatedParts;

        public Product(int productId, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part) => AssociatedParts.Add(part);
        public bool RemoveAssociatedPart(int partId)
        {
            var part = AssociatedParts.FirstOrDefault(p => p.PartID == partId);
            if (part != null)
            {
                return AssociatedParts.Remove(part);
            }
            return false;
        }
        public Part LookupAssociatedPart(int partId) => AssociatedParts.FirstOrDefault(p => p.PartID == partId);
    }
}
