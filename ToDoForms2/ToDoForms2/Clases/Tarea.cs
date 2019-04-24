using System;
using SQLite;

namespace ToDoForms2.Clases
{
    public class Tarea
    {
        [PrimaryKey, AutoIncrement,Column("_id")]
        public int id { get; set; }

        [MaxLength(150)]
        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        public bool Completada { get; set; }

    }
}
