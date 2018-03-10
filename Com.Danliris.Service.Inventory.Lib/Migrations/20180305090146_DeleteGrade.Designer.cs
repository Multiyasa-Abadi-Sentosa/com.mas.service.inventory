﻿// <auto-generated />
using Com.Danliris.Service.Inventory.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Com.Danliris.Service.Inventory.Lib.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20180305090146_DeleteGrade")]
    partial class DeleteGrade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Danliris.Service.Inventory.Lib.Models.MaterialsRequestNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("AutoIncrementNumber");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Remark")
                        .HasMaxLength(100);

                    b.Property<string>("RequestType")
                        .HasMaxLength(100);

                    b.Property<string>("Type");

                    b.Property<string>("UnitCode")
                        .HasMaxLength(100);

                    b.Property<string>("UnitId")
                        .HasMaxLength(100);

                    b.Property<string>("UnitName")
                        .HasMaxLength(100);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("MaterialsRequestNotes");
                });

            modelBuilder.Entity("Com.Danliris.Service.Inventory.Lib.Models.MaterialsRequestNote_Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<double>("Length");

                    b.Property<int>("MaterialsRequestNoteId");

                    b.Property<double>("OrderQuantity");

                    b.Property<string>("OrderTypeCode")
                        .HasMaxLength(100);

                    b.Property<string>("OrderTypeId")
                        .HasMaxLength(100);

                    b.Property<string>("OrderTypeName")
                        .HasMaxLength(100);

                    b.Property<string>("ProductCode")
                        .HasMaxLength(100);

                    b.Property<string>("ProductId")
                        .HasMaxLength(100);

                    b.Property<string>("ProductName")
                        .HasMaxLength(100);

                    b.Property<string>("ProductionOrderId")
                        .HasMaxLength(100);

                    b.Property<string>("ProductionOrderNo")
                        .HasMaxLength(100);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("MaterialsRequestNoteId");

                    b.ToTable("MaterialsRequestNote_Items");
                });

            modelBuilder.Entity("Com.Danliris.Service.Inventory.Lib.Models.MaterialsRequestNote_Item", b =>
                {
                    b.HasOne("Com.Danliris.Service.Inventory.Lib.Models.MaterialsRequestNote", "MaterialsRequestNote")
                        .WithMany("MaterialsRequestNote_Items")
                        .HasForeignKey("MaterialsRequestNoteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
