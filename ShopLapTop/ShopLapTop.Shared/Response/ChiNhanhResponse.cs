using ShopLapTop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLapTop.Shared.Response
{
    public class ChiNhanhResponse: BaseResponse
    {
        public List<ChiNhanh> ChiNhanhs { get; set; }
    }
}
