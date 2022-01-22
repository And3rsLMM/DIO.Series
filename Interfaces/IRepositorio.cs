using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series.Interfaces
{
    internal interface IRepositorio<T>
    {
        List<T> Lista();

        T ReturnbyId(int id);
        void Insert(T entidade);
        void DeletebyId(int id);
        void Update(int id, T entidade);
        int NextId();
    }
}
