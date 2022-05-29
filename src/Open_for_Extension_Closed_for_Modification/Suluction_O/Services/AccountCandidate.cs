using Suluction_O.Interfaces;
using Suluction_O.Models;

namespace Suluction_O.Services
{
    internal class AccountCandidate : IAccountService
    {
        public Staff Create(IApplicant person)
        {
            Staff staff = new Staff();
            staff.FirstName = person.FirstName;
            staff.LastName = person.LastName;
            staff.Email = $"{person.FirstName}.{person.LastName}@Company.com";
            return staff;
        }
    }
}
