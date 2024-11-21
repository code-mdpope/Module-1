using System;
using System.Collections.Generic;

namespace BasicPOS
{
    public class POSManager<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _productDictionary;

        public POSManager()
        {
            _productDictionary = new Dictionary<TKey, TValue>();
        }

        
        public void Create(TKey price, TValue productName)
        {
            if (_productDictionary.ContainsKey(price))
            {
                Console.WriteLine($"Product with price {price} already exists.");
            }
            else
            {
                _productDictionary.Add(price, productName);
                Console.WriteLine($"Product added: {price} -> {productName}");
            }
        }

        
        public void Read()
        {
            if (_productDictionary.Count == 0)
            {
                Console.WriteLine("No products available.");
            }
            else
            {
                Console.WriteLine("\nProduct List:");
                foreach (var product in _productDictionary)
                {
                    Console.WriteLine($"Price: {product.Key}, Name: {product.Value}");
                }
            }
        }

       
        public void Update(TKey price, TValue newProductName)
        {
            if (_productDictionary.ContainsKey(price))
            {
                _productDictionary[price] = newProductName;
                Console.WriteLine($"Product updated: {price} -> {newProductName}");
            }
            else
            {
                Console.WriteLine($"Product with price {price} does not exist.");
            }
        }

        
        public void Delete(TKey price)
        {
            if (_productDictionary.ContainsKey(price))
            {
                _productDictionary.Remove(price);
                Console.WriteLine($"Product with price {price} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Product with price {price} does not exist.");
            }
        }
    }
}