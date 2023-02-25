using FundDemo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FundDemo.Entities
{
    [Table("fund_data")]
    public class FundData
    {
        /// <summary>
        /// SEDOL
        /// </summary>
        public string SEDOL { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// NumShares
        /// </summary>
        public int NumShares { get; set; }

       
    }
}
