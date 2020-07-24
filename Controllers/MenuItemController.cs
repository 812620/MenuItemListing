using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenuItemListing.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        public List<MenuItem> item = new List<MenuItem> {
        new MenuItem{ ID = 0,Name="Pizza",freeDilivery=false,Price = 100,dateOfLaunch=(new DateTime(2020,2,12)),Active=false},
        new MenuItem{ ID = 1,Name="Burger",freeDilivery=true,Price = 100,dateOfLaunch=(new DateTime(2020,2,12)),Active=true},
        new MenuItem{ ID = 2,Name="Chole Bhature",freeDilivery=false,Price = 100,dateOfLaunch=(new DateTime(2020,2,12)),Active=true},
        new MenuItem{ ID = 3,Name="Hot Dog",freeDilivery=true,Price = 100,dateOfLaunch=(new DateTime(2020,2,12)),Active=false}
        };
        public List<string> itemName = new List<string>();
            
        [HttpGet]
        public List<string> GET()
        {
            for (int i = 0; i < item.Count; i++)
            {
                itemName.Add(item[i].Name);
            }
            return itemName;
        }
        [HttpGet("{id}")]
        public string GET(int id)
        {
            
            return item[id].Name;
        }

    }
}
