using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementApi.Model
{
    public class Furniture
    {
        [Key]
        public int furnitureId { get; set; }

        public string furnitureName { get; set; }

        public string furniturePrice { get; set; }


        public string loanProvider { get; set; }
    }
}
