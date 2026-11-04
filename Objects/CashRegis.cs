using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Objects
{
    public class CashRegister
    {
        // Atributes
        [Key]
        public int Id_CashRegister { get; private set; }
        public decimal Total_Sales { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public DateTime Last_Update { get; private set; }

        // Methods
        protected CashRegister() { }

        public CashRegister(decimal Total_Sales, DateTime Last_Update)
        {
            this.Total_Sales = Total_Sales;
            this.Last_Update = Last_Update;
        }
    }
}

