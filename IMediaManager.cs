using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    using System.Collections.Generic;

    public interface IMediaManager<T>
    {
        void Add(T item); 
        bool Remove(string title); 
        T FindByTitle(string title);
        List<T> GetAllAvailable();
    }
}
