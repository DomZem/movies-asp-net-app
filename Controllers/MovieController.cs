﻿using Microsoft.AspNetCore.Mvc;
using movies_asp_net_app.Models;

namespace movies_asp_net_app.Controllers
{
    public class MovieController : Controller
    {
        private static IList<Movie> MovieList = new List<Movie>
        {
            new Movie(){Id = 1, Title = "Batman", Description="des", Grade=3},
            new Movie(){Id = 2, Title = "Spider-man", Description="des", Grade=3},
            new Movie(){Id = 3, Title = "Iron-man", Description="des", Grade=5},
            new Movie(){Id = 4, Title = "Captain America", Description="des", Grade=4},
        };

        // GET: MovieController
        public ActionResult Index()
        {
            return View(MovieList);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View(MovieList.FirstOrDefault(movie => movie.Id == id));
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            // Set movie id to next
            movie.Id = MovieList.Count + 1;

            MovieList.Add(movie);
            return RedirectToAction(nameof(Index));
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
