using Domain;
using System.Collections.Generic;

namespace Data
{
    public interface IRepository
    {
        List<IPerson> Read();
        void Write(List<IPerson> list);
    }
}