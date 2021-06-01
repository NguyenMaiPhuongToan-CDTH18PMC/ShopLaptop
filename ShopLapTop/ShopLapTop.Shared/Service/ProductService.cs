using AKSoftware.WebApi.Client;
using ShopLapTop.Shared.Models;
using ShopLapTop.Shared.Request;
using ShopLapTop.Shared.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopLapTop.Shared.Service
{
    public class ProductService
    {
        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public ProductService(string url)
        {
            _baseUrl = url;
        }

        public string AccessToken
        {
            get => client.AccessToken;
            set
            {
                client.AccessToken = value;
            }
        }
        //Quan Ly Kho
        public async Task<BaseResponse> AddKho(KhoRequest request)
        {
            var response = await client.PostProtectedAsync<BaseResponse>($"{_baseUrl}/Api/Product/Kho", request);
            return response.Result;
        }
        public async Task<KhosResponse> GetKhos()
        {
            var response = await client.GetProtectedAsync<KhosResponse>($"{_baseUrl}/Api/Product/Kho");
            return response.Result;
        }

        //Quan Ly Nha Cung Cap
        public async Task<BaseResponse> AddNhaCC(NhaCCRequest request)
        {
            var response = await client.PostProtectedAsync<BaseResponse>($"{_baseUrl}/Api/Product/NhaCungCap", request);
            return response.Result;
        }
        public async Task<NhaCCResponse> GetNhaCC()
        {
            var response = await client.GetProtectedAsync<NhaCCResponse>($"{_baseUrl}/Api/Product/NhaCungCap");
            return response.Result;
        }

        //Quan Ly Khuyen Mai
        public async Task<KhuyenMaiResponse> GetKhuyenMais()
        {
            var response = await client.GetProtectedAsync<KhuyenMaiResponse>($"{_baseUrl}/Api/Product/KhuyenMai");
            return response.Result;
        }
        public async Task<BaseResponse> AddKhuyenMai(KhuyenMaiRequest request)
        {
            var response = await client.PostProtectedAsync<BaseResponse>($"{_baseUrl}/Api/Product/KhuyenMai", request);
            return response.Result;
        }

        //Quan Ly Chi Nhanh
        public async Task<ChiNhanhResponse> GetChiNhanhs()
        {
            var response = await client.GetProtectedAsync<ChiNhanhResponse>($"{_baseUrl}/Api/Product/ChiNhanh");
            return response.Result;
        }
        public async Task<BaseResponse> AddChiNhanh(ChiNhanhRequest request)
        {
            var response = await client.PostProtectedAsync<BaseResponse>($"{_baseUrl}/Api/Product/ChiNhanh",request);
            return response.Result;
        }
    }
}
