using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoF.Modelos
{
    [Table("usuarios")]
    class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100), Unique]
        public String Username { get; set; }
        [MaxLength(100), Unique]
        public String Email { get; set; }
        [MaxLength(70)]
        public String Password { get; set; }
    }
}
