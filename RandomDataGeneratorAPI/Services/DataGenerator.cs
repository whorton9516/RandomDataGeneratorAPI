using Bogus;

using RandomDataGeneratorAPI.Models;

namespace RandomDataGeneratorAPI.Services;

public class DataGenerator : IDataGenerator
{
    public IEnumerable<Address> GenerateAddresses(int count)
    {
        var faker = new Faker();
        return faker.Make(count, () => new Address
        {
            Street = faker.Address.StreetAddress(),
            City = faker.Address.City(),
            State = faker.Address.State(),
            ZipCode = faker.Address.ZipCode(),
            Country = faker.Address.Country()
        });
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
        var faker = new Faker();
        return faker.Make(count, () => new User
        {
            Name = faker.Person.FullName,
            Address = new Address
            {
                Street = faker.Address.StreetAddress(),
                City = faker.Address.City(),
                State = faker.Address.State(),
                ZipCode = faker.Address.ZipCode(),
                Country = faker.Address.Country()
            },
            Email = faker.Person.Email,
            PhoneNumber = faker.Person.Phone,
            Username = faker.Person.UserName
        });
    }
}
