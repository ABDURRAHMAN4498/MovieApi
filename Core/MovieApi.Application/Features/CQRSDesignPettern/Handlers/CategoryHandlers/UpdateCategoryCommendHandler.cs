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
    public class UpdateCategoryCommendHandler
    {
        private readonly MovieContext _context;

        public UpdateCategoryCommendHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(UpdateCategoryCommend commend)
        {
            Category value = await _context.Categories.FindAsync(commend.CategoryId);
            value.CategoryName = commend.CategoryName;
            await _context.SaveChangesAsync();
        }
    }
}
