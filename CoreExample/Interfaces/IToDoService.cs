using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreExample.Models;

namespace CoreExample.Interfaces
{
    public interface IToDoService
    {
        IList<KeyValuePair<int, string>> GetAll();

        ToDo Get(int id);

        void Delete(int id);

        void Update(ToDo item);

        int Create(ToDo item);
    }
}
