using Domain.DTOs;
using Domain.Model;

namespace Application.LogicInterfaces;

public interface IPostLogic
{
    Task<Post> CreateAsync(PostCreationDto dto);
    Task<IEnumerable<Post>> GetAsync(SearchPostParametersDto searchParameters);
    Task UpdateAsync(PostUpdateDto todo);
    Task DeleteAsync(int id);
    Task<PostBasicDto> GetByIdAsync(int id);

}