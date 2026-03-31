using SQLite;
using System.Collections.Generic;

namespace CondominioApp.Data.Models
{
    public class MeetUpType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
        public List<Reuniao> Reunioes { get; set; } = new List<Reuniao>();
    }

    public class Reuniao
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        // Tipo de reunião (Reunião, Assembléia Ordinária, Assembléia Extraordinária)
        public int MeetUpTypeId { get; set; }

        // Síndico responsável pela reunião
        public int SindicoId { get; set; }
    }
}