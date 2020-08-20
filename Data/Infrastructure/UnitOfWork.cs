using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(DBContext context)
        {
            DB = context;
        }

        public DBContext DB { get; }
    }
}
