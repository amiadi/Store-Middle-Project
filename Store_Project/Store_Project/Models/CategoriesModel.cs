using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Store_Project.Models;
using System.ComponentModel;
using System.Web.Mvc;

namespace Store_Project.Models
{
    public class CategoriesModel
    {
        [Key]
        public int Category_ID { get; set; }
        public string Category_Name { get; set; }
        
        [DataType(DataType.Upload)]
        public HttpPostedFileBase Category_ImageName { get; set; }
    }
}