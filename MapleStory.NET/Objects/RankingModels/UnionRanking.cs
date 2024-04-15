namespace MapleStory.NET.Objects.RankingModels;

/// <summary>
/// 유니온 랭킹
/// </summary>
/// <param name="Ranking"> 유니온 랭킹 세부정보 리스트 </param>
public record UnionRanking(List<UnionRankingDetails>? Ranking);

/// <summary>
/// 유니온 랭킹 세부정보
/// </summary>
/// <param name="Ranking"> 유니온 랭킹 순위 </param>
/// <param name="CharacterName"> 캐릭터 명 </param>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="ClassName"> 직업 명 </param>
/// <param name="SubClassName"> 전직 직업 명 </param>
/// <param name="UnionLevel"> 유니온 레벨 </param>
/// <param name="UnionPower"> 유니온 파워 </param>
public record UnionRankingDetails(
    int? Ranking,
    string? CharacterName,
    string? WorldName,
    string? ClassName,
    string? SubClassName,
    int? UnionLevel,
    long? UnionPower)
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