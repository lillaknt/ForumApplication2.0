using Domain.DTOs;
using Domain.Model;

namespace HttpClients.ClientInterfaces;

public interface IUserService
{
    Task<User> CreateAsync(UserCreationDto dto);
    Task <IEnumerable<User>> GetUsersAsync(string? usernameContains = null);
}