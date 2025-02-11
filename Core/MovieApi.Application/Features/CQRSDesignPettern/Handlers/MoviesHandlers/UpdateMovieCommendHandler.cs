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
    public class UpdateMovieCommendHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommendHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(UpdateMovieCommend commend)
        {
            Movie value = await _context.Movies.FindAsync(commend.MovieId);
            value.Rating = commend.Rating;
            value.Title = commend.Title;
            value.Description = commend.Description;
            value.CreatedYear = commend.CreatedYear;
            value.Duration = commend.Duration;
            value.CoverImageUrl = commend.CoverImageUrl;
            value.ReleaseDate = commend.ReleaseDate;
            value.Status = commend.Status;
            await _context.SaveChangesAsync();
        }
    }
}
