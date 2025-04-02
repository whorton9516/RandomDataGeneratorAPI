using Bogus;

using RandomDataGeneratorAPI.Models;

namespace RandomDataGeneratorAPI.Services;

public class DataGenerator : IDataGenerator
{
    public IEnumerable<Address> GenerateAddresses(int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> GenerateEmails(int count)
    {
        var faker = new Faker();
        return faker.Make(count, () => faker.Person.Email);
    }

    public IEnumerable<string> GenerateNames(int count)
    {
        var faker = new Faker();
        return faker.Make(count, () => faker.Person.FullName);
    }

    public IEnumerable<string> GeneratePhoneNumbers(int count)
    {
        var faker = new Faker();
        return faker.Make(count, () => faker.Person.Phone);
    }

    public IEnumerable<string> GenerateUsernames(int count)
    {
        var faker = new Faker();
        return faker.Make(count, () => faker.Person.UserName);
    }

    public IEnumerable<User> GenerateUsers(int count)
    {
        throw new NotImplementedException();
    }
}
