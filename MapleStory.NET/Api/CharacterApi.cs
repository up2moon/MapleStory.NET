namespace MapleStory.NET.Api;
/// <inheritdoc />
public class CharacterApi : BaseApi, ICharacterApi
{
    private const string ResourcePath = "/maplestory/v1/character";
    private const string BasicEndpoint = "basic";
    private const string PopularityEndpoint = "popularity";
    private const string StatEndpoint = "stat";
    private const string HyperStatEndpoint = "hyper-stat";
    private const string PropensityEndpoint = "propensity";
    private const string AbilityEndpoint = "ability";
    private const string ItemEquipmentEndpoint = "item-equipment";
    private const string CashItemEquipmentEndpoint = "cashitem-equipment";
    private const string SymbolEquipmentEndpoint = "symbol-equipment";
    private const string SetEffectEndpoint = "set-effect";
    private const string BeautyEquipmentEndpoint = "beauty-equipment";
    private const string AndroidEquipmentEndpoint = "android-equipment";
    private const string PetEquipmentEndpoint = "pet-equipment";
    private const string SkillEndpoint = "skill";
    private const string LinkSkillEndpoint = "link-skill";
    private const string VMatrixEndpoint = "vmatrix";
    private const string HexaMatrixEndpoint = "hexamatrix";
    private const string HexaMatrixStatEndpoint = "hexamatrix-stat";
    private const string DojangEndpoint = "dojang";
    private static DateOnly ApiLaunchDate => new(2023, 12, 21);

    internal CharacterApi(ILogger logger, HttpClient httpClient) : base(logger, httpClient) { }

    /// <inheritdoc />
    public Task<CallResult<Character>> GetAsync(string characterName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(characterName);
        var parameters = new Dictionary<string, string> { ["character_name"] = characterName };
        return GetAsync<Character>("/maplestory/v1/id", parameters, cancellationToken);
    }

    /// <inheritdoc />
    public Task<CallResult<CharacterBasic>> GetBasicAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterBasic>(BasicEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPopularity>> GetPopularityAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterPopularity>(PopularityEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterStat>> GetStatAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterStat>(StatEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHyperStat>> GetHyperStatAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterHyperStat>(HyperStatEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPropesity>> GetPropensityAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterPropesity>(PropensityEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterAbility>> GetAbilityAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterAbility>(AbilityEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterItemEquipment>> GetItemEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterItemEquipment>(ItemEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterCashItemEquipment>> GetCashItemEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterCashItemEquipment>(CashItemEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSymbolEquipment>> GetSymbolEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterSymbolEquipment>(SymbolEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSetEffect>> GetSetEffectAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterSetEffect>(SetEffectEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterBeautyEquipment>> GetBeautyEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterBeautyEquipment>(BeautyEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterAndroidEquipment>> GetAndroidEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterAndroidEquipment>(AndroidEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterPetEquipment>> GetPetEquipmentAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterPetEquipment>(PetEquipmentEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterSkill>> GetSkillAsync(string ocid, string characterSkillGrade, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterSkill>(SkillEndpoint, ocid, date, new() { ["character_skill_grade"] = characterSkillGrade }, cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterLinkSkill>> GetLinkSkillAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterLinkSkill>(LinkSkillEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterVMatrix>> GetVMatrixAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterVMatrix>(VMatrixEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHexaMatrix>> GetHexaMatrixAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterHexaMatrix>(HexaMatrixEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterHexaMatrixStat>> GetHexaMatrixStatAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterHexaMatrixStat>(HexaMatrixStatEndpoint, ocid, date, [], cancellationToken);
    /// <inheritdoc />
    public Task<CallResult<CharacterDojang>> GetDojangAsync(string ocid, DateOnly? date = null, CancellationToken cancellationToken = default) => GetAsync<CharacterDojang>(DojangEndpoint, ocid, date, [], cancellationToken);
    private Task<CallResult<T>> GetAsync<T>(string endpoint, string ocid, DateOnly? date, Dictionary<string, string> parameters, CancellationToken cancellationToken) where T : class
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(endpoint);
        ArgumentException.ThrowIfNullOrWhiteSpace(ocid);

        if (date is not null)
        {
            Helper.ThrowIfBeforeApiLaunch(date.Value, ApiLaunchDate);
            parameters["date"] = date.Value.ToString("yyyy-MM-dd");
        }

        parameters["ocid"] = ocid;

        return GetAsync<T>($"{ResourcePath}/{endpoint}", parameters, cancellationToken);
    }
}
