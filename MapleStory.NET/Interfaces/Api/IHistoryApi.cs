namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// For accessing various MapleStory history-related data via API endpoints.
/// Each method retrieves a specific type of data and returns the result in a CallResult object.
/// </summary>
public interface IHistoryApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/ouid or /maplestory/legacy/ouid
    /// <para>Gets identifier (ouid) of a user based on API key.</para>
    /// </summary>
    /// <param name="isLegacyOuid">Whether to use legacy API.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing User object on success or error on failure.</returns>
    Task<CallResult<User>> GetUserAsync(bool isLegacyOuid = false, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/starforce
    /// <para>Gets Star Force Enhancement results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from December 27, 2023 onwards.</b></para>
    /// <para>It can be retrieved after up to 5 minutes.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="date">Reference date (KST).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing StarforceHistory object on success or error on failure.</returns>
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/starforce
    /// <para>Gets Star Force Enhancement results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from December 27, 2023 onwards.</b></para>
    /// <para>It can be retrieved after up to 5 minutes.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="cursor">Cursor for paging.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing StarforceHistory object on success or error on failure.</returns>
    Task<CallResult<StarforceHistory>> GetStarforceHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/potential
    /// <para>Gets reset potentials of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from January 25, 2024 onwards.</b></para>
    /// <para>Daily data is updated at 4 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="date">Reference date (KST).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing PotentialHistory object on success or error on failure.</returns>
    Task<CallResult<PotentialHistory>> GetPotentialHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/potential
    /// <para>Gets reset potentials of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from January 25, 2024 onwards.</b></para>
    /// <para>Daily data is updated at 4 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="cursor">Cursor for paging.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing PotentialHistory object on success or error on failure.</returns>
    Task<CallResult<PotentialHistory>> GetPotentialHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/cube
    /// <para>Gets Cube usage results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from November 25, 2022 onwards.</b></para>
    /// <para>Daily data is updated at 4 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="date">Reference date (KST).</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CubeHistory object on success or error on failure.</returns>
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, DateOnly date, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/history/cube
    /// <para>Gets Cube usage results of the user based on API key.</para>
    /// <para><b>NOTE: Data available only from November 25, 2022 onwards.</b></para>
    /// <para>Daily data is updated at 4 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// </summary>
    /// <param name="count">The number of results to be fetched. (10 &lt;= count &lt;= 1000)</param>
    /// <param name="cursor">Cursor for paging.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CubeHistory object on success or error on failure.</returns>
    Task<CallResult<CubeHistory>> GetCubeHistoryAsync(int count, string cursor, CancellationToken cancellationToken = default);
}
