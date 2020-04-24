namespace Library.Interfaces
{
    public interface IPerson
    {
        bool IsRole(Person.FunctionalRole role);
        string ShowCredentials(Person person);
        string ShowEmail(Person person);
        string ShowAddress(Person person);
        string ShowTelNumber(Person person);

        string ShowFullName();
    }
}