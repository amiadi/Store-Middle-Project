using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Store_Project.Models
{
    public class OrdersModel
    {
        [Key]
        public int OrderID { get; set; }

        public Random OrderNumber = new Random(1);

        public DateTime OrderDate = DateTime.Now;

        [Key]
        public AccountsModel AccountID { get; set; }
    }
}