namespace MapleStory.NET;
/// <inheritdoc />
public class MapleStoryClient : IMapleStoryClient
{
    /// <summary>
    /// 캐릭터 API 호출을 위한 인터페이스
    /// </summary>
    public ICharacterApi CharacterApi { get; }
    /// <summary>
    /// 길드 API 호출을 위한 인터페이스
    /// </summary>
    public IGuildApi GuildApi { get; }
    /// <summary>
    /// 히스토리 API 호출을 위한 인터페이스
    /// </summary>
    public IHistoryApi HistoryApi { get; }
    /// <summary>
    /// 랭킹 API 호출을 위한 인터페이스
    /// </summary>
    public IRankingApi RankingApi { get; }
    /// <summary>
    /// 유니온 API 호출을 위한 인터페이스
    /// </summary>
    public IUnionApi UnionApi { get; }
    /// <summary>
    /// 로깅을 위한 인터페이스
    /// </summary>
    protected ILogger Logger { get; private set; }

    /// <summary>
    /// Initializes a new instance of the class with specified HttpClient, API key, and ILoggerFactory.
    /// </summary>
    /// <param name="httpClient">HttpClient instance used throughout the lifecycle</param>
    /// <param name="apiKey">API Key issued by Nexon Open API Center.</param>
    /// <param name="loggerFactory">ILoggerFactory instance used to create a logger for logging.</param>
    public MapleStoryClient(HttpClient httpClient, string apiKey, ILoggerFactory? loggerFactory = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
        httpClient.BaseAddress = new Uri(BaseApi.BaseAddress);
        httpClient.DefaultRequestHeaders.Add("x-nxopen-api-key", apiKey);

        const string Name = "MapleStory.NET";
        Logger = loggerFactory?.CreateLogger(Name) ?? NullLoggerFactory.Instance.CreateLogger(Name);
        Logger.LogTrace("{Name}: v{Version}", Name, typeof(MapleStoryClient).Assembly.GetName().Version);
        CharacterApi = new CharacterApi(Logger, httpClient);
        GuildApi = new GuildApi(Logger, httpClient);
        HistoryApi = new HistoryApi(Logger, httpClient);
        RankingApi = new RankingApi(Logger, httpClient);
        UnionApi = new UnionApi(Logger, httpClient);
    }
}
