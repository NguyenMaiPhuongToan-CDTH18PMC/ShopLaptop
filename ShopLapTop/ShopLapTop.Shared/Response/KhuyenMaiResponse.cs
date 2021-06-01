using ShopLapTop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLapTop.Shared.Response
{
    public class KhuyenMaiResponse : BaseResponse
    {
        public List<KhuyenMai> KhuyenMais { get; set; }
    }
}
