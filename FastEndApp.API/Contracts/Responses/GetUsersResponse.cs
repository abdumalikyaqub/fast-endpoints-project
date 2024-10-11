namespace FastEndApp.API.Contracts.Responses;

public class GetUsersResponse
{
    //public IEnumerable<UserResponse> Users { get; set; } = Enumerable.Empty<UserResponse>();

    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
    public int Age { get; init; } = default!;
}
