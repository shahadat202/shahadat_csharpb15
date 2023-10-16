namespace OOPBasics
{
    class Person
    {
        private string firstName;
        public string LastName { get; set; }

        public string FirstName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(firstName))
                    return string.Empty;
                return firstName;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                    firstName = value;
            }
        }
        public string FullName
        {
            get
            {
                return firstName + " " + LastName;
            }
        }
        public Person() : this(string.Empty, string.Empty)
        {
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.LastName = lastName;
        }
        public string GetName(string separator)
        {
            string fullName = firstName + separator + LastName;
            return fullName;
        }
        public string GetName(string[] separator)
        {
            return GetName(separator[0]);
        }
    }
}