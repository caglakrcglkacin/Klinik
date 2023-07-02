using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik
{
    public interface IbaseGetall<T>
    {
        List<T> Getall();
        List<T> GetWatch(int Id);
        List<T> GetPrint(int Id);
    }
}
