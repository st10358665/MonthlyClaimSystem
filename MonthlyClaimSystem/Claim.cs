using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyClaimSystem
{
   
    
        // Claim data model
        public class Claim
        {
            public string ClaimId { get; set; }
            public string Status { get; set; }
            public string DateFiled { get; set; }
            public string Amount { get; set; }
        }
    }

