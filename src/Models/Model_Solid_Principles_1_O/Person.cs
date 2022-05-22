namespace Models.Model_Solid_Principles_1_O
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        //public bool IsDoctor { get; set; } = false;
        public Role Role { get; set; }
    }
}
