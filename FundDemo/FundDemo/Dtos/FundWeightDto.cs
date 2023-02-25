using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundDemo.Dtos
{
    public class FundWeightDto
    {
        /// <summary>
        /// SEDOL
        /// </summary>
        public string SEDOL { get; set; }

        /// <summary>
        /// NumShares
        /// </summary>
        public int NumShares { get; set; }
        /// <summary>
        /// SEDOL
        /// </summary>
        public string ID_BPL_MARKET { get; set; }
        /// <summary>
        /// Price_USD
        /// </summary>
        public decimal Price_USD { get; set; }
        /// <summary>
        /// FundValue
        /// </summary>
        public decimal FundValue { get; set; }
        /// <summary>
        /// FundWeight
        /// </summary>
        public decimal FundWeight { get; set; }
    }
}
