namespace OOPBasics
{
    class Person
    {
        public string firstName; // field
        public string lastName;

        public Person()
        {
            firstName = string.Empty;
            lastName = string.Empty;
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetName(string separator)
        {
            string fullName = firstName + separator + lastName; 
            return fullName;
        }
        
        public string GetName(string[] separator)
        {
            string fullName = firstName + separator[0] + lastName;
            return fullName;
        }
    }
}