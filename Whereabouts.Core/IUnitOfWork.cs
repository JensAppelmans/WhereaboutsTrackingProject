using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whereabouts.Core.Repositories;

namespace Whereabouts.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IAdressRepository Adresses { get;  }

        int complete(); 
    }
}
