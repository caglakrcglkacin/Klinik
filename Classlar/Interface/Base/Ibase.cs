using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public interface Ibase<T> where T : new()
    {
        void Insert(T data);
        void Delete(int Id);
        void Update(T data, int Id);
        T GetAll(int Id);
    }
}
