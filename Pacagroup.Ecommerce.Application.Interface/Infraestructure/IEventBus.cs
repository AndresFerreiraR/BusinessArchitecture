using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Application.Interface.Infraestructure
{
    public interface IEventBus
    {
        void Publish<T>(T @entity);
    }
}
