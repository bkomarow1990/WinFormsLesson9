using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Classwork2
{
    public enum Category { Diary = 0 ,Bakery, Congectioners}
    class Product
    {
        string name;
        decimal price;
        uint count;
        public Category ACategory { get; set; } = Category.Bakery;
        public string Name { 
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ApplicationException("Incorrect name");
                }
                name = value;
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                price = value;
            }
        }
        public uint Count
        {
            get => count;
            set
            {
                count = value;
            }
        }
        public string ImageUrl { get; set; }
        public Product(string name, decimal price, uint count, Category category, string imgUrl)
        {
            Name = name;
            Price = price;
            Count = count;
            ACategory = category;
            ImageUrl = imgUrl;
        }
        public Product()
        {

        }
    }
}
