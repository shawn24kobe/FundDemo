using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundDemo.Services
{
    public interface IRepositoryBase<T>
    {
        Task Insert(T entity, string insertSql);

        Task Update(T entity, string updateSql);

        Task Delete(Guid Id, string deleteSql);

        Task Delete(string Id, string deleteSql);

        Task<List<T>> Select(string selectSql);

        Task<T> Detail(Guid Id, string detailSql);

        Task<T> Detail(string Id, string detailSql);
    }
}
