using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Raktar
{
    public class Product
    {
        //Adattagok
        [Key]
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public bool IsAvailable { get; set; }
        public string Supplier { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
