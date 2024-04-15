namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 펫 장비 정보
/// </summary>
/// <param name="Pet_1Name"> 펫1 명 </param>
/// <param name="Pet_1Nickname"> 펫1 닉네임 </param>
/// <param name="Pet_1Icon"> 펫1 아이콘 URL </param>
/// <param name="Pet_1Description"> 펫1 설명 </param>
/// <param name="Pet_1Equipment"> 펫1 장착 정보 </param>
/// <param name="Pet_1AutoSkill"> 펫1 펫 버프 자동스킬 정보 </param>
/// <param name="Pet_1PetType"> 펫1 원더 펫 종류 </param>
/// <param name="Pet_1Skill"> 펫1 펫 보유 스킬 리스트 </param>
/// <param name="Pet_1Appearance"> 펫1 외형 </param>
/// <param name="Pet_1AppearanceIcon"> 펫1 외형 아이콘 URL </param>
/// <param name="Pet_2Name"> 펫2 명 </param>
/// <param name="Pet_2Nickname"> 펫2 닉네임 </param>
/// <param name="Pet_2Icon"> 펫2 아이콘 URL </param>
/// <param name="Pet_2Description"> 펫2 설명 </param>
/// <param name="Pet_2Equipment"> 펫2 장착 정보 </param>
/// <param name="Pet_2AutoSkill"> 펫2 펫 버프 자동 스킬 정보 </param>
/// <param name="Pet_2PetType"> 펫2 원더 펫 종류 </param>
/// <param name="Pet_2Skill"> 펫2 펫 보유 스킬 리스트 </param>
/// <param name="Pet_2Appearance"> 펫2 외형 </param>
/// <param name="Pet_2AppearanceIcon"> 펫2 외형 아이콘 URL </param>
/// <param name="Pet_3Name"> 펫3 명 </param>
/// <param name="Pet_3Nickname"> 펫3 닉네임 </param>
/// <param name="Pet_3Icon"> 펫3 아이콘 URL </param>
/// <param name="Pet_3Description"> 펫3 설명 </param>
/// <param name="Pet_3Equipment"> 펫3 장착 정보 </param>
/// <param name="Pet_3AutoSkill"> 펫3 펫 버프 자동 스킬 정보 </param>
/// <param name="Pet_3PetType"> 펫3 원더 펫 종류 </param>
/// <param name="Pet_3Skill"> 펫3 펫 보유 스킬 리스트 </param>
/// <param name="Pet_3Appearance"> 펫3 외형 </param>
/// <param name="Pet_3AppearanceIcon"> 펫3 외형 아이콘 URL </param>
public record CharacterPetEquipment(
    string? Pet_1Name,
    string? Pet_1Nickname,
    string? Pet_1Icon,
    string? Pet_1Description,
    PetEquipment? Pet_1Equipment,
    PetAutoSkill? Pet_1AutoSkill,
    string? Pet_1PetType,
    List<string>? Pet_1Skill,
    string? Pet_1Appearance,
    string? Pet_1AppearanceIcon,
    string? Pet_2Name,
    string? Pet_2Nickname,
    string? Pet_2Icon,
    string? Pet_2Description,
    PetEquipment? Pet_2Equipment,
    PetAutoSkill? Pet_2AutoSkill,
    string? Pet_2PetType,
    List<string>? Pet_2Skill,
    string? Pet_2Appearance,
    string? Pet_2AppearanceIcon,
    string? Pet_3Name,
    string? Pet_3Nickname,
    string? Pet_3Icon,
    string? Pet_3Description,
    PetEquipment? Pet_3Equipment,
    PetAutoSkill? Pet_3AutoSkill,
    string? Pet_3PetType,
    List<string>? Pet_3Skill,
    string? Pet_3Appearance,
    string? Pet_3AppearanceIcon)
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST, 일 단위 데이터로 시, 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
    
    private DateTimeOffset? _pet_1DateExpire;
    /// <summary>
    /// 펫1 마법의 시간 (KST, 시간 단위 데이터로 분은 일괄 0으로 표기)
    /// </summary>
    public DateTimeOffset? Pet_1DateExpire
    {
        get => _pet_1DateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _pet_1DateExpire = value;
    }
    
    private DateTimeOffset? _pet_2DateExpire;
    /// <summary>
    /// 펫2 마법의 시간 (KST, 시간 단위 데이터로 분은 일괄 0으로 표기)
    /// </summary>
    public DateTimeOffset? Pet_2DateExpire
    {
        get => _pet_2DateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _pet_2DateExpire = value;
    }
    
    private DateTimeOffset? _pet_3DateExpire;
    /// <summary>
    /// 펫3 마법의 시간 (KST, 시간 단위 데이터로 분은 일괄 0으로 표기)
    /// </summary>
    public DateTimeOffset? Pet_3DateExpire
    {
        get => _pet_3DateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _pet_3DateExpire = value;
    }
}

/// <summary>
/// 아이템 표기상 옵션
/// </summary>
/// <param name="OptionType"> 옵션 타입 </param>
/// <param name="OptionValue"> 옵션 값 </param>
public record ItemOption(string? OptionType, string? OptionValue);

/// <summary>
/// 펫 버프 자동스킬 정보
/// </summary>
/// <param name="Skill_1"> 첫 번째 슬롯에 등록된 자동 스킬 </param>
/// <param name="Skill_1Icon"> 첫 번째 슬롯에 등록된 자동 스킬 아이콘 URL </param>
/// <param name="Skill_2"> 두 번째 슬롯에 등록된 자동 스킬 </param>
/// <param name="Skill_2Icon"> 두 번째 슬롯에 등록된 자동 스킬 아이콘 URL </param>
public record PetAutoSkill(string? Skill_1, string? Skill_1Icon, string? Skill_2, string? Skill_2Icon);

/// <summary>
/// 펫 장착 정보
/// </summary>
/// <param name="ItemName"> 아이템 명 </param>
/// <param name="ItemIcon"> 아이템 아이콘 URL </param>
/// <param name="ItemDescription"> 아이템 설명 </param>
/// <param name="ItemOption"> 아이템 표기상 옵션 리스트 </param>
/// <param name="ScrollUpgrade"> 압그레이드 횟수 </param>
/// <param name="ScrollUpgradeable"> 업그레이드 가능 횟수 </param>
/// <param name="ItemShape"> 아이템 외형 </param>
/// <param name="ItemShapeIcon"> 아이템 외형 아이콘 URL </param> 
public record PetEquipment(string? ItemName, string? ItemIcon, string? ItemDescription, List<ItemOption>? ItemOption, long? ScrollUpgrade, long? ScrollUpgradeable, string? ItemShape, string? ItemShapeIcon);