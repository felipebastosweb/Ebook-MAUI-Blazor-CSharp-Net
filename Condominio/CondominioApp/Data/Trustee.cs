using SQLite;
using SQliteNetExtensions.Attributes;
using ForeignKey = SQliteNetExtensions.Attributes.ForeignKeyAttribute;

namespace CondominioApp.Data
{
    // Síndico do Condomínio
    public class CondominiumTrustee
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }

        // Contact Data
        public string Email { get; set; }
        public string Telephone { get; set; }

        public string NumberID { get; set; } // RG
        public string FederalNumberID { get; set; } // CPF

        [ForeignKey(typeof(condominium))]
        public int CondominiumId { get; set; }

        [ManyToOne]
        public virtual Condominium condominium { get; set; }

    }
}