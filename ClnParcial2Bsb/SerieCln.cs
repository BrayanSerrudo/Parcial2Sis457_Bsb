using CadParcial2Bsb;
using CadParcial2Bsb.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnParcial2Bsb
{
    public class SerieCln
    {
        public static int insertar(Serie serie)
        {
            using (var context = new Parcial2BsbEntities())
            {
                context.Serie.Add(serie);
                context.SaveChanges();
                return serie.id;
            }
        }
        public static int actualizar(Serie serie)
        {
            using (var context = new Parcial2BsbEntities())
            {
                var existente = context.Serie.Find(serie.id);
                existente. titulo= serie.titulo;
                existente.sinopsis = serie.sinopsis;
                existente.director = serie.director;
                existente.episodios = serie.episodios;
                existente.fecha_estreno= serie.fecha_estreno;
                existente.idiomaPrincipal = serie.idiomaPrincipal;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new Parcial2BsbEntities())
            {
                var serie = context.Serie.Find(id);
                serie.estado = -1;
                return context.SaveChanges();
            }
        }
        public static Serie obtenerUno(int id)
        {
            using (var context = new Parcial2BsbEntities())
            {
                return context.Serie.Find(id);
            }
        }

        public static List<Serie> listar()
        {
            using (var context = new Parcial2BsbEntities())
            {
                return context.Serie.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paSerieListar_Result> listarPa(string parametro)
        {
            using (var context = new Parcial2BsbEntities())
            {
                return context.paSerieListar(parametro).ToList();
            }
        }

    }
}
