using RandomDataGeneratorAPI.Models;

namespace RandomDataGeneratorAPI.Services;

public interface IDataGenerator
{
    IEnumerable<string> GenerateNames(int count);
    IEnumerable<Address> GenerateAddresses(int count);
    IEnumerable<string> GenerateEmails(int count);
    IEnumerable<User> GenerateUsers(int count);
    IEnumerable<string> GeneratePhoneNumbers(int count);
    IEnumerable<string> GenerateUsernames(int count);
}
