namespace MapleStory.NET.Objects.RankingModels;

/// <summary>
/// 종합 랭킹 정보
/// </summary>
/// <param name="Ranking"> 종합 랭킹 세부정보 리스트 </param>
public record OverallRanking(List<OverallRankingDetails>? Ranking);

/// <summary>
/// 종합 랭킹 세부정보
/// </summary>
/// <param name="Ranking"> 종합 랭킹 순위 </param>
/// <param name="CharacterName"> 캐릭터 명 </param>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="ClassName"> 직업 명 </param>
/// <param name="SubClassName"> 전직 직업 명 </param>
/// <param name="CharacterLevel"> 캐릭터 레벨 </param>
/// <param name="CharacterExp"> 캐릭터 경험치 </param>
/// <param name="CharacterPopularity"> 캐릭터 인기도 </param>
/// <param name="CharacterGuildname"> 길드 명 </param>
public record OverallRankingDetails(
    int? Ranking,
    string? CharacterName,
    string? WorldName,
    string? ClassName,
    string? SubClassName,
    int? CharacterLevel,
    long? CharacterExp,
    int? CharacterPopularity,
    string? CharacterGuildname)
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
