namespace LibraryStandard.Interfaces
{
    using LibraryStandard.People;

    public interface IPerson
    {
        string GetCredentials(Person person);
        string GetEmail(Person person);
        string GetAddress(Person person);
        string GetTelNumber(Person person);

        string GetFullName();
    }
}