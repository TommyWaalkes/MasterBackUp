using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAPICreation.Models;
using Microsoft.AspNetCore.Mvc;


namespace CoreAPICreation.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }

        [HttpGet]
        [Route("frog")]
        public string Frog()
        {
            return "Ribbit";
        }

        [HttpGet("{id}")]
        [Route("books")]
        public Book GetBook(int id)
        {
            Book b = new Book(0, "How to make a Ham Sandwhich", 200, "Tommy Waalkes", "Horror");
            return b;
        }
    }
}