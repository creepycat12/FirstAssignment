namespace WestCoastEducation;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string PersonalNumber { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    public Person(string firstname, string lastname, string phonenumber, string email, string personalnumber, string address, string postalcode, string city)
    {
        FirstName = firstname;
        LastName = lastname;
        PhoneNumber = phonenumber;
        PersonalNumber = personalnumber;
        Email = email;
        Address = address;
        PostalCode = postalcode;
        City = city;
    }
    public override string ToString()
    {
        return $" Person: {FirstName} {LastName} \n Personal Number: {PersonalNumber} \n Contact info: Phone-Number: {PhoneNumber} E-mail: {Email} \n Adress: {Address} {City} {PostalCode} ";
    }
}
