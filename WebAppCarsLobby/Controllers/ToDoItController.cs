using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCarsLobby.Controllers
{
    public class ToDoItController : Controller
    {
        [HttpGet]
        public IActionResult Memo()
        {
            string memos = HttpContext.Session.GetString("Memos");
            if (memos != null)
            {
                ViewBag.Memos = memos;
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddMemo(string memo)
        {
            if ( ! string.IsNullOrWhiteSpace(memo))
            {
                string memos = HttpContext.Session.GetString("Memos");
                if (memos == null)
                {
                    HttpContext.Session.SetString("Memos", memo);
                }
                else
                {
                    memos += '|' + memo;
                    HttpContext.Session.SetString("Memos", memos);
                }
            }

            return RedirectToAction(nameof(Memo));
            //return View("Memo");
        }
    }
}
