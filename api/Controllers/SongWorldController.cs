using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    // [Route("[controller]")]
    public class SongWorldController : ControllerBase
    {
        private SongWorld mySongWorld = new SongWorld();
        private SongWorld2 mySongWorld2 = new SongWorld2();
        private SongWorld3 mySongWorld3 = new SongWorld3();
        

        private readonly ILogger<SongWorldController> _logger;

        public SongWorldController(ILogger<SongWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public String Get()
        {
            return "<h1>Welcome to Music World!</h1>";
        }

        [HttpGet]
        [Route("[controller]/SongWorld")]
        public String GetSongWorld()
        {
            return mySongWorld.Songworld;
        }

        [HttpGet]
        [Route("[controller]/SongWorld2")]
        public String GetSongWorld2()
        {
            return mySongWorld2.Songworld2;
        }

         [HttpGet]
        [Route("[controller]/SongWorld3")]
        public String GetSongWorld3()
        {
            return mySongWorld3.Songworld3;
        }
    }
}