namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// For accessing various MapleStory guild-related data via API endpoints.
/// Each method retrieves a specific type of data and returns the result in a CallResult object.
/// </summary>
/// <remarks>
/// Real-time data can be retrieved after an average of 15 minutes.
/// All API endpoints provide data only available from December 21, 2023, onwards.
/// When date is set, past data for a specific date is retrieved. Otherwise, real-time data is retrieved.
/// Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.
/// Be mindful that character's ocid may change with game updates, affecting ocid-based queries.
/// </remarks>
public interface IGuildApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/guild/id
    /// <para>Gets identifier (oguild_id) of a guild based on its name and the world name it belongs to.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="guildName">Name of a guild.</param>
    /// <param name="world">World the guild belongs to.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Guild object on success or error on failure.</returns>
    Task<CallResult<Guild>> GetAsync(string guildName, World world, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/guild/basic
    /// <para>Gets basic data of a guild based on its oguild_id.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="oguildId">Identifier of a guild.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Guild object on success or error on failure.</returns>
    Task<CallResult<GuildBasic>> GetBasicAsync(string oguildId, DateOnly? date = null, CancellationToken cancellationToken = default);
}
