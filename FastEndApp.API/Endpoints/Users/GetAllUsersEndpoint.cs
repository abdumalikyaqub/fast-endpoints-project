using FastEndApp.API.Contracts.Requests;
using FastEndApp.API.Contracts.Responses;
using FastEndApp.API.Database.Contexts;
using FastEndApp.API.Mappers;
using FastEndApp.Core.Entities;
using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using IMapper = AutoMapper.IMapper;

namespace FastEndApp.API.Endpoints.Users;

public class GetAllUsersEndpoint : EndpointWithoutRequest<IEnumerable<GetUsersResponse>>
{
    private readonly IMapper _mapper;
    private readonly AppDbContext _context;
    public GetAllUsersEndpoint(IMapper mapper, AppDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }
    public override void Configure()
    {
        Get("/api/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        IEnumerable<User> users = await _context.Users.ToListAsync();

        //GetUsersResponse getUsersResponse = new GetUsersResponse()
        //{
        //    Users = users.Select(u => _mapper.Map<UserResponse>(u))
        //};

        var getUsersResponse = _mapper.Map<IEnumerable<GetUsersResponse>> (users);

        await SendAsync(getUsersResponse, cancellation: ct);
    }
}
