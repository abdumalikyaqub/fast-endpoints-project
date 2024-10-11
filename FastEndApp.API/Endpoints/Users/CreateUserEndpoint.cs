using FastEndApp.API.Contracts.Requests;
using FastEndApp.API.Contracts.Responses;
using FastEndApp.API.Database.Contexts;
using FastEndApp.API.Mappers;
using FastEndpoints;

namespace FastEndApp.API.Endpoints.Users;

public class CreateUserEndpoint : Endpoint<UserRequest,UserResponse,UserMapper>
{
    
    private readonly AppDbContext _context;
    public CreateUserEndpoint(AppDbContext context)
    {
        _context = context;
    }
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
    }
    /// <summary>
    /// Create user 
    /// </summary>
    /// <param name="req"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public override async Task HandleAsync(UserRequest req, CancellationToken ct)
    {
        var user = await Map.ToEntityAsync(req);

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        var response = await Map.FromEntityAsync(user);

        await SendAsync(response, cancellation: ct);
    }
}
