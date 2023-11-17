using CadRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurante
{
    public class UsuarioCln
    {
        public static int insertar(Usuario usuario)
        {
            using (var context = new LabRestauranteMPEntities())
            {
                context.Usuario.Add(usuario);
                context.SaveChanges();
                return usuario.id;
            }
        }

        public static int actualizar(Usuario usuario)
        {
            using (var context = new LabRestauranteMPEntities())
            {
                var existente = context.Usuario.Find(usuario.id);
                existente.usuario1 = usuario.usuario1.Trim();
                existente.usuarioRegistro = usuario.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabRestauranteMPEntities())
            {
                var existente = context.Usuario.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }

        public static Usuario get(int id)
        {
            using (var context = new LabRestauranteMPEntities())
            {
                return context.Usuario.Find(id);
            }
        }

        public static List<Usuario> listar()
        {
            using(var context = new LabRestauranteMPEntities())
            {
                return context.Usuario.Where(x => x.estado !=-1).ToList();
            }
        }
        public static List<paUsuarioListar_Result> listarPa(string parametro)
        {
            using (var contexto = new LabRestauranteMPEntities())
            {
                return contexto.paUsuarioListar(parametro).ToList();
            }
        }
        public static Usuario validar (string usuario, string clave)
        {
            using (var context = new LabRestauranteMPEntities())
            {
                return context.Usuario
                    .Where(x => x.usuario1 == usuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }
    }
}
