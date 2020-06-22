using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<html>" +
							"<head>" +
								"<title>Skills Tracker</title>" +
							"</head>" +
						    "<body>" +	   
								   "<header>" +
										"<h1>Skills Tracker</h1>" +
								    "</header>" +
							"<main>" +
								"<h2>Coding skills to learn:</h2 >" +
									"<ol>" +
											"<li>" +
												"<p> C# </p>"+
											"</li>" +
											"<li>" +
												"<p> JavaScript </p>" +
											"</li>" +
											"<li>" +
												"<p> Python </p>" +
											"</li>" +
							"</main>" +
							"</body>" +
						  "</html > ";
            return Content(html, "text/html");
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult form()
        {
            string html = "<form method='post' action='/skills/form/'>" +
                "<label for='start'>Start date:<br></label>" + 
                "<input type='date' id='start' name='date' value='2020-07-22' min='1950-01-01' max='2020-12-31'>" +

                "<label for='csharp'><br>C#: <br></label>" +
                    "<select name='csharp' id='csharp'>" +
                    "<option value='beginner'>--Please choose an option--</option>" +
                    "<option value='beginner'>learning basics</option>" +
                    "<option value='worker'>making apps</option>" +
                    "<option value='master'>master coder</option>" +
                    "</select>" +
               "<label for='javascript'><br>JavaScript: <br></label>" +
                    "<select name='javascript' id='javascript'>" +
                    "<option value='beginner'>--Please choose an option--</option>" +
                    "<option value='beginner'>learning basics</option>" +
                    "<option value='worker'>making apps</option>" +
                    "<option value='master'>master coder</option>" +
                    "</select>" +
               "<label for='python'><br>Python:<br></label>" +
                    "<select name='python' id='python'>" +
                    "<option value='beginner'>--Please choose an option--</option>" +
                    "<option value='beginner'>learning basics</option>" +
                    "<option value='worker'>making apps</option>" +
                    "<option value='master'>master coder</option>" +
                    "</select>" +
                "<input type='submit' value='Submit'/>" +
                "</form>";

            return Content(html, "text/html");
        }

        // POST: /skills/form
        [HttpPost("skills/form")]
        public IActionResult SkillsResult( string date, string csharp, string javascript, string python)
        {
            string html = $"<h1>{date}</h1>" +
                            "<ol>" +
                                $"<li>C#: {csharp}</li>" +
                                $"<li>JavaScript: {javascript}</li>" +
                                $"<li>Python: {python}</li>" +
                            "</ol>";

                            return Content(html, "text/html");

        }
    }
}
