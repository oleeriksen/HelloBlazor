using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloBlazor.Shared;
using HelloBlazor.Server.Repositories;

namespace HelloBla.Server.Controllers
{
    [ApiController]
    [Route("api/Shopping")]
    public class ShoppingController : ControllerBase
    {

        private static ShoppingRepositoryInMemory mRepo = new();

        [HttpGet]
        [Route("getall")]
        public IEnumerable<ShoppingItem> GetAll()
        {
            Console.WriteLine("GetAll ");
            //Thread.Sleep(3000);
            return mRepo.GetAll();
        }

        [HttpPost]
        [Route("add")]
        public void AddItem(ShoppingItem product)
        {
            Console.WriteLine("Post " + product.Name);
            mRepo.AddItem(product);
         
        }


    }
}

