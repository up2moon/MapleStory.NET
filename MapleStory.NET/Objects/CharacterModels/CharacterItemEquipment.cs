namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 장착 장비 정보
/// </summary>
/// <param name="CharacterGender"> 캐릭터 성별 </param>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="PresetNo"> 적용 중인 장비 프리셋 번호(number) </param>
/// <param name="ItemEquipment"> 장비 정보 리스트 </param>
/// <param name="ItemEquipmentPreset_1"> 1번 프리셋 장비 정보 리스트 </param>
/// <param name="ItemEquipmentPreset_2"> 2번 프리셋 장비 정보 리스트 </param>
/// <param name="ItemEquipmentPreset_3"> 3번 프리셋 장비 정보 리스트 </param>
/// <param name="Title"> 칭호 정보 </param>
/// <param name="DragonEquipment"> 에반 드래곤 장비 정보 리스트 (에반인 경우 응답) </param>
/// <param name="MechanicEquipment"> 메카닉 장비 정보 리스트 (메카닉인 경우 응답) </param>
public record CharacterItemEquipment(
    string? CharacterGender,
    string? CharacterClass,
    long? PresetNo,
    List<ItemEquipment>? ItemEquipment,
    List<ItemEquipment>? ItemEquipmentPreset_1,
    List<ItemEquipment>? ItemEquipmentPreset_2,
    List<ItemEquipment>? ItemEquipmentPreset_3,
    Title? Title,
    List<DragonEquipment>? DragonEquipment,
    List<MechanicEquipment>? MechanicEquipment)
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
}

/// <summary>
/// 장비 최종 옵션 정보
/// </summary>
/// <param name="Str"> STR </param>
/// <param name="Dex"> DEX </param>
/// <param name="Int"> INT </param>
/// <param name="Luk"> LUK </param>
/// <param name="MaxHp"> 최대 HP </param>
/// <param name="MaxMp"> 최대 MP </param>
/// <param name="AttackPower"> 공격력 </param>
/// <param name="MagicPower"> 마력 </param>
/// <param name="Armor"> 방어력 </param>
/// <param name="Speed"> 이동속도 </param>
/// <param name="Jump"> 점프력 </param>
/// <param name="BossDamage"> 보스 공격 시 데미지 증가 (%) </param>
/// <param name="IgnoreMonsterArmor"> 몬스터 방어율 무시 (%) </param>
/// <param name="AllStat"> 올스탯 (%) </param>
/// <param name="Damage"> 데미지 (%) </param>
/// <param name="EquipmentLevelDecrease"> 착용 레벨 감소 </param>
/// <param name="MaxHpRate"> 최대 HP (%) </param>
/// <param name="MaxMpRate"> 최대 MP (%) </param>
public record ItemTotalOption(
    string? Str,
    string? Dex,
    string? Int,
    string? Luk,
    string? MaxHp,
    string? MaxMp,
    string? AttackPower,
    string? MagicPower,
    string? Armor,
    string? Speed,
    string? Jump,
    string? BossDamage,
    string? IgnoreMonsterArmor,
    string? AllStat,
    string? Damage,
    long? EquipmentLevelDecrease,
    string? MaxHpRate,
    string? MaxMpRate);

/// <summary>
/// 장비 스타포스 옵션 정보
/// </summary>
/// <param name="Str"> STR </param>
/// <param name="Dex"> DEX </param>
/// <param name="Int"> INT </param>
/// <param name="Luk"> LUK </param>
/// <param name="MaxHp"> 최대 HP </param>
/// <param name="MaxMp"> 최대 MP </param>
/// <param name="AttackPower"> 공격력 </param>
/// <param name="MagicPower"> 마력 </param>
/// <param name="Armor"> 방어력 </param>
/// <param name="Speed"> 이동속도 </param>
/// <param name="Jump"> 점프력 </param>
public record ItemStarforceOption(
    string? Str,
    string? Dex,
    string? Int,
    string? Luk,
    string? MaxHp,
    string? MaxMp,
    string? AttackPower,
    string? MagicPower,
    string? Armor,
    string? Speed,
    string? Jump);

/// <summary>
/// 장비 특별 옵션 정보
/// </summary>
/// <param name="Str"> STR </param>
/// <param name="Dex"> DEX </param>
/// <param name="Int"> INT </param>
/// <param name="Luk"> LUK </param>
/// <param name="MaxHp"> 최대 HP </param>
/// <param name="MaxMp"> 최대 MP </param>
/// <param name="AttackPower"> 공격력 </param>
/// <param name="MagicPower"> 마력 </param>
public record ItemExceptionalOption(
    string? Str,
    string? Dex,
    string? Int,
    string? Luk,
    string? MaxHp,
    string? MaxMp,
    string? AttackPower,
    string? MagicPower);

/// <summary>
/// 장비 추가 옵션 정보
/// </summary>
/// <param name="Str"> STR </param>
/// <param name="Dex"> DEX </param>
/// <param name="Int"> INT </param>
/// <param name="Luk"> LUK </param>
/// <param name="MaxHp"> 최대 HP </param>
/// <param name="MaxMp"> 최대 MP </param>
/// <param name="AttackPower"> 공격력 </param>
/// <param name="MagicPower"> 머력 </param>
/// <param name="Armor"> 방어력 </param>
/// <param name="Speed"> 이동속도 </param>
/// <param name="Jump"> 점프력 </param>
/// <param name="BossDamage"> 보스 공격 시 데미지 증가 (%) </param>
/// <param name="Damage"> 데미지 (%) </param>
/// <param name="AllStat"> 올스탯 (%) </param>
/// <param name="EquipmentLevelDecrease"> 착용 레벨 감소 </param>
public record ItemAddOption(
    string? Str,
    string? Dex,
    string? Int,
    string? Luk,
    string? MaxHp,
    string? MaxMp,
    string? AttackPower,
    string? MagicPower,
    string? Armor,
    string? Speed,
    string? Jump,
    string? BossDamage,
    string? Damage,
    string? AllStat,
    long? EquipmentLevelDecrease);

/// <summary>
/// 장비 기본 옵션 정보
/// </summary>
/// <param name="Str"> STR </param>
/// <param name="Dex"> DEX </param>
/// <param name="Int"> INT </param>
/// <param name="Luk"> LUK </param>
/// <param name="MaxHp"> 최대 HP </param>
/// <param name="MaxMp"> 최대 MP </param>
/// <param name="AttackPower"> 공격력 </param>
/// <param name="MagicPower"> 마력 </param>
/// <param name="Armor"> 방어력 </param>
/// <param name="Speed"> 이동속도 </param>
/// <param name="Jump"> 점프력 </param>
/// <param name="BossDamage"> 보스 공격 시 데미지 증가 (%) </param>
/// <param name="IgnoreMonsterArmor"> 몬스터 방어율 무시 (%) </param>
/// <param name="AllStat"> 올스탯 (%) </param>
/// <param name="MaxHpRate"> 최대 HP (%) </param>
/// <param name="MaxMpRate"> 최대 MP (%) </param>
/// <param name="BaseEquipmentLevel"> 기본 착용 레벨 </param>
public record ItemBaseOption(
    string? Str,
    string? Dex,
    string? Int,
    string? Luk,
    string? MaxHp,
    string? MaxMp,
    string? AttackPower,
    string? MagicPower,
    string? Armor,
    string? Speed,
    string? Jump,
    string? BossDamage,
    string? IgnoreMonsterArmor,
    string? AllStat,
    string? MaxHpRate,
    string? MaxMpRate,
    long? BaseEquipmentLevel);

/// <summary>
/// 장비 기타 옵션 정보
/// </summary>
/// <param name="Str"> STR </param>
/// <param name="Dex"> DEX </param>
/// <param name="Int"> INT </param>
/// <param name="Luk"> LUK </param>
/// <param name="MaxHp"> 최대 HP </param>
/// <param name="MaxMp"> 최대 MP </param>
/// <param name="AttackPower"> 공격력 </param>
/// <param name="MagicPower"> 마력 </param>
/// <param name="Armor"> 방어력 </param>
/// <param name="Speed"> 이동속도 </param>
/// <param name="Jump"> 점프력 </param>
public record ItemEtcOption(
    string? Str,
    string? Dex,
    string? Int,
    string? Luk,
    string? MaxHp,
    string? MaxMp,
    string? AttackPower,
    string? MagicPower,
    string? Armor,
    string? Speed,
    string? Jump);

/// <summary>
/// 장비 정보
/// </summary>
/// <param name="ItemEquipmentPart"> 장비 부위 명 </param>
/// <param name="ItemEquipmentSlot"> 장비 슬롯 위치 </param>
/// <param name="ItemName"> 장비 명 </param>
/// <param name="ItemIcon"> 장비 아이콘 URL </param>
/// <param name="ItemDescription"> 장비 설명 </param>
/// <param name="ItemShapeName"> 장비 외형 </param>
/// <param name="ItemShapeIcon"> 장비 외형 아이콘 URL </param>
/// <param name="ItemGender"> 전용 성별 </param>
/// <param name="ItemTotalOption"> 장비 최종 옵션 정보 </param>
/// <param name="ItemBaseOption"> 장비 기본 옵션 정보 </param>
/// <param name="PotentialOptionGrade"> 잠재능력 등급 </param>
/// <param name="AdditionalPotentialOptionGrade"> 에디셔널 잠재능력 등급 </param>
/// <param name="PotentialOption_1"> 잠재능력 첫 번째 옵션 </param>
/// <param name="PotentialOption_2"> 잠재능력 두 번째 옵션 </param>
/// <param name="PotentialOption_3"> 잠재능력 세 번째 옵션 </param>
/// <param name="AdditionalPotentialOption_1"> 에디셔널 잠재능력 첫 번째 옵션 </param>
/// <param name="AdditionalPotentialOption_2"> 에디셔널 잠재능력 두 번째 옵션 </param>
/// <param name="AdditionalPotentialOption_3"> 에디셔널 잠재능력 세 번째 옵션 </param>
/// <param name="EquipmentLevelIncrease"> 착용 레벨 증가 </param>
/// <param name="ItemExceptionalOption"> 장비 특별 옵션 정보 </param>
/// <param name="ItemAddOption"> 장비 추가 옵션 정보 </param>
/// <param name="GrowthExp"> 성장 경험치 </param>
/// <param name="GrowthLevel"> 성장 레벨 </param>
/// <param name="ScrollUpgrade"> 업그레이드 횟수 </param>
/// <param name="CuttableCount"> 가위 사용 가능 횟수 (교환 불가 장비, 가위 횟수가 없는 교환 가능 장비는 255) </param>
/// <param name="GoldenHammerFlag"> 황금 망치 재련 적용 (1: 적용, 이외 미적용) </param>
/// <param name="ScrollResilienceCount"> 복구 가능 횟수 </param>
/// <param name="ScrollUpgradeableCount"> 업그레이드 가능 횟수 </param>
/// <param name="SoulName"> 소울 명 </param>
/// <param name="SoulOption"> 소울 옵션 </param>
/// <param name="ItemEtcOption"> 장비 기타 옵션 정보 </param>
/// <param name="Starforce"> 강화 단계 </param>
/// <param name="StarforceScrollFlag"> 놀라운 장비 강화 주문서 사용 여부 (0: 미사용, 1: 사용) </param>
/// <param name="ItemStarforceOption"> 장비 스타포스 옵션 정보 </param>
/// <param name="SpecialRingLevel"> 특수 반지 레벨 </param>
public record ItemEquipment(
    string? ItemEquipmentPart,
    string? ItemEquipmentSlot,
    string? ItemName,
    string? ItemIcon,
    string? ItemDescription,
    string? ItemShapeName,
    string? ItemShapeIcon,
    string? ItemGender,
    ItemTotalOption? ItemTotalOption,
    ItemBaseOption? ItemBaseOption,
    string? PotentialOptionGrade,
    string? AdditionalPotentialOptionGrade,
    string? PotentialOption_1,
    string? PotentialOption_2,
    string? PotentialOption_3,
    string? AdditionalPotentialOption_1,
    string? AdditionalPotentialOption_2,
    string? AdditionalPotentialOption_3,
    long? EquipmentLevelIncrease,
    ItemExceptionalOption? ItemExceptionalOption,
    ItemAddOption? ItemAddOption,
    long? GrowthExp,
    long? GrowthLevel,
    string? ScrollUpgrade,
    string? CuttableCount,
    string? GoldenHammerFlag,
    string? ScrollResilienceCount,
    string? ScrollUpgradeableCount,
    string? SoulName,
    string? SoulOption,
    ItemEtcOption? ItemEtcOption,
    string? Starforce,
    string? StarforceScrollFlag,
    ItemStarforceOption? ItemStarforceOption,
    long? SpecialRingLevel)
{
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 장비 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
}

/// <summary>
/// 메카닉 장비 정보 (메카닉인 경우 응답)
/// </summary>
/// <param name="ItemEquipmentPart"> 장비 부위 명 </param>
/// <param name="ItemEquipmentSlot"> 장비 슬롯 위치 </param>
/// <param name="ItemName"> 장비 명 </param>
/// <param name="ItemIcon"> 장비 아이콘 URL </param>
/// <param name="ItemDescription"> 장비 설명 </param>
/// <param name="ItemShapeName"> 장비 외형 </param>
/// <param name="ItemShapeIcon"> 장비 외형 아이콘 URL </param>
/// <param name="ItemGender"> 전용 성별 </param>
/// <param name="ItemTotalOption"> 장비 최종 옵션 정보 </param>
/// <param name="ItemBaseOption"> 장비 기본 옵션 정보 </param>
/// <param name="EquipmentLevelIncrease"> 착용 레벨 증가 </param>
/// <param name="ItemExceptionalOption"> 장비 특별 옵션 정보 </param>
/// <param name="ItemAddOption"> 장비 추가 옵션 정보 </param>
/// <param name="GrowthExp"> 성장 경험치 </param>
/// <param name="GrowthLevel"> 성장 레벨 </param>
/// <param name="ScrollUpgrade"> 업그레이드 횟수 </param>
/// <param name="CuttableCount"> 가위 사용 가능 횟수 (교환 불가 장비, 가위 횟수가 없는 교환 가능 장비는 255) </param>
/// <param name="GoldenHammerFlag"> 황금 망치 재련 적용 (1: 적용, 이외 미적용) </param>
/// <param name="ScrollResilienceCount"> 복구 가능 횟수 </param>
/// <param name="ScrollUpgradeableCount"> 업그레이드 가능 횟수 </param>
/// <param name="SoulName"> 소울 명 </param>
/// <param name="SoulOption"> 소울 옵션 </param>
/// <param name="ItemEtcOption"> 장비 기타 옵션 정보 </param>
/// <param name="Starforce"> 강화 단계 </param>
/// <param name="StarforceScrollFlag"> 놀라운 장비 강화 주문서 사용 여부 (0: 미사용, 1: 사용) </param>
/// <param name="ItemStarforceOption"> 장비 스타포스 옵션 정보 </param>
/// <param name="SpecialRingLevel"> 특수 반지 레벨 </param>
public record MechanicEquipment(
    string? ItemEquipmentPart,
    string? ItemEquipmentSlot,
    string? ItemName,
    string? ItemIcon,
    string? ItemDescription,
    string? ItemShapeName,
    string? ItemShapeIcon,
    string? ItemGender,
    ItemTotalOption? ItemTotalOption,
    ItemBaseOption? ItemBaseOption,
    long? EquipmentLevelIncrease,
    ItemExceptionalOption? ItemExceptionalOption,
    ItemAddOption? ItemAddOption,
    long? GrowthExp,
    long? GrowthLevel,
    string? ScrollUpgrade,
    string? CuttableCount,
    string? GoldenHammerFlag,
    string? ScrollResilienceCount,
    string? ScrollUpgradeableCount,
    string? SoulName,
    string? SoulOption,
    ItemEtcOption? ItemEtcOption,
    string? Starforce,
    string? StarforceScrollFlag,
    ItemStarforceOption? ItemStarforceOption,
    long? SpecialRingLevel)
{
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 장비 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
}

/// <summary>
/// 에반 드래곤 장비 정보 (에반인 경우 응답)
/// </summary>
/// <param name="ItemEquipmentPart"> 장비 부위 명 </param>
/// <param name="ItemEquipmentSlot"> 장비 슬롯 위치 </param>
/// <param name="ItemName"> 장비 명 </param>
/// <param name="ItemIcon"> 장비 아이콘 URL </param>
/// <param name="ItemDescription"> 장비 설명 </param>
/// <param name="ItemShapeName"> 장비 외형 </param>
/// <param name="ItemShapeIcon"> 장비 외형 아이콘 URL </param>
/// <param name="ItemGender"> 전용 성별 </param>
/// <param name="ItemTotalOption"> 장비 최종 옵션 정보 </param>
/// <param name="ItemBaseOption"> 장비 기본 옵션 정보 </param>
/// <param name="EquipmentLevelIncrease"> 착용 레벨 증가 </param>
/// <param name="ItemExceptionalOption"> 장비 특별 옵션 정보 </param>
/// <param name="ItemAddOption"> 장비 추가 옵션 정보 </param>
/// <param name="GrowthExp"> 성장 경험치 </param>
/// <param name="GrowthLevel"> 성장 레벨 </param>
/// <param name="ScrollUpgrade"> 업그레이드 횟수. </param>
/// <param name="CuttableCount"> 가위 사용 가능 횟수 (교환 불가 장비, 가위 횟수가 없는 교환 가능 장비는 255) </param>
/// <param name="GoldenHammerFlag"> 황금 망치 재련 적용 (1:적용, 이외 미적용) </param>
/// <param name="ScrollResilienceCount"> 복구 가능 횟수 </param>
/// <param name="ScrollUpgradeableCount"> 업그레이드 가능 횟수 </param>
/// <param name="SoulName"> 소울 명 </param>
/// <param name="SoulOption"> 소울 옵션 </param>
/// <param name="ItemEtcOption"> 장비 기타 옵션 정보 </param>
/// <param name="Starforce"> 강화 단계 </param>
/// <param name="StarforceScrollFlag"> 놀라운 장비 강화 주문서 사용 여부 (0:미사용, 1:사용) </param>
/// <param name="ItemStarforceOption"> 장비 스타포스 옵션 정보 </param>
/// <param name="SpecialRingLevel"> 특수 반지 레벨 </param>
public record DragonEquipment(
    string? ItemEquipmentPart,
    string? ItemEquipmentSlot,
    string? ItemName,
    string? ItemIcon,
    string? ItemDescription,
    string? ItemShapeName,
    string? ItemShapeIcon,
    string? ItemGender,
    ItemTotalOption? ItemTotalOption,
    ItemBaseOption? ItemBaseOption,
    long? EquipmentLevelIncrease,
    ItemExceptionalOption? ItemExceptionalOption,
    ItemAddOption? ItemAddOption,
    long? GrowthExp,
    long? GrowthLevel,
    string? ScrollUpgrade,
    string? CuttableCount,
    string? GoldenHammerFlag,
    string? ScrollResilienceCount,
    string? ScrollUpgradeableCount,
    string? SoulName,
    string? SoulOption,
    ItemEtcOption? ItemEtcOption,
    string? Starforce,
    string? StarforceScrollFlag,
    ItemStarforceOption? ItemStarforceOption,
    long? SpecialRingLevel)
{
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 장비 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
}

/// <summary>
/// 칭호 정보
/// </summary>
/// <param name="TitleName"> 칭호 장비 명 </param>
/// <param name="TitleIcon"> 칭호 아이콘 URL </param>
/// <param name="TitleDescription"> 칭호 설명 </param>
public record Title(string? TitleName, string? TitleIcon, string? TitleDescription)
{
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 칭호 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    /// <summary>
    /// 칭호 옵션 유효 기간 (KST, expired: 만료, null: 무제한)
    /// </summary>
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
}