namespace MapleStory.NET.Objects.UnionModels;

/// <summary>
/// 유니온 아티팩트
/// </summary>
/// <param name="UnionArtifactEffect"> 아티팩트 효과 정보 리스트</param>
/// <param name="UnionArtifactCrystal"> 아티팩트 크리스탈 정보 리스트 </param>
/// <param name="UnionArtifactRemainAp"> 잔여 아티팩트 AP </param>
public record UnionArtifact(List<UnionArtifactEffect>? UnionArtifactEffect, List<UnionArtifactCrystal>? UnionArtifactCrystal, long? UnionArtifactRemainAp)
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
/// 아티팩트 효과 정보
/// </summary>
/// <param name="Name"> 아티팩트 효과 명 </param>
/// <param name="Level"> 아티팩트 효과 레벨 </param>
public record UnionArtifactEffect(string? Name, long? Level);

/// <summary>
/// 아티팩트 크리스탈 정보
/// </summary>
/// <param name="Name"> 아티팩트 크리스탈 명 </param>
/// <param name="ValidityFlag"> 능력치 유효 여부 (0: 유효, 1: 유효하지 않음) </param>
/// <param name="Level"> 아티팩트 크리스탈 등급 </param>
/// <param name="CrystalOptionName_1"> 아티팩트 크리스탈 첫 번째 옵션 명 </param>
/// <param name="CrystalOptionName_2"> 아티팩트 크리스탈 두 번째 옵션 명 </param>
/// <param name="CrystalOptionName_3"> 아티팩트 크리스탈 세 번째 옵션 명 </param>
public record UnionArtifactCrystal(
    string? Name,
    string? ValidityFlag,
    long? Level,
    string? CrystalOptionName_1,
    string? CrystalOptionName_2,
    string? CrystalOptionName_3)
{
    private DateTimeOffset? _dateExpire;
    /// <summary>
    /// 능력치 유효 기간 (KST)
    /// </summary>
    public DateTimeOffset? DateExpire
    {
        get => _dateExpire?.ToOffset(TimeSpan.FromHours(9));
        set => _dateExpire = value;
    }
}