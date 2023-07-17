using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tikkei.Service.Models.Size
{
    public class SizeModel
    {
        public int SizeID { get; set; }

        public string SizeName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }
    }
}
