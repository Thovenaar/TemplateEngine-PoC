using AngleSharp;
using AngleSharp.Dom;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using TemplatePoc.Factories;
using TemplatePoc.Models;

namespace TemplatePoc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var template = System.IO.File.ReadAllText("Views/Home/Template.cshtml");
            var mailComponents = new List<IMailComponent>();

            const string pattern = "<component>([a-zA-Z]+)<\\/component>";
            var matches = Regex.Matches(template, pattern);

            var mailComponentFactory = new MailComponentFactory();

            var currentIndex = 0;
            foreach (Match match in matches)
            {
                if (currentIndex < match.Index)
                {
                    mailComponents.Add(new Content(template.Substring(currentIndex, match.Index - currentIndex)));
                }

                var component = match.Groups[1].Value;
                mailComponents.Add(mailComponentFactory.Create(component));
                currentIndex = match.Index + match.Length;
            }

            if (template.Length > currentIndex)
            {
                mailComponents.Add(new Content(template.Substring(currentIndex, template.Length - currentIndex)));
            }

            return View(mailComponents);
        }

        private void GetNestedMailComponents(IParentNode element, ICollection<IMailComponent> mailComponents)
        {
            if (!element.Children.Any()) return;

            var mailComponentFactory = new MailComponentFactory();
            foreach (var el in element.Children.ToList())
            {
                mailComponents.Add(string.Equals(el.LocalName, "component", StringComparison.OrdinalIgnoreCase)
                    ? mailComponentFactory.Create(el.TextContent)
                    : new Content(el.ToHtml()));

                GetNestedMailComponents(el, mailComponents);
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
