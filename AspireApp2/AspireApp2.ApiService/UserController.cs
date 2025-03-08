using AspireApp2.ApiService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace AspireApp2.ApiService
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDistributedCache _cache;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cache"></param>
        public UserController(IDistributedCache cache)
        {
            _cache = cache;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserDetailsModel? Get(string id)
        {
            string key = "User_" + id;
            var userDetails = _cache.GetString(key);
            if (userDetails != null)
            {
                return JsonSerializer.Deserialize<UserDetailsModel>(userDetails);
            }
            return null;
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<bool> Post([FromBody] UserDetailsModel userDetails)
        {
            string key = "User_" + Guid.NewGuid().ToString();
            userDetails.Id = key;
            string userdetails = JsonSerializer.Serialize(userDetails);
            await _cache.SetStringAsync(key, userdetails);
            return true;
        }

    }
}
