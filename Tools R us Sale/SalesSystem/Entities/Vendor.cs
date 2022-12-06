﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SalesSystem.Entities
{
    internal partial class Vendor
    {
        public Vendor()
        {
            StockItems = new HashSet<StockItem>();
        }

        [Key]
        public int VendorID { get; set; }
        [Required]
        [StringLength(100)]
        public string VendorName { get; set; }
        [Required]
        [StringLength(12)]
        public string Phone { get; set; }
        [Required]
        [StringLength(30)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string City { get; set; }
        [Required]
        [StringLength(2)]
        public string ProvinceID { get; set; }
        [Required]
        [StringLength(6)]
        public string PostalCode { get; set; }

        [ForeignKey("ProvinceID")]
        [InverseProperty("Vendors")]
        public virtual Province Province { get; set; }
        [InverseProperty("Vendor")]
        public virtual ICollection<StockItem> StockItems { get; set; }
    }
}