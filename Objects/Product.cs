using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Objects
{
    public class Product
    {
        // Atributes
        public int Id_Product{get; private set;}
        public string Name_Product{get; private set;}
        public decimal Price_Product{get; private set;}
        public string Lot_Number{get; private set;}
        public DateOnly Batch_Validity{get; private set;}
        public string Barcode{get; private set;}

        // Database will genarete the date using Entitu Framework Core
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Regis_Product{get; private set;}

        protected Product(){}

        public Product(string Name_Product, string Lot_Number, 
            DateOnly Batch_Validity, string Barcode)
        {
            this.Name_Product = Name_Product;
            this.Lot_Number = Lot_Number;
            this.Batch_Validity = Batch_Validity;
            this.Barcode = Barcode;
        }
    }
}