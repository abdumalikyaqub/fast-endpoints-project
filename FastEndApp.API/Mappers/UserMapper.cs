using FastEndApp.API.Contracts.Requests;
using FastEndApp.API.Contracts.Responses;
using FastEndApp.Core.Entities;
using FastEndpoints;

namespace FastEndApp.API.Mappers;

public class UserMapper : Mapper<UserRequest, UserResponse, User>
{
    public override User ToEntity(UserRequest r) => new()
    {
        Id = Guid.NewGuid(),
        FirstName = r.FirstName,
        LastName = r.LastName,
        Age = r.Age
    };

    public override UserResponse FromEntity(User e) => new()
    {
        Id = e.Id,
        FullName = $"{e.LastName} {e.FirstName}",
        Age = e.Age
    };

    public override async Task<User> ToEntityAsync(UserRequest r, CancellationToken ct = default) => new()
    {
        Id = Guid.NewGuid(),
        FirstName = r.FirstName,
        LastName = r.LastName,
        Age = r.Age,
        CreatedAt = DateTime.UtcNow,
        UpdatedAt = DateTime.UtcNow
    };

    public override async Task<UserResponse> FromEntityAsync(User e, CancellationToken ct = default) => new()
    {
        Id = e.Id,
        FullName = $"{e.LastName} {e.FirstName}",
        Age = e.Age
    };
}
