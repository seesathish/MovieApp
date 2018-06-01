using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public  IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
          
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie - " + movie.Name + "is Not Available");
                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);                
            }

            _context.SaveChanges();

            return Ok();
        }


        //// While Building a Public, Follow this Approach
        //[HttpPost]
        //public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        //{
        //    if (newRental.MovieIds.Count == 0)
        //        return BadRequest("No Movie Ids have been given");

        //    var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

        //    if (customer == null)
        //        return BadRequest("Invalid Customer Id.");

        //    var movies = _context.Movies.Where(
        //        m => newRental.MovieIds.Contains(m.Id)).ToList();

        //    if (movies.Count != newRental.MovieIds.Count)
        //        return BadRequest("One or more movieIds are Invalid!");

        //    foreach (var movie in movies)
        //    {
        //        if (movie.NumberAvailable == 0)
        //            return BadRequest("Movie is Not Available");
        //        movie.NumberAvailable--;

        //        var rental = new Rental
        //        {
        //            Customer = customer,
        //            Movie = movie,
        //            DateRented = DateTime.Now
        //        };

        //        _context.Rentals.Add(rental);
        //    }

        //    _context.SaveChanges();

        //    return Ok();
        //}
    }
}
