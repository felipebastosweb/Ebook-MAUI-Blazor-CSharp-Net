using SQLite;
using SQliteNetExtensions.Attributes;
using ForeignKey = SQliteNetExtensions.Attributes.ForeignKeyAttribute;

namespace CondominioApp.Data
{
    
    public class CondominiumUnit
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string PropertyOwner { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        [ForeignKey(typeof(condominium))]
        public int CondominiumId { get; set; }

        [ManyToOne]
        public virtual Condominium condominium { get; set; }
    }
}