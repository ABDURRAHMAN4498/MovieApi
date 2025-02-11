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
    public class CreateCategoryCommendHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryCommendHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handle(CreateCategoryCommend commend)
        {
            _context.Categories.Add(new Category { CategoryName = commend.CategoryName });
            await _context.SaveChangesAsync();
        }
    }
}
