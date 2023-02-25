using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundDemo.Services
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
