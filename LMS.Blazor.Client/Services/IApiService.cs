﻿namespace LMS.Blazor.Client.Services;

public interface IApiService
{
    Task<T?> CallApiAsync<T>(string endpoint, CancellationToken ct = default);

}
