namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 장착 헤어, 성형, 피부 정보
/// </summary>
/// <param name="CharacterGender"> 캐릭터 성별 </param>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="CharacterHair"> 캐릭터 헤어 정보 (제로인 경우 알파, 엔젤릭버스터인 경우 일반 모드) </param>
/// <param name="CharacterFace"> 캐릭터 성형 정보 (제로인 경우 알파, 엔젤릭버스터인 경우 일반 모드) </param>
/// <param name="CharacterSkinName"> 피부 명 (제로인 경우 알파, 엔젤릭버스터인 경우 일반 모드) </param>
/// <param name="AdditionalCharacterHair"> 추가 캐릭터 헤어 정보 (제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드에 적용 중인 헤어 정보) </param>
/// <param name="AdditionalCharacterFace"> 추가 캐릭터 성형 정보 (제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드에 적용 중인 성형 정보) </param>
/// <param name="AdditionalCharacterSkinName"> 추가 피부 명 (제로인 경우 베타, 엔젤릭버스터인 경우 드레스 업 모드에 적용 중인 피부 명) </param>
public record CharacterBeautyEquipment(
    string? CharacterGender,
    string? CharacterClass,
    CharacterHair? CharacterHair,
    CharacterFace? CharacterFace,
    string? CharacterSkinName,
    AdditionalCharacterHair? AdditionalCharacterHair,
    AdditionalCharacterFace? AdditionalCharacterFace,
    string? AdditionalCharacterSkinName)
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
}

/// <summary>
/// 캐릭터 성형 정보
/// </summary>
/// <param name="FaceName"> 성형 명 </param>
/// <param name="BaseColor"> 성형 베이스 컬러 </param>
/// <param name="MixColor"> 성형 믹스 컬러 </param>
/// <param name="MixRate"> 성형 믹스 컬러의 염색 비율 </param>
public record CharacterFace(string? FaceName, string? BaseColor, string? MixColor, string? MixRate);

/// <summary>
/// 캐릭터 헤어 정보
/// </summary>
/// <param name="HairName"> 헤어 명 </param>
/// <param name="BaseColor"> 헤어 베이스 컬러 </param>
/// <param name="MixColor"> 헤어 믹스 컬러 </param>
/// <param name="MixRate"> 헤어 믹스 컬러의 염색 비율 </param>
public record CharacterHair(string? HairName, string? BaseColor, string? MixColor, string? MixRate);

/// <summary>
/// 추가 캐릭터 성형 정보
/// </summary>
/// <param name="FaceName"> 성형 명 </param>
/// <param name="BaseColor"> 성형 베이스 컬러 </param>
/// <param name="MixColor"> 성형 믹스 컬러 </param>
/// <param name="MixRate"> 성형 믹스 컬러의 염색 비율 </param>
public record AdditionalCharacterFace(string? FaceName, string? BaseColor, string? MixColor, string? MixRate);

/// <summary>
/// 추가 캐릭터 헤어 정보
/// </summary>
/// <param name="HairName"> 헤어 명 </param>
/// <param name="BaseColor"> 헤어 베이스 컬러 </param>
/// <param name="MixColor"> 헤어 믹스 컬러 </param>
/// <param name="MixRate"> 헤어 믹스 컬러의 염색 비율 </param>
public record AdditionalCharacterHair(string? HairName, string? BaseColor, string? MixColor, string? MixRate);