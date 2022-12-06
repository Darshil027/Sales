﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ReceivingPOSystem.Entities;

namespace ReceivingPOSystem.DAL
{
    public partial class eTools2021Context : DbContext
    {
        public eTools2021Context()
        {
        }

        public eTools2021Context(DbContextOptions<eTools2021Context> options)
            : base(options)
        {
        }

        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<ReceiveOrder> ReceiveOrders { get; set; }
        public virtual DbSet<ReceiveOrderDetail> ReceiveOrderDetails { get; set; }
        public virtual DbSet<ReturnedOrderDetail> ReturnedOrderDetails { get; set; }
        public virtual DbSet<StockItem> StockItems { get; set; }
        public virtual DbSet<UnOrderedItem> UnOrderedItems { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.VendorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrdersVendors_VendorID");
            });

            modelBuilder.Entity<PurchaseOrderDetail>(entity =>
            {
                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderDetails)
                    .HasForeignKey(d => d.PurchaseOrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetailsPurchaseOrders_OrderID");

                entity.HasOne(d => d.StockItem)
                    .WithMany(p => p.PurchaseOrderDetails)
                    .HasForeignKey(d => d.StockItemID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderDetailsStockItems_StockItemID");
            });

            modelBuilder.Entity<ReceiveOrder>(entity =>
            {
                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.ReceiveOrders)
                    .HasForeignKey(d => d.PurchaseOrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiveOrdersPurchaseOrders_OrderID");
            });

            modelBuilder.Entity<ReceiveOrderDetail>(entity =>
            {
                entity.HasOne(d => d.PurchaseOrderDetail)
                    .WithMany(p => p.ReceiveOrderDetails)
                    .HasForeignKey(d => d.PurchaseOrderDetailID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiveOrderDetailsPurchaseOrderDetails_OrderDetailID");

                entity.HasOne(d => d.ReceiveOrder)
                    .WithMany(p => p.ReceiveOrderDetails)
                    .HasForeignKey(d => d.ReceiveOrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiveOrderDetailsReceiveOrders_ReceiveOrderID");
            });

            modelBuilder.Entity<ReturnedOrderDetail>(entity =>
            {
                entity.HasOne(d => d.PurchaseOrderDetail)
                    .WithMany(p => p.ReturnedOrderDetails)
                    .HasForeignKey(d => d.PurchaseOrderDetailID)
                    .HasConstraintName("FK_ReturnedOrderDetailsPurchaseOrderDetails_OrderDetailID");

                entity.HasOne(d => d.ReceiveOrder)
                    .WithMany(p => p.ReturnedOrderDetails)
                    .HasForeignKey(d => d.ReceiveOrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReturnedOrderDetailsReceiveOrders_ReceiveOrder");
            });

            modelBuilder.Entity<StockItem>(entity =>
            {
                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.StockItems)
                    .HasForeignKey(d => d.VendorID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemsVendors_VendorID");
            });

            modelBuilder.Entity<UnOrderedItem>(entity =>
            {
                entity.HasKey(e => e.ItemID)
                    .HasName("PK_UnOrderedItems_ItemID");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.PostalCode).IsFixedLength();

                entity.Property(e => e.ProvinceID).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}