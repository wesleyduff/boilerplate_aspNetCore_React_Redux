using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLient.Interfaces
{
    public interface Crud<T>
    {
        T Add(T item);
        T Delete(T item);
        T Get(T item);
        T Update(T item);
    }
}
