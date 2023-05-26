using SQLite;
using SQliteNetExtensions.Attributes;
using ForeignKey = SQliteNetExtensions.Attributes.ForeignKeyAttribute;

namespace CondominioApp.Data
{
    public class Condominium
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        
        [OneToOne]
        public virtual CondominiumTrustee trusteeActive { get; set; } // Síndico

        [OneToMany]
        public virtual List<CondominiumTrustee> trusteeHistoric { get; set; } // Lista histórica de Síndicos

        [OneToMany]
        public List<CondominiumUnity> Units { get; set; } // Unidades do condomínio
    }

}
