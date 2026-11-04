using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Objects
{
    public class Supplier
    {
        // Atributes
        [Key]
        public int Id_Supplier { get; private set; }
        public string CNPJ_Supplier { get; private set; }
        public string Name_Supplier { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Regis_Supplier { get; private set; }

        // Methods
        protected Supplier() { }

        public Supplier(string CNPJ_Supplier, string Name_Supplier)
        {
            this.CNPJ_Supplier = CNPJ_Supplier;
            this.Name_Supplier = Name_Supplier;
        }
    }
}