﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace GridDIsplayBLL
{
    public class ProductRepository : IProductRepository
    {
        readonly private GridDisplayEntities _dbContext;

        public ProductRepository()
        {
            this._dbContext = new GridDisplayEntities();
        }

        public List<Product> GetProducts(string filter)
        {
            if (String.IsNullOrEmpty(filter))
            {
                var allProducts = from pc in _dbContext.Products
                    from p in pc.Categories

                    select pc;

                return allProducts.ToList();
            }

            var filteredProducts = from pc in _dbContext.Products
                from p in pc.Categories
                where pc.Name.StartsWith(filter)
                select pc;

            return filteredProducts.ToList();
        }

        public void Archive(int productId)
        {
            Product product = _dbContext.Products.Find(productId);
            product.Archived = true;
            _dbContext.SaveChanges();
        }

        public void Create(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
        
        public List<Product> Details(int productId)
        {
            return _dbContext.Products.Find(productId);
        }
        
        public List<Category> GetCategories(int id)
        {
            var xy = from pc in _dbContext.Categories 
                     from p in pc.Products 
                     
                     select p;

            return _dbContext.Categories.ToList();
        }


        public List<Category> GetCategories()
        {
            return _dbContext.Categories.ToList();
        }


        public Category GetCategory(int id)
        {
            return _dbContext.Categories.FirstOrDefault(item => item.CategoryId == id);
        }
    }
}
