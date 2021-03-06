using Problem_O.Models;

namespace Problem_O.Services
{
    public class AccountServices
    {
        public Staff Create(Person person)
        {
            Staff staff = new Staff();
            staff.FirstName = person.FirstName;
            staff.LastName = person.LastName;

            switch (person.Role)
            {
                case Role.Ceo:
                    staff.Email = $"{person.FirstName}.{person.LastName}@Ceo.com";
                    break;

                case Role.ProductOwner:
                    staff.Email = $"{person.FirstName}.{person.LastName}@ProductOwner.com";
                    break;

                case Role.Developer:
                    staff.Email = $"{person.FirstName}.{person.LastName}@Desarrollador.com";
                    break;

                case Role.ScrumMaster:
                    staff.Email = $"{person.FirstName}.{person.LastName}@ScrumMaster.com";
                    break;

                case Role.QA:
                    staff.Email = $"{person.FirstName}.{person.LastName}@QA.com";
                    break;
            }

            staff.Role = person.Role;
            return staff;
        }
    }
}
