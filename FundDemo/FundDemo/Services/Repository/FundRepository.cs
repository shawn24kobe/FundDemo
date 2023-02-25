using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using FundDemo.Entities;
using FundDemo.Services.IRepository;
using FundDemo.Dtos;

namespace FundDemo.Services.Repository
{
    public class FundRepository : RepositoryBase<FundData>, IFundRepository
    {
        

        public async Task<List<FundData>> GetFund()
        {
            string selectSql = @"SELECT [Date] ,[SEDOL] ,[NumShares] FROM [dbo].[fund_data]";
            return await Select(selectSql);
        }

        public async Task<List<FundWeightDto>> GetFundWeight()
        {
            string selectSql = @"select f.SEDOL,f.NumShares,p.ID_BPL_MARKET,p.[Price USD], (f.NumShares*p.[Price USD]) as fundValue into #temp1
                                FROM [dbo].[fund_data] f INNER JOIN [dbo].[identifiers] i ON f.SEDOL=i.SEDOL INNER JOIN [dbo].[prices] p ON i.ID_BPL_MARKET=p.ID_BPL_MARKET
	                            select #temp1.*,(case when a.totalVal=0 then 0 else isnull(cast( #temp1.fundValue /a.totalVal*100 as decimal(18,4)),0) end) as fundWeight  from #temp1
	                            left join (select sum(fundValue) as totalVal from  #temp1) a on 1=1 order by fundWeight desc
	                            drop table #temp1;";
            return await SelectDto(selectSql);
        }

        public async Task AddFund(FundData entity)
        {
            string insertSql = @"INSERT INTO [dbo].[fund_data]([Date] ,[SEDOL] ,[NumShares]) VALUES(@Date, @SEDOL, @NumShares)";
            await Insert(entity, insertSql);
        }

        public async Task EditFund(FundData entity)
        {
            string updateSql = "UPDATE [dbo].[fund_data] SET Date=@Date, NumShares=@NumShares WHERE SEDOL=@SEDOL";
            await Update(entity, updateSql);
        }

        public async Task DeleteFund(string SEDOL)
        {
            //todo
        }

        public async Task<FundData> GetFundDetail(string SEDOL)
        {
            string detailSql = @"SELECT [Date] ,[SEDOL] ,[NumShares] FROM [dbo].[fund_data] WHERE [SEDOL]=@Id";
            return await Detail(SEDOL, detailSql);
        }


        public async Task<List<FundWeightDto>> SelectDto(string selectSql)
        {
            using (IDbConnection conn = DataBaseConfig.GetSqlConnection())
            {
                return await Task.Run(() => conn.Query<FundWeightDto>(selectSql).ToList());
            }
        }


    }
}
