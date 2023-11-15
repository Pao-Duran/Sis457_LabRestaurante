using CadRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnRestaurante
{
    public class DetalleFacturaCln
    {
        public static int insertar(DetalleFactura detalleFactura)
        {
            using (var context = new LabRestauranteEntities())
            {
                context.DetalleFactura.Add(detalleFactura);
                context.SaveChanges();
                return detalleFactura.id;
            }
        }

        public static int actualizar(DetalleFactura detalleFactura)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existente = context.DetalleFactura.Find(detalleFactura.id);
                existente.idCliente = detalleFactura.idCliente;
                existente.idEmpleado = detalleFactura.idEmpleado;
                existente.idComida = detalleFactura.idComida;
                existente.idBebida = detalleFactura.idBebida;
                existente.usuarioRegistro = detalleFactura.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabRestauranteEntities())
            {
                var existente = context.DetalleFactura.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static DetalleFactura get(int id)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.DetalleFactura.Find(id);
            }
        }

        public static List<DetalleFactura> listar()
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.DetalleFactura.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paDetalleFacturaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.paDetalleFacturaListar(parametro).ToList();
            }
        }
    }
}
