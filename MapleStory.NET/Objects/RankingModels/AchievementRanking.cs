namespace MapleStory.NET.Objects.RankingModels;

/// <summary>
/// 업적 랭킹 정보
/// </summary>
/// <param name="Ranking"> 업적 랭킹 세부정보 리스트 </param>
public record AchievementRanking(List<AchievementRankingDetails>? Ranking);

/// <summary>
/// 업적 랭킹 세부정보
/// </summary>
/// <param name="Ranking"> 업적 랭킹 순위 </param>
/// <param name="CharacterName"> 캐릭터 명 </param>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="ClassName"> 직업 명 </param>
/// <param name="SubClassName"> 전직 직업 명 </param>
/// <param name="TrophyGrade"> 업적 등급 </param>
/// <param name="TrophyScore"> 업적 점수 </param>
public record AchievementRankingDetails(
    int? Ranking,
    string? CharacterName,
    string? WorldName,
    string? ClassName,
    string? SubClassName,
    string? TrophyGrade,
    int? TrophyScore)
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