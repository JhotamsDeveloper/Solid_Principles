namespace Suluction_O.Interfaces
{
    public interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        public IAccountService Processor { get; set; }
    }
}