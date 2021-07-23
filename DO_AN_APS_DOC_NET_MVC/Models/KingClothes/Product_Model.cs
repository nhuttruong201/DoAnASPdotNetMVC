﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DO_AN_APS_DOC_NET_MVC.Models.KingClothes
{
    public class Product_Model
    {
        [Key]
        public int Id_Model { get; set; }

        [Display(Name = "Tên Sản Phẩm")]
        public string Name { get; set; }

        [Display(Name = "Mô Tả")]
        public string Describe { get; set; }

        [Display(Name = "Giá")]
        public double Price { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}