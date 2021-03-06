﻿using ComputanVidely.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ComputanVidely.App_Start;
using ComputanVidely.DTOs;
using AutoMapper;

namespace ComputanVidely.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        // GET api/Movies
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);
        }

        // GET api/Movie/1
        public MovieDto GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Mapper.Map<Movie, MovieDto>(movie);
        }

        // POST  api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        // PUT api/movies/1
        [HttpPut]
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
            {
                 throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map<MovieDto, Movie>(movieDto, movieInDb);

            _context.SaveChanges();
        }

        // DELETE api/movies/1
        [HttpDelete]
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        
    }
}
