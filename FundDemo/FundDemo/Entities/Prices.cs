using FundDemo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FundDemo.Entities
{
    [Table("prices")]
    public class Prices
    {
        /// <summary>
        /// ID_BPL_MARKET
        /// </summary>
        public string ID_BPL_MARKET { get; set; }

        /// <summary>
        /// Price_USD
        /// </summary>
        public decimal Price_USD { get; set; }

      

       
    }
}
