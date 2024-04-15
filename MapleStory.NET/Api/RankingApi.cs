namespace MapleStory.NET.Api;
/// <inheritdoc />
public class RankingApi : BaseApi, IRankingApi
{
    private const string ResourcePath = "/maplestory/v1/ranking";
    private const string OverallEndpoint = "overall";
    private const string UnionEndpoint = "union";
    private const string GuildEndpoint = "guild";
    private const string DojangEndpoint = "dojang";
    private const string TheSeedEndpoint = "theseed";
    private const string AchievementEndpoint = "achievement";

    private static DateOnly ApiLaunchDate => new(2023, 12, 22);

    internal RankingApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }
    /// <inheritdoc />
    public Task<CallResult<OverallRanking>> GetOverallRankingAsync(DateOnly date, World world = World.All, WorldType worldType = WorldType.Regular, Job job = Job.All, string? ocid = null, int page = 1, CancellationToken cancellationToken = default)
    {
        Dictionary<string, string> parameters = [];
        if (world == World.All)
            parameters["world_type"] = ((int)worldType).ToString();
        if (job != Job.All)
            parameters["class"] = FormatEnumToString(job);
        return GetAsync<OverallRanking>(OverallEndpoint, date, world, ocid, page, parameters, cancellationToken);
    }
    /// <inheritdoc />
    public Task<CallResult<UnionRanking>> GetUnionRankingAsync(DateOnly date, World world = World.All, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetAsync<UnionRanking>(UnionEndpoint, date, world, ocid, page, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<GuildRanking>> GetGuildRankingAsync(DateOnly date, GuildRankingType guildRankingType, World world = World.All, string? guildName = null, int page = 1, CancellationToken cancellationToken = default)
    {
        var parameters = new Dictionary<string, string>
        {
            ["ranking_type"] = ((int)guildRankingType).ToString(),
        };
        if (guildName is not null)
            parameters["guild_name"] = guildName;
        return GetAsync<GuildRanking>(GuildEndpoint, date, world, null, page, parameters, cancellationToken);
    }
    /// <inheritdoc />
    public Task<CallResult<DojangRanking>> GetDojangRankingAsync(DateOnly date, DojangDifficulty dojangDifficulty, World world = World.All, Job job = Job.All, string? ocid = null, int page = 1, CancellationToken cancellationToken = default)
    {
        var parameters = new Dictionary<string, string>
        {
            ["difficulty"] = ((int)dojangDifficulty).ToString(),
        };
        if (job != Job.All)
            parameters["class"] = FormatEnumToString(job);
        return GetAsync<DojangRanking>(DojangEndpoint, date, world, ocid, page, parameters, cancellationToken);
    }
    /// <inheritdoc />
    public Task<CallResult<TheSeedRanking>> GetTheSeedRankingAsync(DateOnly date, World world = World.All, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetAsync<TheSeedRanking>(TheSeedEndpoint, date, world, ocid, page, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<AchievementRanking>> GetAchievementRankingAsync(DateOnly date, string? ocid = null, int page = 1, CancellationToken cancellationToken = default) => GetAsync<AchievementRanking>(AchievementEndpoint, date, World.All, ocid, page, [], cancellationToken);
    private Task<CallResult<T>> GetAsync<T>(string endpoint, DateOnly date, World world, string? ocid, int page, Dictionary<string, string> parameters, CancellationToken cancellationToken) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        Helper.ThrowIfBeforeApiLaunch(date, ApiLaunchDate);
        parameters["date"] = date.ToString("yyyy-MM-dd");

        if (world != World.All && endpoint != AchievementEndpoint)
            parameters["world_name"] = world.ToString();
        if (ocid is not null && endpoint != GuildEndpoint)
            parameters["ocid"] = ocid;
        parameters["page"] = page.ToString();
        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, cancellationToken);
    }

    private static string FormatEnumToString(Job job) => job.ToString().Replace("전체_전직", "전체 전직").Replace("_불_독", "(불,독)").Replace("_썬_콜", "(썬,콜)").Replace("_패스파인더_", "(패스파인더)").Replace("_", "-");
}