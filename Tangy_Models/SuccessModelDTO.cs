using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models
{
    public class SuccessModelDTO
    {
        public string Title { get; set; } = string.Empty;
        public int StatusCode { get; set; }
        public string SuccessMessage { get; set; } = string.Empty;
        public object? Data { get; set; }
    }
}
