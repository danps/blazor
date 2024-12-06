using Bogus;

namespace MinhaPrimeiraApp.Components.Roteamento.Users;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public static class FakeDataUsers
{
    private static List<User> _users;

    public static List<User> Users
    {
        get
        {
            if (_users == null) 
                _users = List();
            return _users; 
        } }
    public static List<User> List()
    {
        var clienteFaker = new Faker<User>("pt_BR")
            .RuleFor(c => c.Id, f => f.IndexFaker)
            .RuleFor(c => c.Name, f => f.Name.FullName(Bogus.DataSets.Name.Gender.Female))
            .RuleFor(c => c.Email, f => f.Internet.Email(f.Person.FirstName).ToLower());
        var clientes = clienteFaker.Generate(10);
        return clientes;
    }
}


public class UserService : IUserService
{
    private List<User> users = FakeDataUsers.Users;
 

    public Task<User> GetUserByIdAsync(int id)
    {
        // Simulando uma chamada assíncrona
        return Task.FromResult(users.FirstOrDefault(u => u.Id == id));
    }

    public Task<List<User>> GetAllUsersAsync()
    {
        // Simulando uma chamada assíncrona para buscar todos os usuários
        return Task.FromResult(users);
    }
}

public interface IUserService
{
    Task<User> GetUserByIdAsync(int id);
    Task<List<User>> GetAllUsersAsync();
}