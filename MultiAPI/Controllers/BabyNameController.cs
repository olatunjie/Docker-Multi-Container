using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyNameController : ControllerBase
    {
        [HttpGet]
        public BabyName Get()
        {
            Random rand = new Random();
            int toSkip = rand.Next(0, 10);
            BabyName babayname = Repository().Skip(toSkip).Take(1).FirstOrDefault();
            return babayname;
        }


        protected List<BabyName> Repository()
        {
            List<BabyName> babaynameList = new List<BabyName> {
                new BabyName {Name = "Aanuoluwapo", EnglishMeaning = "God’s mercy is great"},
                new BabyName {Name = "Abayomi", EnglishMeaning = " the enemy would have gloated over me"},
                new BabyName {Name = "Abimbola", EnglishMeaning = "God’s mercy is great"},
                new BabyName {Name = "Abodunrin", EnglishMeaning = "one who walks in with the festival/holiday"},
                new BabyName {Name = "Dideolu", EnglishMeaning = "the rising of God"},
                new BabyName {Name = "Erioluwa", EnglishMeaning = "evidence/testimony of God"},
                new BabyName {Name = "Fijinoluwa", EnglishMeaning = "consecrated unto God"},
                new BabyName {Name = "Ibukunoluwa", EnglishMeaning = "blessing of God"},
                new BabyName {Name = "Mosopefunolorun", EnglishMeaning = " I thank God"},
                new BabyName {Name = "Moyosoreoluwa", EnglishMeaning = "I revel/rejoice in God’s favor"}
                };

            return babaynameList;
        }
    }
}
