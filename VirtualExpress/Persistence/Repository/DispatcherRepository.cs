﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualExpress.Domain.Models;
using VirtualExpress.Domain.Persistence.Context;
using VirtualExpress.Domain.Repositories;

namespace VirtualExpress.Persistence.Repository
{
    public class DispatcherRepository : BaseRepository, IDispatcherRepository
    {
        public DispatcherRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddAsync(Dispatcher dispatcher)
        {
            await _context.Dispatchers.AddAsync(dispatcher);
        }

        public async Task<Dispatcher> FindById(int id)
        {
            return await _context.Dispatchers.FindAsync(id);
        }

        public async Task<IEnumerable<Dispatcher>> ListAsync()
        {
            return await _context.Dispatchers.ToListAsync();
        }

        public void Remove(Dispatcher dispatcher)
        {
            _context.Dispatchers.Remove(dispatcher);
        }

        public void Update(Dispatcher dispatcher)
        {
            _context.Dispatchers.Update(dispatcher);
        }
    }
}
