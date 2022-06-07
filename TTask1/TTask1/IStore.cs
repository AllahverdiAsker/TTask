using System;
using System.Collections.Generic;
using System.Text;

namespace TTask1
{
    public interface IStore
    {

        Product[] products { get; }
        int ProductLimit { get; set; }
        double TotalIncome { get;}
        void AddProduct(Product product);
        void SellProduct(string no);
        

        



    }
}
