﻿using WebShopModel.Model;

namespace RESTAPI.BusinesslogicLayer
{
    public interface IProductdata
    {
      //  Order? Get(int id);
        List<Product> Get();

        /*
        int Add(Product orderToAdd);
        bool Put(Product orderToUpdate);
        bool Delete (int id);*/
        
    }
}
