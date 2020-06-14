using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhatNghe_Day09.Models.Service.Interfaces
{
    public interface ItransientService
    {
        Guid GetID();
    }
    public interface IScopedService
    {
        Guid GetID();
    }
    public interface ISingletonService
    {
        Guid GetID();
    }
    public class MyService : ItransientService, IScopedService, ISingletonService
    {
        private Guid _guid;
        public MyService()
        {
            _guid = Guid.NewGuid();
        }
        public Guid GetID()
        {
            return _guid;
        }
    }
}
