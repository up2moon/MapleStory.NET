namespace MapleStory.NET.Api;
/// <inheritdoc />
public class HistoryApi : BaseApi, IHistoryApi
{
    private const string ResourcePath = "/maplestory/v1/history";
    private const string StarforceEndpoint = "starforce";
    private const string PotentialEndpoint = "potential";
    private const string CubeEndpoint = "cube";
    
    private static DateOnly StarforceApiLaunchDate => new(2023, 12, 27);
    private static DateOnly PotentialApiLaunchDate => new(2024, 1, 25);
    private static DateOnly CubeApiLaunchDate => new(2022, 11, 25);

    internal HistoryApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    /// <inheritdoc />
    public Task<CallResult<User>> GetUserAsync(bool isLegacyOuid = false, CancellationToken cancellationToken = default)
    {
        var endpoint = isLegacyOuid ? "/maplestory/legacy/ouid" : "/maplestory/v1/ouid";
        return GetAsync<User>(endpoint, [], cancellationToken);
    }
    /// <inheritdoc />
    public Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default) => GetStarforceHistoryAsync(count, date, null, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default) => GetStarforceHistoryAsync(count, null, cursor, cancellationToken);
    private Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, DateOnly? date, string? cursor, CancellationToken cancellationToken = default) => GetAsync<StarforceHistory>(StarforceEndpoint, count, date, cursor, StarforceApiLaunchDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<PotentialHistory>> GetPotentialHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default) => GetPotentialHistoryAsync(count, date, null, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<PotentialHistory>> GetPotentialHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default) => GetPotentialHistoryAsync(count, null, cursor, cancellationToken);
    private Task<CallResult<PotentialHistory>> GetPotentialHistoryAsync(int count, DateOnly? date, string? cursor, CancellationToken cancellationToken = default) => GetAsync<PotentialHistory>(PotentialEndpoint, count, date, cursor, PotentialApiLaunchDate, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default) => GetCubeHistoryAsync(count, date, null, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default) => GetCubeHistoryAsync(count, null, cursor, cancellationToken);
    private Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, DateOnly? date, string? cursor, CancellationToken cancellationToken = default) => GetAsync<CubeHistory>(CubeEndpoint, count, date, cursor, CubeApiLaunchDate, cancellationToken);
    private Task<CallResult<T>> GetAsync<T>(string endpoint, int count, DateOnly? date, string? cursor, DateOnly apiLaunchDate, CancellationToken cancellationToken) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        
        if (count is < 10 or > 1000)
            throw new ArgumentException("Count must be between 10 and 1000");

        var parameters = new Dictionary<string, string> { ["count"] = count.ToString() };

        if (date is not null)
        {
            Helper.ThrowIfBeforeApiLaunch(date.Value, apiLaunchDate);
            parameters["date"] = date.Value.ToString("yyyy-MM-dd");
        }
        else if (cursor is not null)
            parameters["cursor"] = cursor;
        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, cancellationToken);
    }
}