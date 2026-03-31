using SQLite;
using SQliteNetExtensions.Attributes;
using ForeignKey = SQliteNetExtensions.Attributes.ForeignKeyAttribute;

Nomespace CondominioApp.Data.Models
{
    public class MeetUpType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }
        public List<Meetup> meetups { get; set; }
    }

    public class Reuniao
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }
        
        public string Content { get; set; }

        /***
        * Tipo de reunião (Reunião, Assembléia Ordinária, Assembléia Extraordinária)
        ***/
        [ForeignKey(typeof(meetUpType))]
        public int MeetUpTypeId { get; set; }

        [ManyToOne]
        public MeetUpType meetUpType { get; set; }

        /***
        * Síndico responsável pela reunião
        ***/
        [ForeignKey(typeof(trustee))]
        public int SindicoId { get; set; }
        [ManyToOne]
        public Sindico trustee { get; set; }
    }
}