using Domain.DTOs;
using Domain.Model;

namespace HttpClients.ClientInterfaces;

public interface IPostService
{
    Task CreateAsync(PostCreationDto dto);
    Task<ICollection<Post>> GetAsync(
        string? userName, 
        int? userId, 
        bool? completedStatus, 
        string? titleContains
    );
} 
