namespace MapleStory.NET.Objects.GuildModels;

/// <summary>
/// 길드 기본 정보
/// </summary>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="GuildName"> 길드 명 </param>
/// <param name="GuildLevel"> 길드 레벨 </param>
/// <param name="GuildFame"> 길드 명성치 </param>
/// <param name="GuildPoint"> 길드 포인트(GP) </param>
/// <param name="GuildMasterName"> 길드 마스터 캐릭터 명 </param>
/// <param name="GuildMemberCount"> 길드원 수 </param>
/// <param name="GuildMember"> 길드원 리스트 </param>
/// <param name="GuildSkill"> 길드 스킬 리스트 </param>
/// <param name="GuildNoblesseSkill"> 길드 노블레스 스킬 리스트 </param>
/// <param name="GuildMark"> 조합형 길드 마크 </param>
/// <param name="GuildMarkCustom"> 커스텀 길드 마크 (BASE64 인코딩) </param>
public record GuildBasic(
    string? WorldName,
    string? GuildName,
    long? GuildLevel,
    long? GuildFame,
    long? GuildPoint,
    string? GuildMasterName,
    long? GuildMemberCount,
    List<string>? GuildMember,
    List<GuildSkill>? GuildSkill,
    List<GuildNoblesseSkill>? GuildNoblesseSkill,
    string? GuildMark,
    string? GuildMarkCustom)
{
    private DateTimeOffset? _date;
    /// <summary>
    /// 조회 기준일 (KST, 일 단위 데이터로 시, 분은 0 고정)
    /// </summary>
    public DateTimeOffset? Date
    {
        get => _date?.ToOffset(TimeSpan.FromHours(9));
        set => _date = value;
    }
}

/// <summary>
/// 길드 스킬
/// </summary>
/// <param name="SkillName"> 스킬 명 </param>
/// <param name="SkillDescription"> 스킬 설명 </param>
/// <param name="SkillLevel"> 스킬 레벨 </param>
/// <param name="SkillEffect"> 스킬 레벨별 효과 </param>
/// <param name="SkillIcon"> 스킬 아이콘 URL </param>
public record GuildSkill(string? SkillName, string? SkillDescription, long? SkillLevel, string? SkillEffect, string? SkillIcon);

/// <summary>
/// 길드 노블레스 스킬
/// </summary>
/// <param name="SkillName"> 스킬 명 </param>
/// <param name="SkillDescription"> 스킬 설명 </param>
/// <param name="SkillLevel"> 스킬 레벨 </param>
/// <param name="SkillEffect"> 스킬 레벨별 효과 </param>
/// <param name="SkillIcon"> 스킬 아이콘 URL </param>
public record GuildNoblesseSkill(string? SkillName, string? SkillDescription, long? SkillLevel, string? SkillEffect, string? SkillIcon);
