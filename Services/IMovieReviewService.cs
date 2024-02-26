using BlazerWebApp.Models;
using BlazorWebApp.Components;

namespace BlazorWebApp.Components.Services
{
    public interface IMovieReviewService
    {
        List<MovieModel>? GetMovies();
        MovieModel? GetMovieById(int id);
    }
}