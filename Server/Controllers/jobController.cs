using Microsoft.AspNetCore.Mvc;
using server;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        public static List<Job> allJobs = new List<Job>() 

        {
             new Job{filedjob =  EnumJob.HITECH, namejob = " C# Programmer" , numhours = 50,area = "תל-אביב",reqjob = "Experience",fromhome= true},
             new Job{filedjob =  EnumJob.HITECH, namejob = "Analist" , numhours = 40,area = "ירושלים",reqjob = "Experience min 5 years,car",fromhome= false},
             new Job{filedjob =  EnumJob.HITECH, namejob = " Java programmer" , numhours = 56,area = "נתיבות",reqjob = "Experience 20 years",fromhome= true},
             new Job{filedjob =  EnumJob.ACCOUNTING, namejob = "חשב שכר" , numhours = 51,area = "בת-ים",reqjob = "Experience",fromhome= false},
             new Job{filedjob =  EnumJob.ACCOUNTING, namejob = "יועץ מס" , numhours = 48,area = "ירושלים",reqjob = "Experience 4 years,car",fromhome= false},
             new Job{filedjob =  EnumJob.ACCOUNTING, namejob = "רואה חשבון" , numhours = 26,area = "תל-אביב",reqjob = "Experience 2 years",fromhome= true},
             new Job{filedjob =  EnumJob.EDUCATION, namejob = "מרצה" , numhours = 50,area = "בת-ים",reqjob = "Experience 10 years,car",fromhome= false},
             new Job{filedjob =  EnumJob.EDUCATION, namejob = "פרופסור" , numhours = 45,area = "נתיבות",reqjob = "Experience,car",fromhome= false},
             new Job{filedjob =  EnumJob.EDUCATION, namejob = "מורה למדעים" , numhours = 25,area = "מודיעין",reqjob = "Experience",fromhome= false}
            
        };
// GET: api/<BookController>

        [HttpGet("GetJobs")]
        public List<Job> GetJobs()
         {
            return allJobs;
         }
         

    }
}
