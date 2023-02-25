using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundDemo.Entities;
using FundDemo.Dtos;

namespace FundDemo.Services.IRepository
{
    public interface IFundRepository : IRepositoryBase<FundData>
    {

        Task<List<FundData>> GetFund();

        Task<List<FundWeightDto>> GetFundWeight();

        Task AddFund(FundData entity);

        Task EditFund(FundData entity);

        Task DeleteFund(string SEDOL);

        Task<FundData> GetFundDetail(string SEDOL);


        // Task<List<FundWeightDto>> SelectDto(string selectSql);
    }
}
