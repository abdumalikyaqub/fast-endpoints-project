﻿namespace FastEndApp.API.Contracts.Requests;

public class UserRequest
{
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
    public int Age { get; init; } = default!;
}
