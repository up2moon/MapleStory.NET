namespace MapleStory.NET.Api;
/// <inheritdoc />
public class UnionApi : BaseApi, IUnionApi
{
    private const string ResourcePath = "/maplestory/v1/user";
    private const string UnionEndpoint = "union";
    private const string UnionRaiderEndpoint = "union-raider";
    private const string UnionArtifactEndpoint = "union-artifact";
    private static DateOnly ApiLaunchDate => new(2023, 12, 21);

    internal UnionApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    /// <inheritdoc />
    public Task<CallResult<Union>> GetAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<Union>(UnionEndpoint, ocid, date, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<UnionRaider>(UnionRaiderEndpoint, ocid, date, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<UnionArtifact>> GetArtifactAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<UnionArtifact>(UnionArtifactEndpoint, ocid, date, cancellationToken);

    private Task<CallResult<T>> GetAsync<T>(string endpoint, string ocid, DateOnly? date, CancellationToken cancellationToken) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        ArgumentException.ThrowIfNullOrWhiteSpace(ocid);

        var parameters = new Dictionary<string, string>
        {
            ["ocid"] = ocid,
        };
        
        if (date is not null)
        {
            Helper.ThrowIfBeforeApiLaunch(date.Value, ApiLaunchDate);
            parameters["date"] = date.Value.ToString("yyyy-MM-dd");
        }
        
        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, cancellationToken);
    }
}