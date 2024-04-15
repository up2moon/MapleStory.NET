namespace MapleStory.NET.Objects.UnionModels;

/// <summary>
/// 유니온
/// </summary>
/// <param name="UnionLevel"> 유니온 레벨 </param>
/// <param name="UnionGrade"> 유니온 등급 </param>
/// <param name="UnionArtifactLevel"> 아티팩트 레벨 </param>
/// <param name="UnionArtifactExp"> 보유 아티팩트 경험치 </param>
/// <param name="UnionArtifactPoint"> 보유 아티팩트 포인트 </param>
public record Union(long? UnionLevel, string? UnionGrade, long? UnionArtifactLevel, long? UnionArtifactExp, long? UnionArtifactPoint)
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