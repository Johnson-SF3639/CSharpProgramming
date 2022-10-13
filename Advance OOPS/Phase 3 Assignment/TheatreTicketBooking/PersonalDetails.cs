namespace TheatreTicketBooking
{
    /// <summary>
    /// PersonalDetails class
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Name property
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Age property
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// PhoneNumber property
        /// </summary>
        /// <value></value>
        public long PhoneNumber { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public PersonalDetails(){

        }

        /// <summary>
        /// Parameter PersonalDetails Constructor
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="age">age</param>
        /// <param name="phoneNubmer">Phone number</param>
        public PersonalDetails(string name, int age, long phoneNubmer){
            Name = name;
            Age = age;
            PhoneNumber = phoneNubmer;
        }

    }
}