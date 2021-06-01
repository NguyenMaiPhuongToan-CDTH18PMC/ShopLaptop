using Microsoft.EntityFrameworkCore;
using ShopLapTop.Shared.Models;
using ShopLapTop.Shared.Request;
using ShopLapTop.Shared.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopLapTop.Api.Service
{
    public interface IProductService
    {
        //Quna lY Chinh Nhanh
        Task<ChiNhanhResponse> GetChiNhanh();
        Task<BaseResponse> AddChiNhanh(ChiNhanhRequest request);
        //Quan Ly Kho
        Task<KhosResponse> GetKhos();
        Task<BaseResponse> AddKho(KhoRequest request);

        //Quan Ly Nha Cung Cap
        Task<NhaCCResponse> GetNhaCCs();
        Task<BaseResponse> AddNhaCC(NhaCCRequest request);

        //Quan Ly Khuyen Mai
        Task<BaseResponse> AddKM(KhuyenMaiRequest request);
        Task<KhuyenMaiResponse> GetKhuyenMais();
    }
    
    class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        //QUan ly Kho       
        public async Task<BaseResponse> AddKho(KhoRequest request)
        {
            if (request == null)
                throw new NullReferenceException("Requset model is null");
            Kho kho = new Kho
            {
                MaKho = Guid.NewGuid().ToString(),
                TenKho = request.TenKho,
                SDT = request.SDT,
                DiaChi = request.DiaChi,
                Email = request.Email,
            };
            await _context.AddAsync(kho);
            await _context.SaveChangesAsync();
            return new BaseResponse
            {
                IsSuccess = true,
                Message = "Create Success",
            };
        }

        public async Task<KhosResponse> GetKhos()
        {
            var result = await _context.Khos.ToListAsync();
            return new KhosResponse
            {
                IsSuccess = true,
                Khos = result,
            };
        }

        //Quan Ly Nha Cung Cap
        public async Task<BaseResponse> AddNhaCC(NhaCCRequest request)
        {
            if (request == null)
                throw new NullReferenceException("Request model is null");
            NhaCungCap nhaCungCap = new NhaCungCap
            {
                MaNCC = Guid.NewGuid().ToString(),
                TenNCC = request.TenNCC,
                DiaChi = request.DiaChi,
                SDT = request.SDT,
                Email = request.Email,
            };
            await _context.NhaCungCaps.AddAsync(nhaCungCap);
            await _context.SaveChangesAsync();
            return new BaseResponse
            {
                IsSuccess = true,
            };
        }
        
        public async Task<NhaCCResponse> GetNhaCCs()
        {
            var result = await _context.NhaCungCaps.ToListAsync();
            return new NhaCCResponse
            {
                IsSuccess = true,
                NhaCungCaps = result,
            };
        }

        //Quan Ly Khuyen Mai
        public async Task<BaseResponse> AddKM(KhuyenMaiRequest request)
        {
            if (request == null)
                throw new NullReferenceException("Request model is null");
            KhuyenMai khuyenMai = new KhuyenMai
            {
                TenKM = request.TenKM,
                LoaiKM = request.LoaiKM,
                MoTa = request.MoTa,
                NgayBD = request.NgayBD,
                NgayKT = request.NgayKT,
            };
            await _context.KhuyenMais.AddAsync(khuyenMai);
            await _context.SaveChangesAsync();
            return new BaseResponse
            {
                IsSuccess = true,
            };
        }
        public async Task<KhuyenMaiResponse> GetKhuyenMais()
        {
            var result = await _context.KhuyenMais.ToListAsync();
            return new KhuyenMaiResponse
            {
                IsSuccess = true,
                KhuyenMais = result,
            };
        }

        //Quan Ly Chi Nhanh
        public async Task<ChiNhanhResponse> GetChiNhanh()
        {
            var result = await _context.ChiNhanhs.ToListAsync();
            return new ChiNhanhResponse
            {
                IsSuccess = true,
                ChiNhanhs = result,
            };
        }
        public async Task<BaseResponse> AddChiNhanh(ChiNhanhRequest request)
        {
            if (request == null)
                throw new NullReferenceException("Request model is null");
            ChiNhanh chiNhanh = new ChiNhanh
            {
                MaCN = Guid.NewGuid().ToString(),
                DiaChi = request.DiaChi,
                Email = request.Email,
                KhoMaKho = request.MaKho,
                SDT = request.SDT,
                TenCN = request.TenCN,
            };
            await _context.ChiNhanhs.AddAsync(chiNhanh);
            await _context.SaveChangesAsync();
            return new BaseResponse
            {
                IsSuccess = true,
            };
        }
    }
}
