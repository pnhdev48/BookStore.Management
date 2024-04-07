﻿using Microsoft.AspNetCore.Http;

namespace BookStore.Management.Application.Services
{
    public interface IImageService
    {
        Task<bool> SaveImage(List<IFormFile> images, string path, string? defautName);
    }
}