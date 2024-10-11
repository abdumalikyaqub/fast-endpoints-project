using AutoMapper.Internal;
using FastEndApp.API.Contracts.Requests;
using FastEndApp.API.Contracts.Responses;
using FastEndApp.API.Endpoints.Users;
using FastEndpoints;

namespace FastEndApp.API.Summaries;

public class CreateUserSummary : Summary<CreateUserEndpoint>
{
    public CreateUserSummary()
    {
        Summary = "short summary goes here";
        Description = "long description goes here";
        ExampleRequest = new UserRequest { FirstName = "Ali", LastName = "Hakimov", Age = 37 };
        Response<UserResponse>(200, "ok response with body", example: new() { Id = Guid.NewGuid(), FullName = "Karim Rasulov", Age = 56 });
        Response<ErrorResponse>(400, "validation failure");
        Response(404, "not found");
    }
}
