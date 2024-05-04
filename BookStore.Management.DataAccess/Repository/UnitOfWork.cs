﻿using BookStore.Management.DataAccess.Data;
using BookStore.Management.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Management.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _applicationDbContext;

        private IBookRepository? _bookRepository;
        private IGenreRepository? _genreRepository;
        private bool disposedValue;

        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IBookRepository BookRepository => _bookRepository ??= new BookRepository(_applicationDbContext);
        public IGenreRepository GenreRepository => _genreRepository ??= new GenreRepository(_applicationDbContext);

       

        public async Task SaveChangesAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if (disposing)
                {
                    _applicationDbContext.Dispose();
                }
                disposedValue = true;
            }  
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
