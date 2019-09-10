using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    //My First Sample to learn Git Command and features. Atul Purohit learning 10th Sep, 2019
    public class CartItem : ILineItem
    {
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}