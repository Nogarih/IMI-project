using AutoMapper;
using Imi.Project.Api.Core.Dtos.Animes;
using Imi.Project.Api.Core.Dtos.Directors;
using Imi.Project.Api.Core.Dtos.Genres;
using Imi.Project.Api.Core.Dtos.Languages;
using Imi.Project.Api.Core.Dtos.Movies;
using Imi.Project.Api.Core.Dtos.TvSeries;
using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Entities;

namespace Imi.Project.Api.Core.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // Genre 
            CreateMap<Genre, GenreResponseDto>();
            CreateMap<GenreRequestDto, Genre>();

            // Director
            CreateMap<Director, DirectorResponseDto>();
            CreateMap<DirectorRequestDto, Director>();

            // Language
            CreateMap<Language, LanguageResponseDto>();
            CreateMap<LanguageRequestDto, Language>();


            // Movie
            CreateMap<Movie, MovieResponseDto>();
            CreateMap<MovieRequestDto, Movie>();

            // TvSerie
            CreateMap<TvSerie, TvSerieResponseDto>();
            CreateMap<TvSerieRequestDto, TvSerie>();

            // Anime
            CreateMap<Anime, AnimeResponseDto>();
            CreateMap<AnimeRequestDto, Anime>();
        }
    }
}