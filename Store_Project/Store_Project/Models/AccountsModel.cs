using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Store_Project.Models;
using System.ComponentModel;
using System.Web.Mvc;
using JordanHall.CountryInfo;

namespace Store_Project.Models
{
    public class AccountsModel
    {
        [Key]
        public int AccountID { get; set; }

        public string AccountFirstName { get; set; }

        public string AccountLastName { get; set; }

        public string AccountEmailAddress { get; set; }

        public DateTime AccountBirthDate { get; set; }

        public int AccountMobile { get; set; }

        public int AccountPhone { get; set; }

        public SelectList AccountCityList { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string AccountUserName { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string AccountPassword { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        public string AccountPasswordConfirmation { get; set; }

        //[Required]
        //public tbl_Roles AccountRole { get; set; }

        [ReadOnly(true)]
        [DataType(DataType.DateTime)]
        public DateTime AccountCreateDate = DateTime.Now.Date;
    }
}