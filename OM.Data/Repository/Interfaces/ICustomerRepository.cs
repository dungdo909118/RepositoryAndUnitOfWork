
using OM.Data.Repository.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM.Data.Repository.Interfaces
{
    public interface ICustomerRepository: IRepository<OM.Data.Entities.Customer>
    {
        //TODO: you can define more method for only Customer here
    }
}
