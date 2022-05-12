using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RazorWebAppGitHub.DataAccess;
using RazorWebAppGitHub.Models;

namespace RazorWebAppGitHub.Controllers
{
    public class PeopleListController : Controller
    {
        DataConnection dataConnection = new DataConnection();
        IEnumerable<People> peoples = new List<People>();
        // GET: PeopleListController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PeopleList()
        {
            peoples = dataConnection.GetConnect();
            ViewBag.PeopleGet = peoples;
            return View();
        }

        // GET: PeopleListController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PeopleListController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeopleListController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PeopleListController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PeopleListController/Edit/5
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

        // GET: PeopleListController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PeopleListController/Delete/5
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
