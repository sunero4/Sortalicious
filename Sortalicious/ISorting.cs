using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortalicious
{
    public interface ISorting<T>
    {
        List<T> SortDescending(List<T> values);

        List<T> SortAscending(List<T> values);

    }
}
