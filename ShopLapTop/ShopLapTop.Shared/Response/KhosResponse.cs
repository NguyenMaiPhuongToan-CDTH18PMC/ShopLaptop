using ShopLapTop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLapTop.Shared.Response
{
    public class KhosResponse : BaseResponse
    {
        public List<Kho> Khos { get; set; }
    }
}
