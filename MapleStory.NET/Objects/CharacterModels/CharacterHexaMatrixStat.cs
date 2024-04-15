namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 HEXA 스탯 정보
/// </summary>
/// <param name="CharacterClass"> 캐릭터 직업 </param>
/// <param name="CharacterHexaStatCore"> HEXA 스탯 코어 정보 리스트 </param>
/// <param name="PresetHexaStatCore"> 프리셋 HEXA 스탯 코어 정보 리스트 </param>
public record CharacterHexaMatrixStat(
    string? CharacterClass,
    List<CharacterHexaStatCore>? CharacterHexaStatCore,
    List<CharacterHexaStatCore>? PresetHexaStatCore)
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
/// 캐릭터 HEXA 스탯 코어 정보
/// </summary>
/// <param name="SlotId"> 슬롯 인덱스 </param>
/// <param name="MainStatName"> 메인 스탯 명 </param>
/// <param name="SubStatName_1"> 첫 번째 서브 명 </param>
/// <param name="SubStatName_2"> 두 번째 서브 명 </param>
/// <param name="MainStatLevel"> 메인 스탯 레벨 </param>
/// <param name="SubStatLevel_1"> 첫 번째 서브 레벨 </param>
/// <param name="SubStatLevel_2"> 두 번째 서브 레벨 </param>
/// <param name="StatGrade"> 스탯 코어 등급 </param>
public record CharacterHexaStatCore(string? SlotId, string? MainStatName, string? SubStatName_1, string? SubStatName_2, long? MainStatLevel, long? SubStatLevel_1, long? SubStatLevel_2, long? StatGrade);