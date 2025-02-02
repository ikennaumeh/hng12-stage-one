namespace HNGStageOne.API.Models.DTO
{
    public class NumberResponseDto
    {
        public int number { get; set; }
        public bool is_prime { get; set; }
        public bool is_perfect { get; set; }
        public List<String> properties { get; set; }
        public int digit_sum { get; set; }
        public string fun_fact { get; set; }
    }
}
