namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// For accessing various MapleStory ranking-related data via API endpoints.
/// Each method retrieves a specific type of data and returns the result in a CallResult object.
/// </summary>
/// <remarks>
/// All API endpoints provide data only available from December 22, 2023, onwards.
/// Daily data is updated at 8:30 AM KST the following day. Requests with date set before that time will result in 400 error.
/// Be mindful that character's ocid may change with game updates, affecting ocid-based queries.
/// </remarks>
public interface IRankingApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/ranking/overall
    /// <para>Gets overall ranking data.</para>
    /// <para><b>NOTE: Data available only from December 22, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 8:30 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="world">World whose data will be fetched.</param>
    /// <param name="worldType">World type whose data will be fetched. If world is set, this parameter is ignored.</param>
    /// <param name="job">Job whose data will be fetched.</param>
    /// <param name="ocid">The identifier of a character whose data will be fetched.</param>
    /// <param name="page">Page number.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing OverallRanking object on success or error on failure.</returns>
    Task<CallResult<OverallRanking>> GetOverallRankingAsync(DateOnly date, World world = World.All, WorldType worldType = WorldType.Regular, Job job = Job.All, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/ranking/union
    /// <para>Gets union ranking data.</para>
    /// <para><b>NOTE: Data available only from December 22, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 8:30 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="world">World whose data will be fetched.</param>
    /// <param name="ocid">The identifier of a character whose data will be fetched.</param>
    /// <param name="page">Page number.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing UnionRanking object on success or error on failure.</returns>
    Task<CallResult<UnionRanking>> GetUnionRankingAsync(DateOnly date, World world = World.All, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/ranking/guild
    /// <para>Gets guild ranking data.</para>
    /// <para><b>NOTE: Data available only from December 22, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 8:30 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="guildRankingType">Guild ranking type whose data will be fetched.</param>
    /// <param name="world">World whose data will be fetched.</param>
    /// <param name="guildName">Guild name whose data will be fetched.</param>
    /// <param name="page">Page number.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing GuildRanking object on success or error on failure.</returns>
    Task<CallResult<GuildRanking>> GetGuildRankingAsync(DateOnly date, GuildRankingType guildRankingType, World world = World.All, string? guildName = null, int page = 1, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/ranking/dojang
    /// <para>Gets Dojang (Mu Lung Dojo) ranking data.</para>
    /// <para><b>NOTE: Data available only from December 22, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 8:30 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="dojangDifficulty">Difficulty of the data to be fetched.</param>
    /// <param name="world">World whose data will be fetched.</param>
    /// <param name="job">Job whose data will be fetched.</param>
    /// <param name="ocid">The identifier of a character whose data will be fetched.</param>
    /// <param name="page">Page number.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing DojangRanking object on success or error on failure.</returns>
    Task<CallResult<DojangRanking>> GetDojangRankingAsync(DateOnly date, DojangDifficulty dojangDifficulty, World world = World.All, Job job = Job.All, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/ranking/theseed
    /// <para>Gets The Seed ranking data.</para>
    /// <para><b>NOTE: Data available only from December 22, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 8:30 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="world">World whose data will be fetched.</param>
    /// <param name="ocid">The identifier of a character whose data will be fetched.</param>
    /// <param name="page">Page number.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing TheSeedRanking object on success or error on failure.</returns>
    Task<CallResult<TheSeedRanking>> GetTheSeedRankingAsync(DateOnly date, World world = World.All, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/ranking/achievement
    /// <para>Gets achievement ranking data.</para>
    /// <para><b>NOTE: Data available only from December 22, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 8:30 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="date">Reference date (KST). If not specified, the most recent data is returned.</param>
    /// <param name="ocid">The identifier of a character whose data will be fetched.</param>
    /// <param name="page">Page number.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing AchievementRanking object on success or error on failure.</returns>
    Task<CallResult<AchievementRanking>> GetAchievementRankingAsync(DateOnly date, string? ocid = null, int page = 1, CancellationToken cancellationToken = default);
}