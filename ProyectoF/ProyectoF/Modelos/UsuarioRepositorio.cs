using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoF.Modelos
{
    class UsuarioRepositorio
    {
        private SQLiteConnection con;
        private static UsuarioRepositorio instancia;
        public static UsuarioRepositorio Instancia
        {
            get
            {
                if (instancia == null)
                    throw new Exception("Debe llamar al inicializador, acción detenida");
                return instancia;
            }
        }
        public static void Inicializador(String filename)
        {
            if (filename == null)
            {
                throw new ArgumentException();
            }
            if (instancia != null)
            {
                instancia.con.Close();
            }
            instancia = new UsuarioRepositorio(filename);
        }
        private UsuarioRepositorio(String dbPath)
        {
            con = new SQLiteConnection(dbPath);
            con.CreateTable<Usuarios>();
        }
        public string EstadoMensaje;
        public int AddNewUser(string username, string email, string password)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Usuarios
                {
                    Username = username,
                    Email = email,
                    Password = password
                });
                EstadoMensaje = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensaje = e.Message; }
            return result;
        }
        public IEnumerable<Usuarios> GetAllUsers()
        {
            try
            {
                return con.Table<Usuarios>();
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return Enumerable.Empty<Usuarios>();
        }
    }
}
