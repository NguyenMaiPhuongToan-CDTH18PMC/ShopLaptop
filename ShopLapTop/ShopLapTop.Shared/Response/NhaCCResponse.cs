using ShopLapTop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLapTop.Shared.Response
{
    public class NhaCCResponse : BaseResponse
    {
        public List<NhaCungCap> NhaCungCaps { get; set; }
    }
}
