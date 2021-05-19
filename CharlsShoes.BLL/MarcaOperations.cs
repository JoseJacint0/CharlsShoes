using CharlsShoes.DAL;
using CharlsShoes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharlsShoes.BLL
{
    public class MarcaOperations
    {
        #region Singleton
        private static volatile MarcaOperations instance = null;
        private static readonly object padlock = new object();
        private CharlsShoesContext context = new CharlsShoesContext();

        private MarcaOperations() { }

        public static MarcaOperations Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new MarcaOperations();
            return instance;
        }
        #endregion

        public int Add(Marca marca)
        {
            context.Add(marca);
            return context.SaveChanges();
        }

        public int Delete(int idMarca)
        {
            Marca marca = context.Marcas.Where(m => m.idMarca == idMarca).FirstOrDefault();
            marca.activo = false;
            return context.SaveChanges();
        }

        public List<Marca> GetAll()
        {
            return context.Marcas.Where(m => m.activo == true).ToList();
        }

        public Marca GetById(int idMarca)
        {
            return context.Find<Marca>(idMarca);
        }

        public int Update(Marca marca)
        {
            context.Update(marca);
            return context.SaveChanges();
        }
    }
}
