﻿using THLTWEB_LAB3.Models;
using System.Collections.Generic;
namespace THLTWEB_LAB3.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
