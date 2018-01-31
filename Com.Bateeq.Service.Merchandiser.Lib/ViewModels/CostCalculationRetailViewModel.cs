﻿using Com.Bateeq.Service.Merchandiser.Lib.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Com.Bateeq.Service.Merchandiser.Lib.ViewModels
{
    public class CostCalculationRetailViewModel : BasicViewModel, IValidatableObject
    {
        public string Code { get; set; }
        public string RO { get; set; }

        public string Article { get; set; }
        public StyleVM Style { get; set; }
        public SeasonVM Season { get; set; }
        public BuyerVM Buyer { get; set; }

        public SizeRangeVM SizeRange { get; set; }
        public double? SH_Cutting { get; set; }
        public double? SH_Sewing { get; set; }
        public double? SH_Finishing { get; set; }

        public DateTime DeliveryDate { get; set; }
        public int? Quantity { get; set; }
        public EfficiencyVM Efficiency { get; set; }
        public double? Risk { get; set; }
        public string Description { get; set; }

        public OLVM OL { get; set; }
        public OTL1VM OTL1 { get; set; }
        public OTL2VM OTL2 { get; set; }
        public OTL3VM OTL3 { get; set; }

        public List<CostCalculationRetail_MaterialVM> CostCalculationRetail_Materials { get; set; }
        public double? HPP { get; set; }
        public double? WholesalePrice { get; set; }
                     
        public double? Proposed20 { get; set; }
        public double? Proposed21 { get; set; }
        public double? Proposed22 { get; set; }
        public double? Proposed23 { get; set; }
        public double? Proposed24 { get; set; }
        public double? Proposed25 { get; set; }
        public double? Proposed26 { get; set; }
        public double? Proposed27 { get; set; }
        public double? Proposed28 { get; set; }
        public double? Proposed29 { get; set; }
        public double? Proposed30 { get; set; }
                     
        public double? Rounding20 { get; set; }
        public double? Rounding21 { get; set; }
        public double? Rounding22 { get; set; }
        public double? Rounding23 { get; set; }
        public double? Rounding24 { get; set; }
        public double? Rounding25 { get; set; }
        public double? Rounding26 { get; set; }
        public double? Rounding27 { get; set; }
        public double? Rounding28 { get; set; }
        public double? Rounding29 { get; set; }
        public double? Rounding30 { get; set; }
        public double? RoundingOthers { get; set; }

        public class CostCalculationRetail_MaterialVM
        {
            public int? Id { get; set; }
            public string Code { get; set; }
            public CategoryVM Category { get; set; }
            public MaterialVM Material { get; set; }
            public string Description { get; set; }
            public double? Quantity { get; set; }
            public UOMQuantityVM UOMQuantity { get; set; }
            public double? Price { get; set; }
            public UOMPriceVM UOMPrice { get; set; }
            public double? Conversion { get; set; }
            public double? Total { get; set; }
            public class CategoryVM
            {
                public int? Id { get; set; }
                public string Name { get; set; }
                public string SubCategory { get; set; }
            }
            public class MaterialVM
            {
                public int? Id { get; set; }
                public string Name { get; set; }
            }
            public class UOMQuantityVM
            {
                public int? Id { get; set; }
                public string Name { get; set; }
            }
            public class UOMPriceVM
            {
                public int? Id { get; set; }
                public string Name { get; set; }
            }
        }
        
        public class StyleVM
        {
            public string _id { get; set; }
            public string name { get; set; }
        }

        public class SeasonVM
        {
            public string _id { get; set; }
            public string code { get; set; }
            public string name { get; set; }
        }

        public class BuyerVM
        {
            public int? Id { get; set; }
            public string Name { get; set; }
        }

        public class SizeRangeVM
        {
            public int? Id { get; set; }
            public string Name { get; set; }
        }

        public class EfficiencyVM
        {
            public int? Id { get; set; }
            public double? Value { get; set; }
        }

        public class OLVM
        {
            public int? Id { get; set; }
            public double? Rate { get; set; }
            public double? CalculatedRate { get; set; }
        }

        public class OTL1VM
        {
            public int? Id { get; set; }
            public double? Rate { get; set; }
            public double? CalculatedRate { get; set; }
        }

        public class OTL2VM
        {
            public int? Id { get; set; }
            public double? Rate { get; set; }
            public double? CalculatedRate { get; set; }
        }

        public class OTL3VM
        {
            public int? Id { get; set; }
            public double? Rate { get; set; }
            public double? CalculatedRate { get; set; }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(this.Article))
                yield return new ValidationResult("Nama Artikel harus diisi", new List<string> { "Article" });
            if (this.Style == null || string.IsNullOrWhiteSpace(this.Style._id))
                yield return new ValidationResult("Style harus diisi", new List<string> { "Style" });
            if (this.Season == null || string.IsNullOrWhiteSpace(this.Season._id))
                yield return new ValidationResult("Season harus diisi", new List<string> { "Season" });
            if (this.Buyer == null || this.Buyer.Id == 0)
                yield return new ValidationResult("Buyer harus diisi", new List<string> { "Buyer" });
            if (this.SizeRange == null || this.SizeRange.Id == 0)
                yield return new ValidationResult("Size Range harus diisi", new List<string> { "SizeRange" });
            if (this.SH_Cutting == null)
                yield return new ValidationResult("SH Cutting harus diisi", new List<string> { "SH_Cutting" });
            else if (this.SH_Cutting <= 0)
                yield return new ValidationResult("SH Cutting harus lebih besar dari 0", new List<string> { "SH_Cutting" });
            if (this.SH_Sewing == null)
                yield return new ValidationResult("SH Sewing harus diisi", new List<string> { "SH_Sewing" });
            else if (this.SH_Sewing <= 0)
                yield return new ValidationResult("SH Sewing harus lebih besar dari 0", new List<string> { "SH_Sewing" });
            if (this.SH_Finishing == null)
                yield return new ValidationResult("SH Finishing harus diisi", new List<string> { "SH_Finishing" });
            else if (this.SH_Finishing <= 0)
                yield return new ValidationResult("SH Finishing harus lebih besar dari 0", new List<string> { "SH_Finishing" });
            if (this.DeliveryDate == null || this.DeliveryDate == DateTime.MinValue)
                yield return new ValidationResult("Delivery Date harus diisi", new List<string> { "DeliveryDate" });
            else if (this.DeliveryDate < DateTime.Now.ToUniversalTime())
                yield return new ValidationResult("Delivery Date harus lebih besar dari sekarang", new List<string> { "DeliveryDate" });
            if (this.Quantity == null)
                yield return new ValidationResult("Kuantitas harus diisi", new List<string> { "Quantity" });
            else if (this.Quantity <= 0)
                yield return new ValidationResult("Kuantitas harus lebih besar dari 0", new List<string> { "Quantity" });
            else if (this.Efficiency == null || this.Efficiency.Id == 0)
                yield return new ValidationResult("Tidak ditemukan Efisiensi pada kuantitas ini", new List<string> { "Quantity" });

            int Count = 0;
            string costCalculationRetail_MaterialsError = "[";

            if (this.CostCalculationRetail_Materials == null || this.CostCalculationRetail_Materials.Count.Equals(0))
                yield return new ValidationResult("Tabel Cost Calculation Retail Material dibawah harus diisi", new List<string> { "CostCalculationRetail_MaterialTable" });
            else
            {
                foreach (CostCalculationRetail_MaterialVM costCalculation_Material in this.CostCalculationRetail_Materials)
                {
                    costCalculationRetail_MaterialsError += "{";
                    if (costCalculation_Material.Category == null || costCalculation_Material.Category.Id == 0)
                    {
                        Count++;
                        costCalculationRetail_MaterialsError += "Category: 'Kategori harus diisi', ";
                    }
                    else
                    {
                        if (costCalculation_Material.Material == null || costCalculation_Material.Material.Id == 0)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "Material: 'Material harus diisi', ";
                        }

                        if (costCalculation_Material.Quantity == null)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "Quantity: 'Kuantitas harus diisi', ";
                        }
                        else if (costCalculation_Material.Quantity <= 0)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "Quantity: 'Kuantitas harus lebih besar dari 0', ";
                        }

                        if (costCalculation_Material.Price == null)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "Price: 'Harga harus diisi', ";
                        }
                        else if (costCalculation_Material.Price <= 0)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "Price: 'Harga harus lebih besar dari 0', ";
                        }

                        if (costCalculation_Material.Conversion == null)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "Conversion: 'Konversi harus diisi', ";
                        }
                        else if (costCalculation_Material.Conversion <= 0)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "Conversion: 'Konversi harus lebih besar dari 0', ";
                        }

                        if (costCalculation_Material.UOMQuantity == null || costCalculation_Material.UOMQuantity.Id == 0)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "UOMQuantity: 'Satuan Kuantitas harus diisi', ";
                        }

                        if (costCalculation_Material.UOMPrice == null || costCalculation_Material.UOMPrice.Id == 0)
                        {
                            Count++;
                            costCalculationRetail_MaterialsError += "UOMPrice: 'Satuan Harga harus diisi', ";
                        }
                    }
                    costCalculationRetail_MaterialsError += "},";
                }
            }
            
            costCalculationRetail_MaterialsError += "]";

            if (Count > 0)
            {
                yield return new ValidationResult(costCalculationRetail_MaterialsError, new List<string> { "CostCalculationRetail_Materials" });
            }
        }
    }
}