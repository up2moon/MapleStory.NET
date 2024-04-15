namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 스킬 정보
/// </summary>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="CharacterSkillGrade"> 스킬 전직 차수 </param>
/// <param name="CharacterSkillDetails"> 스킬 세부정보 리스트 </param>
public record CharacterSkill(
    string? CharacterClass,
    string? CharacterSkillGrade,
    [property: JsonPropertyName("character_skill")]
    List<CharacterSkillDetails>? CharacterSkillDetails)
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
/// 캐릭터 스킬 세부정보
/// </summary>
/// <param name="SkillName"> 스킬 명 </param>
/// <param name="SkillDescription"> 스킬 설명 </param>
/// <param name="SkillLevel"> 스킬 레벨 </param>
/// <param name="SkillEffect"> 스킬 레벨별 효과 설명 </param>
/// <param name="SkillIcon"> 스킬 아이콘 URL </param>
public record CharacterSkillDetails(string? SkillName, string? SkillDescription, long? SkillLevel, string? SkillEffect, string? SkillIcon);