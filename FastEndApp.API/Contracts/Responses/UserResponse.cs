namespace FastEndApp.API.Contracts.Responses;

public class UserResponse
{
    public Guid Id { get; set; }
    public string FullName { get; init; } = default!;
    public int Age { get; init; } = default!;
}
