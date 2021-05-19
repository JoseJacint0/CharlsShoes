using CharlsShoes.DAL;
using CharlsShoes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharlsShoes.BLL
{
    public class ReporteOperations
    {
        #region Singleton
        private static volatile ReporteOperations instance = null;
        private static readonly object padlock = new object();
        private CharlsShoesContext context = new CharlsShoesContext();

        private ReporteOperations() { }

        public static ReporteOperations Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ReporteOperations();
            return instance;
        }
        #endregion

        public int Add(Reporte reporte)
        {
            context.Add(reporte);
            return context.SaveChanges();
        }

        public int Delete(int idReporte)
        {
            Reporte reporte = context.Reportes.Where(r => r.idReporte == idReporte).FirstOrDefault();
            reporte.activo = false;
            return context.SaveChanges();
        }

        public List<Reporte> GetAll()
        {
            return context.Reportes.Where(r => r.activo == true).ToList();
        }

        public Reporte GetById(int idReporte)
        {
            return context.Find<Reporte>(idReporte);
        }

        public int Update(Reporte reporte)
        {
            context.Update(reporte);
            return context.SaveChanges();
        }
    }
}
