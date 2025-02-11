using MovieApi.Application.Features.CQRSDesignPettern.Commends.MoviesCommends;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPettern.Handlers.MoviesHandlers
{
    public class CreateMovieCommendHandler
    {
        private readonly MovieContext _context;

        public CreateMovieCommendHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(CreateMovieCommend commend)
        {
            _context.Movies.Add(new Movie
            {
                Title = commend.Title,
                CreatedYear = commend.CreatedYear,
                Description = commend.Description,
                Duration = commend.Duration,
                Rating = commend.Rating,
                ReleaseDate = commend.ReleaseDate,
                Status = commend.Status,
                CoverImageUrl = commend.CoverImageUrl,
            });
            await _context.SaveChangesAsync();
        }
    }
}
