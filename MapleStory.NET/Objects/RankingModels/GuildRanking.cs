namespace MapleStory.NET.Objects.RankingModels;

/// <summary>
/// 길드 랭킹 정보
/// </summary>
/// <param name="Ranking"> 길드 랭킹 세부정보 리스트 </param>
public record GuildRanking(List<GuildRankingDetails>? Ranking);

/// <summary>
/// 길드 랭킹 세부정보
/// </summary>
/// <param name="Ranking"> 길드 랭킹 순위 </param>
/// <param name="GuildName"> 길드 명 </param>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="GuildLevel"> 길드 레벨 </param>
/// <param name="GuildMasterName"> 길드 마스터 캐릭터 명 </param>
/// <param name="GuildMark"> 길드 마크 </param>
/// <param name="GuildPoint"> 길드 포인트 </param>
public record GuildRankingDetails(
    int? Ranking,
    string? GuildName,
    string? WorldName,
    int? GuildLevel,
    string? GuildMasterName,
    string? GuildMark,
    long? GuildPoint)
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