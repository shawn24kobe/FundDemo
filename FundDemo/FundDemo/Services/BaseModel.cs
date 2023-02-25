using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundDemo.Services
{
    public class BaseModel : IEntity<Guid>
    {
        public Guid Id { get; set; }
    }
}
