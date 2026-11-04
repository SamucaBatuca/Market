using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Market.Objects;
{
    
}


namespace Market.Relations
{
    public class Invoice
    {
        // Atributes
        [Key]
        public int Id_Invoice { get; private set; }

        public DateOnly Invoice_Date { get; private set; }
        public decimal Invoice_Value { get; private set; }
        public int Invoice_Quantity { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Regis_Invoice { get; private set; }

        // Relations
        public int Fk_Id_Supplier { get; private set; }
        
        [ForeignKey("Fk_Id_Supplier")]
        public Supplier Supplier { get; private set; } // Navegation Property

        public int Fk_Id_Product { get; private set; }
        
        [ForeignKey("Fk_Id_Product")]
        public Product Product { get; private set; } 
        // Methods
        protected Invoice() { }

        public Invoice(DateOnly Invoice_Date, decimal Invoice_Value, 
            int Invoice_Quantity, int Fk_Id_Supplier, int Fk_Id_Product)
        {
            this.Invoice_Date = Invoice_Date;
            this.Invoice_Value = Invoice_Value;
            this.Invoice_Quantity = Invoice_Quantity;
            this.Fk_Id_Supplier = Fk_Id_Supplier;
            this.Fk_Id_Product = Fk_Id_Product;
        }


    }
}