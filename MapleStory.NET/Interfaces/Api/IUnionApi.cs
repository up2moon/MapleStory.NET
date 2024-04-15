namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// For accessing various MapleStory ranking-related data via API endpoints.
/// Each method retrieves a specific type of data and returns the result in a CallResult object.
/// </summary>
/// <remarks>
/// Real-time data can be retrieved after an average of 15 minutes.
/// All API endpoints provide data only available from December 21, 2023, onwards.
/// When date is set, past data for a specific date is retrieved. Otherwise, real-time data is retrieved.
/// Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.
/// Be mindful that character's ocid may change with game updates, affecting ocid-based queries.
/// </remarks>
public interface IUnionApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union
    /// <para>Gets union data.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Union object on success or error on failure.</returns>
    Task<CallResult<Union>> GetAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union-raider
    /// <para>Gets union raider data.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing UnionRaider object on success or error on failure.</returns>
    Task<CallResult<UnionRaider>> GetRaiderAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/user/union-artifact
    /// <para>Gets union artifact data.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that the character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing UnionArtifact object on success or error on failure.</returns>
    Task<CallResult<UnionArtifact>> GetArtifactAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
}