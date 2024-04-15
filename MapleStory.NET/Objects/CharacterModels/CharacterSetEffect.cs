namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 세트 효과 정보
/// </summary>
/// <param name="SetEffect"> 세트 효과 정보 리스트 </param>
public record CharacterSetEffect(List<SetEffect>? SetEffect)
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
/// 세트 효과 정보
/// </summary>
/// <param name="SetCount"> 세트 효과 레벨 (장비 수) </param>
/// <param name="SetOption"> 적용 중인 세트 효과  </param>
public record SetEffectInfo(long? SetCount, string? SetOption);

/// <summary>
/// 세트 효과 정보
/// </summary>
/// <param name="SetName"> 세트 효과 명 </param>
/// <param name="TotalSetCount"> 세트 효과 개수 (럭키 아이템 포함) </param>
/// <param name="SetEffectInfo"> 세트 효과 정보 리스트 </param>
public record SetEffect(string? SetName, long? TotalSetCount, List<SetEffectInfo>? SetEffectInfo);