using Microsoft.AspNetCore.Mvc;
using SydneyActive.Data;
using SydneyActive.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SydneyActive.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MemberController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Member> objMemberList = _db.Members.ToList();
            return View(objMemberList);
        }

        //Get
        public IActionResult Create()
        {

            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Member obj)
        {

            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            var memberExist = _db.Members.Contains(new Member { FirstName = obj.FirstName, LastName = obj.LastName, ContactNumber = obj.ContactNumber});
            if (memberExist)
            {
                Console.Write("Error");
            }
            _db.Members.Add(obj);
            _db.SaveChanges();
            //TempData["sucess"] = "Category created sucessfully";
            return RedirectToAction("index");
        }
    }

}