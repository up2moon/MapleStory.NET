namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 하이퍼 스탯 정보
/// </summary>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="UsePresetNo"> 적용 중인 프리셋 번호 </param>
/// <param name="UseAvailableHyperStat"> 사용 가능한 최대 하이퍼스탯 포인트 </param>
/// <param name="HyperStatPreset_1"> 프리셋 1번 하이퍼 스탯 정보 리스트 </param>
/// <param name="HyperStatPreset_1RemainPoint"> 프리셋 1번 하이퍼 스탯 잔여 포인트 </param>
/// <param name="HyperStatPreset_2"> 프리셋 2번 하이퍼 스탯 정보 리스트 </param>
/// <param name="HyperStatPreset_2RemainPoint"> 프리셋 2번 하이퍼 스탯 잔여 포인트 </param>
/// <param name="HyperStatPreset_3"> 프리셋 3번 하이퍼 스탯 정보 리스트 </param>
/// <param name="HyperStatPreset_3RemainPoint"> 프리셋 3번 하이퍼 스탯 잔여 포인트 </param>
public record CharacterHyperStat(
    string? CharacterClass,
    string? UsePresetNo,
    long? UseAvailableHyperStat,
    List<HyperStatPreset>? HyperStatPreset_1,
    long? HyperStatPreset_1RemainPoint,
    List<HyperStatPreset>? HyperStatPreset_2,
    long? HyperStatPreset_2RemainPoint,
    List<HyperStatPreset>? HyperStatPreset_3,
    long? HyperStatPreset_3RemainPoint)
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
/// 하이퍼 스탯 프리셋 정보
/// </summary>
/// <param name="StatType"> 스탯 종류 </param>
/// <param name="StatPoint"> 스탯 투자 포인트 </param>
/// <param name="StatLevel"> 스탯 레벨 </param>
/// <param name="StatIncrease"> 스탯 상승량 </param>
public record HyperStatPreset(string? StatType, long? StatPoint, long? StatLevel, string? StatIncrease);