﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReceivingPOSystem.Entities
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            ReceiveOrders = new HashSet<ReceiveOrder>();
        }

        [Key]
        public int PurchaseOrderID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }
        public int VendorID { get; set; }
        public int EmployeeID { get; set; }
        [Column(TypeName = "money")]
        public decimal TaxAmount { get; set; }
        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }
        public bool Closed { get; set; }
        [StringLength(100)]
        public string Notes { get; set; }

        [ForeignKey("VendorID")]
        [InverseProperty("PurchaseOrders")]
        public virtual Vendor Vendor { get; set; }
        [InverseProperty("PurchaseOrder")]
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        [InverseProperty("PurchaseOrder")]
        public virtual ICollection<ReceiveOrder> ReceiveOrders { get; set; }
    }
}