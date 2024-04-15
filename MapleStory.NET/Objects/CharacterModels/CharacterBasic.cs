namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 기본 정보
/// </summary>
/// <param name="CharacterName"> 캐릭터 명 </param>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="CharacterGender"> 캐릭터 성별 </param>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="CharacterClassLevel"> 캐릭터 전직 차수 </param>
/// <param name="CharacterLevel"> 캐릭터 레벨 </param>
/// <param name="CharacterExp"> 현재 레벨에서 보유한 경험치 </param>
/// <param name="CharacterExpRate"> 현재 레벨에서 경험치 퍼센트 </param>
/// <param name="CharacterGuildName"> 캐릭터 소속 길드 명 </param>
/// <param name="CharacterImage"> 캐릭터 외형 이미지 URL </param>
public record CharacterBasic(
    string? CharacterName,
    string? WorldName,
    string? CharacterGender,
    string? CharacterClass,
    string? CharacterClassLevel,
    long? CharacterLevel,
    long? CharacterExp,
    string? CharacterExpRate,
    string? CharacterGuildName,
    string? CharacterImage)
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
