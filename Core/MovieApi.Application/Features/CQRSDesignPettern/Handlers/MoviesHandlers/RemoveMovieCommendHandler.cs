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
    public class RemoveMovieCommendHandler
    {
        private readonly MovieContext _context;

        public RemoveMovieCommendHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(RemoveMovieCommend commend)
        {
            Movie value = await _context.Movies.FindAsync(commend.MovieId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
