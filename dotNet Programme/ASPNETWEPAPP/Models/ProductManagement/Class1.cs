using ASPwebApps.Models.ProductManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPwebApps.Models.ProductManagement
{
    public interface IProductDB
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<Product> GetAllProducts();
    }

    public static class ProductFactory
    {
        public static IProductDB GetComponent() => new ProductDB();
    }
    class ProductDB : IProductDB
    {
        static ProductEntities context = new ProductEntities();
        public void AddProduct(Product product)
        {
            context.ASPProducts.Add(product);
            context.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var found = context.ASPProducts.First((p) => p.ProductId == id);
            context.ASPProducts.Remove(found);
            context.SaveChanges();
        }

        public List<Product> GetAllProducts() => context.ASPProducts.ToList();

        public void UpdateProduct(Product product)
        {
            var found = context.ASPProducts.First((p) => p.ProductId == product.ProductId);
            found.ProductImage = product.Image;
            found.ProductName = product.ProductName;
            found.ProductPrice = product.;
            found.Quantity = product.Quantity;
            context.SaveChanges();
        }
    }
}
