using System;
using System.Collections.Generic;
using System.Text;


namespace TTask1.Implementation
{
    public class MMarket : IStore
    {
       
        private Product[] _products = new Product[0];
        public Product[] products => _products;

        public int ProductLimit { get; set; }
        private double _totalIncome;
        public double TotalIncome { get => _totalIncome; }

        public void AddProduct(Product product)
        {
            if (ProductLimit <= _products.Length)
            {
                throw new FilledException("mm");

                if(FindProductWithNo(product.No)) 
                    throw new ProductWithNoException("ss");
            
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = product;
            }
        }

        public void SellProduct(string no)
        {
            Product product = FindProductWithNo(no);
            if(product != null)
            {
                if (product.Count > 0)
                {
                    _totalIncome += product.Price;
                    product.Count--;
                }
            }

        }

        public Product FindProductWithNo(string no)
        {
            Product product = null;
            foreach (var pr in _products)
            {
                if (pr.No == no)
                {
                    product = pr;
                    break;
                }

            }
            return product;

        }





    }
}
