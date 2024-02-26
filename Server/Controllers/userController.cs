using Microsoft.AspNetCore.Mvc;
// using API.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server
{
     [ApiController]
    [Route("api/[controller]")]
   
    public class PersonController : ControllerBase
    {
        public static List<User> allUsers = new List<User>() 
        { 
            new User { id = 1,name = "Avi", password = "avipw", filedsearchjob = EnumJob.EDUCATION,jobs={ } },
            new User { id = 1,name = "Gabi", password = "gabipw", filedsearchjob = EnumJob.ACCOUNTING,jobs={ }  },
            new User { id = 1,name = "Noa", password = "noapw", filedsearchjob = EnumJob.HITECH,jobs={ }  },
            new User { id = 1,name = "Yael", password = "yaelpw", filedsearchjob = EnumJob.EDUCATION,jobs={ } },
            new User { id = 1,name = "Halel", password = "halelpw", filedsearchjob = EnumJob.HITECH,jobs={ } },
            new User { id = 1,name = "Eilli", password = "eillipw", filedsearchjob = EnumJob.ACCOUNTING,jobs={ }  },
            new User { id = 1,name = "Tehila", password = "tehilapw", filedsearchjob = EnumJob.HITECH,jobs={ } },
            new User { id = 1,name = "Sarit", password = "saritpw", filedsearchjob = EnumJob.EDUCATION,jobs={ } },
            new User { id = 1,name = "Shir", password = "shirpw", filedsearchjob = EnumJob.ACCOUNTING,jobs={ }  },
            new User { id = 1,name = "Sharon", password = "sharonpw", filedsearchjob = EnumJob.HITECH,jobs={ }},
          };

    [HttpGet("{name}/{password}")]
    public User GetUser(string name,string password)
    {
        return allUsers.FirstOrDefault(u   =>  u.name == name && u.password == password);
              
    }


    }
}
