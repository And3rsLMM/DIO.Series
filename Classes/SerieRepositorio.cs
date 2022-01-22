using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.Series.Interfaces;
using System.Collections.Generic;



namespace DIO.Series
{
    internal class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> serieList = new List<Serie>();
        public void DeletebyId(int id)
        {
            serieList[id].Delete();
        }

        public void Insert(Serie entidade)
        {
            serieList.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return serieList;
        }

        public int NextId()
        {
            return serieList.Count;
        }

        public Serie ReturnbyId(int id)
        {
            return serieList[id];
        }

        public void Update(int id, Serie entidade)
        {
                serieList[id] = entidade;
        }
    }
}
