using MovieApi.Application.Features.CQRSDesignPettern.Commends.CategoryCommends;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPettern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommendHandler
    {
        private readonly MovieContext _context;

        public RemoveCategoryCommendHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(RemoveCategoryCommend commend)
        {
            Category value = await _context.Categories.FindAsync(commend.CategoryId);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
