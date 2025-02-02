namespace HNGStageOne.API.Repository
{
    public interface IFunFactRepository
    {
        Task<string> GetFunFact(int number);
    }
}
