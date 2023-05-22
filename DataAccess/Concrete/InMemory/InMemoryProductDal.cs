using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal 
    {

        List<Product> _products;


        public InMemoryProductDal()
        {
             _products=new List<Product> {
                
                new Product{ProductId=1,CategoryId=1,ProductName="BArdak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=3,ProductName="telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=3,CategoryId=3,ProductName="klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=3,CategoryId=3,ProductName="fare",UnitPrice=85,UnitsInStock=1},

            };
        }
        public void Add(Product produt)
        {

            _products.Add(produt);
        }

        public void Delete(Product produt)
        {
            Product producToDelete = null;
            producToDelete = _products.SingleOrDefault(p=>p.ProductId==produt.ProductId);

            _products.Remove(producToDelete);
            
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product produt)
        {
           Product producToUpdate = _products.SingleOrDefault(p => p.ProductId == produt.ProductId);
            producToUpdate.ProductName=produt.ProductName;  
            producToUpdate.CategoryId=produt.CategoryId;    
            producToUpdate.ProductId=produt.ProductId;
            producToUpdate.UnitsInStock=produt.UnitsInStock;    
        }
        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(p=>p.CategoryId==CategoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
