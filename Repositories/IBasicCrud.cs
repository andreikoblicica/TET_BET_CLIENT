using System;
using System.Collections.Generic;

namespace TET_BET.Repositories
{
    public interface IBasicCrud
    {
        public void Insert(object objectToInsert);
        public List<object> SelectAll();
        public void Delete(object objectToDelete);
        public void Update(object objectToUpdate);
    }
}