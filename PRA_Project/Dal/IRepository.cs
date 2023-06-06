using PRA_Project.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRA_Project.Dal
{

    public interface IRepository
    {
        public IDictionary<int, object> Load();
        public void Save(IDictionary<int, object> dictionary);
    }
}
