using HNGStageOne.API.Models.DTO;
using HNGStageOne.API.Repository;
using HNGStageOne.API.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace HNGStageOne.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        private readonly IFunFactRepository funFactRepository;

        public NumberController(HttpClient httpClient, IFunFactRepository funFactRepository)
        {
            this.funFactRepository = funFactRepository;
        }
        [HttpGet]
        [Route("classify-number")]
        public async Task<IActionResult> GetNumberClassification([FromQuery] string? number)
        {

            if (int.TryParse(number, out var num) == false)
            {
                return BadRequest(new { number, error = true });
            }
            else if (number == null)
            {
                return BadRequest();
            }

            var funFact = await funFactRepository.GetFunFact(num);

            // Classify number properties
            bool isArmstrong = NumberUtils.IsArmstrong(num);
            bool isOdd = num % 2 != 0;

            // Define properties
            var properties = isArmstrong ? new List<String> { "armstrong", isOdd ? "odd" : "even" } : new List<String> { isOdd ? "odd" : "even" };

            // Calculate digit sum
            int digitSum = Math.Abs(num).ToString().Sum(c => c - '0');

            var response = new NumberResponseDto
            {
                number = num,
                is_perfect = NumberUtils.IsPerfect(num),
                is_prime = NumberUtils.IsPrime(num),
                properties = properties,
                digit_sum = digitSum,
                fun_fact = funFact
            };
            
            return Ok(response);
        }
    }
}
