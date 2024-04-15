namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 장착 안드로이드 정보
/// </summary>
/// <param name="AndroidName"> 안드로이드 명 </param>
/// <param name="AndroidNickname"> 안드로이드 닉네임 </param>
/// <param name="AndroidIcon"> 안드로이드 아이콘 URL </param>
/// <param name="AndroidDescription"> 안드로이드 설명 </param>
/// <param name="AndroidHair"> 안드로이드 헤어 정보 </param>
/// <param name="AndroidFace"> 안드로이드 성형 정보 </param>
/// <param name="AndroidSkinName"> 안드로이드 피부 명 </param>
/// <param name="AndroidCashItemEquipment"> 안드로이드 캐시 아이템 장착 정보 리스트 </param>
/// <param name="AndroidEarSensorClipFlag"> 안드로이드 이어센서 클립 적용 여부 </param>
/// <param name="AndroidGender"> 안드로이드 성별 </param>
/// <param name="AndroidGrade"> 안드로이드 등급 </param>
/// <param name="AndroidNonHumanoidFlag"> 비인간형 안드로이드 여부 </param>
/// <param name="AndroidShopUsableFlag"> 잡화상점 이용 가능 여부 </param>
/// <param name="PresetNo"> 적용 중인 장비 프리셋 번호(number) </param>
/// <param name="AndroidPreset_1"> 1번 프리셋 안드로이드 정보 </param>
/// <param name="AndroidPreset_2"> 2번 프리셋 안드로이드 정보 </param>
/// <param name="AndroidPreset_3"> 3번 프리셋 안드로이드 정보 </param>

public record CharacterAndroidEquipment(
    string? AndroidName,
    string? AndroidNickname,
    string? AndroidIcon,
    string? AndroidDescription,
    AndroidHair? AndroidHair,
    AndroidFace? AndroidFace,
    string? AndroidSkinName,
    List<AndroidCashItemEquipment>? AndroidCashItemEquipment,
    string? AndroidEarSensorClipFlag,
    string? AndroidGender,
    string? AndroidGrade,
    string? AndroidNonHumanoidFlag,
    string? AndroidShopUsableFlag,
    long? PresetNo,
    AndroidPreset? AndroidPreset_1,
    AndroidPreset? AndroidPreset_2,
    AndroidPreset? AndroidPreset_3
    )
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
/// 프리셋 안드로이드 정보
/// </summary>
/// <param name="AndroidName"> 안드로이드 명 </param>
/// <param name="AndroidNickname"> 안드로이드 닉네임 </param>
/// <param name="AndroidIcon"> 안드로이드 아이콘 URL </param>
/// <param name="AndroidDescription"> 안드로이드 설명 </param>
/// <param name="AndroidGender"> 안드로이드 성별 </param>
/// <param name="AndroidGrade"> 안드로이드 등급 </param>
/// <param name="AndroidSkinName"> 안드로이드 피부 명 </param>
/// <param name="AndroidHair"> 안드로이드 헤어 정보 </param>
/// <param name="AndroidFace"> 안드로이드 성형 정보 </param>
/// <param name="AndroidEarSensorClipFlag"> 안드로이드 이어센서 클립 적용 여부 </param>
/// <param name="AndroidNonHumanoidFlag"> 비인간형 안드로이드 여부 </param>
/// <param name="AndroidShopUsableFlag"> 잡화상점 이용 가능 여부 </param>
public record AndroidPreset(
    string? AndroidName,
    string? AndroidNickname,
    string? AndroidIcon,
    string? AndroidDescription,
    string? AndroidGender,
    string? AndroidGrade,
    string? AndroidSkinName,
    AndroidHair? AndroidHair,
    AndroidFace? AndroidFace,
    string? AndroidEarSensorClipFlag,
    string? AndroidNonHumanoidFlag,
    string? AndroidShopUsableFlag
    );

/// <summary>
/// 안드로이드 캐시 아이템 장착 정보
/// </summary>
/// <param name="CashItemEquipmentPart">안드로이드 캐시 아이템 부위 명</param>
/// <param name="CashItemEquipmentSlot">안드로이드 캐시 아이템 슬롯 위치</param>
/// <param name="CashItemName">안드로이드 캐시 아이템 명</param>
/// <param name="CashItemIcon">안드로이드 캐시 아이템 아이콘 URL</param>
/// <param name="CashItemDescription">안드로이드 캐시 아이템 설명</param>
/// <param name="CashItemOption">안드로이드 캐시 아이템 옵션 리스트</param>
/// <param name="CashItemLabel">안드로이드 캐시 아이템 라벨 정보 (스페셜라벨, 레드라벨, 블랙라벨, 마스터라벨)</param>
/// <param name="CashItemColoringPrism">안드로이드 캐시 아이템 컬러링프리즘 정보</param>
public record AndroidCashItemEquipment(
    string? CashItemEquipmentPart,
    string? CashItemEquipmentSlot,
    string? CashItemName,
    string? CashItemIcon,
    string? CashItemDescription,
    List<AndroidCashItemOption>? CashItemOption,
    string? CashItemLabel,
    AndroidCashItemColoringPrism? CashItemColoringPrism)
{
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 안드로이드 캐시 아이템 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
    private DateTimeOffset? _dateOptionExpire;
    /// <summary>
    /// 안드로이드 캐시 아이템 옵션 유효 기간 (KST, 시간 단위 데이터로 분은 0으로 고정)
    /// </summary>
    public DateTimeOffset? DateOptionExpire
    {
        get => _dateOptionExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateOptionExpire = value;
    }
}

/// <summary>
/// 안드로이드 성형 정보
/// </summary>
/// <param name="FaceName">안드로이드 성형 명</param>
/// <param name="BaseColor">안드로이드 성형 베이스 컬러</param>
/// <param name="MixColor">안드로이드 성형 믹스 컬러</param>
/// <param name="MixRate">안드로이드 성형 믹스 컬러의 염색 비율</param>
public record AndroidFace(string? FaceName, string? BaseColor, string? MixColor, string? MixRate);

/// <summary>
/// 안드로이드 헤어 정보
/// </summary>
/// <param name="HairName">헤어 명</param>
/// <param name="BaseColor">헤어 베이스 컬러</param>
/// <param name="MixColor">헤어 믹스 컬러</param>
/// <param name="MixRate">헤어 믹스 컬러의 염색 비율</param>
public record AndroidHair(string? HairName, string? BaseColor, string? MixColor, string? MixRate);

/// <summary>
/// 안드로이드 캐시 아이템 컬러링프리즘 정보
/// </summary>
/// <param name="ColorRange">컬러링프리즘 색상 범위</param>
/// <param name="Hue">컬러링프리즘 색조</param>
/// <param name="Saturation">컬러링프리즘 채도</param>
/// <param name="Value">컬러링프리즘 명도</param>
public record AndroidCashItemColoringPrism(string? ColorRange, long? Hue, long? Saturation, long? Value);

/// <summary>
/// 안드로이드 캐시 아이템 옵션
/// </summary>
/// <param name="OptionType">옵션 타입</param>
/// <param name="OptionValue">옵션 값</param>
public record AndroidCashItemOption(string? OptionType, string? OptionValue);