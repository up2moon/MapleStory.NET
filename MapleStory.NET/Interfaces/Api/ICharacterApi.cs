namespace MapleStory.NET.Interfaces.Api;
/// <summary>
/// For accessing various MapleStory character-related data via API endpoints.
/// Each method retrieves a specific type of data and returns the result in a CallResult object.
/// </summary>
/// <remarks>
/// Real-time data can be retrieved after an average of 15 minutes.
/// All API endpoints provide data only available from December 21, 2023, onwards.
/// When date is set, past data for a specific date is retrieved. Otherwise, real-time data is retrieved.
/// Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.
/// Be mindful that character's ocid may change with game updates, affecting ocid-based queries.
/// </remarks>
public interface ICharacterApi
{
    /// <summary>
    /// Endpoint: GET /maplestory/v1/id
    /// <para>Gets identifier (ocid) of a character based on its name.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="characterName">Name of a character.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing Character object on success or error on failure.</returns>
    Task<CallResult<Character>> GetAsync(string characterName, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/basic
    /// <para>Gets basic data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterBasic object on success or error on failure.</returns>
    Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/popularity
    /// <para>Gets popularity data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterPopularity object on success or error on failure.</returns>
    Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/stat
    /// <para>Gets stat data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterStat object on success or error on failure.</returns>
    Task<CallResult<CharacterStat>> GetStatAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// GET /maplestory/v1/character/hyper-stat
    /// <para>Gets Hyper stat data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterHyperStat object on success or error on failure.</returns>
    Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/propensity
    /// <para>Gets propensity data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterPropesity object on success or error on failure.</returns>
    Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/ability
    /// <para>Gets ability data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterAbility object on success or error on failure.</returns>
    Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/item-equipment
    /// <para>Gets item equipment data of a character except cash equipment.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterItemEquipment object on success or error on failure.</returns>
    Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/cashitem-equipment
    /// <para>Gets cash equipment data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterCashItemEquipment object on success or error on failure.</returns>
    Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/symbol-equipment
    /// <para>Gets equipped symbol data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterSymbolEquipment object on success or error on failure.</returns>
    Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/set-effect
    /// <para>Gets set effect data being applied to a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterSetEffect object on success or error on failure.</returns>
    Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/beauty-equipment
    /// <para>Gets hair, plastic surgery, and skin data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterBeautyEquipment object on success or error on failure.</returns>
    Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/android-equipment
    /// <para>Gets android data equipped with a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterAndroidEquipment object on success or error on failure.</returns>
    Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/pet-equipment
    /// <para>Gets pet, pet skill, and equipment data equipped with a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterPetEquipment object on success or error on failure.</returns>
    Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/skill
    /// <para>Gets skill and Hyper skill data of a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="characterSkillGrade">Skill grade of the class.
    /// <para>
    /// 0: 0th skills and Zero's public skills.
    /// </para>
    /// <para>
    /// 1: 1st skills.
    /// </para>
    /// <para>
    /// 1.5: 1.5th skills.
    /// </para>
    /// <para>
    /// 2: 2nd skills.
    /// </para>
    /// <para>
    /// 2.5: 2.5th skills.
    /// </para>
    /// <para>
    /// 3: 3rd skills.
    /// </para>
    /// <para>
    /// 4: 4th skills.
    /// </para>
    /// <para>
    /// hyperpassive: Hyper passive skills.
    /// </para>
    /// <para>
    /// hyperactive: Hyper active skills.
    /// </para>
    /// <para>
    /// 5: 5th skills.
    /// </para>
    /// <para>
    /// 6: 6th skills.
    /// </para>
    /// </param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterSkill object on success or error on failure.</returns>
    Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, string characterSkillGrade, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/link-skill
    /// <para>Gets link skill data equipped with a character.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterLinkSkill object on success or error on failure.</returns>
    Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/vmatrix
    /// <para>Gets data of V Matrix slots and V Cores mounted.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterVMatrix object on success or error on failure.</returns>
    Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/hexamatrix
    /// <para>Gets HEXA Cores data mounted on HEXA Matrix.</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterHexaMatrix object on success or error on failure.</returns>
    Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/hexamatrix-stat
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para>Gets HEXA stat data set to HEXA Matrix.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterHexaMatrixStat object on success or error on failure.</returns>
    Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Endpoint: GET /maplestory/v1/character/dojang
    /// <para>Gets record of Dojang (Mu Lung Dojo).</para>
    /// <para>Real-time data can be retrieved after an average of 15 minutes.</para>
    /// <para><b>NOTE: Data available only from December 21, 2023 onwards.</b></para>
    /// <para>Daily data is updated at 1 AM KST the following day. Requests with date set before that time will result in 400 error.</para>
    /// <para>Be mindful that character's ocid may change with game updates, affecting ocid-based queries.</para>
    /// </summary>
    /// <param name="ocid">Identifier of a character.</param>
    /// <param name="date">Reference date (KST). If null, real-time data is returned.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation if needed.</param>
    /// <returns>A call result containing CharacterDojang object on success or error on failure.</returns>
    Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default);
}