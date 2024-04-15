namespace MapleStory.NET.Objects.CharacterModels;

/// <summary>
/// 캐릭터 어빌리티
/// </summary>
/// <param name="AbilityGrade"> 어빌리티 등급 </param>
/// <param name="AbilityInfo"> 어빌리티 정보 리스트 </param>
/// <param name="RemainFame"> 보유 명성치 </param>
/// <param name="PresetNo"> 적용 중인 어빌리티 프리셋 번호(number) </param>
/// <param name="AbilityPreset_1"> 어빌리티 1번 프리셋 전체 정보 </param>
/// <param name="AbilityPreset_2"> 어빌리티 2번 프리셋 전체 정보 </param>
/// <param name="AbilityPreset_3"> 어빌리티 3번 프리셋 전체 정보 </param>
public record CharacterAbility(string? AbilityGrade, List<AbilityInfo>? AbilityInfo, long? RemainFame, long? PresetNo, AbilityPreset? AbilityPreset_1, AbilityPreset? AbilityPreset_2, AbilityPreset? AbilityPreset_3)
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
/// 어빌리티 정보
/// </summary>
/// <param name="AbilityNo"> 어빌리티 번호 </param>
/// <param name="AbilityGrade"> 어빌리티 등급 </param>
/// <param name="AbilityValue"> 어빌리티 옵션 및 수치 </param>
public record AbilityInfo(string? AbilityNo, string? AbilityGrade, string? AbilityValue);

/// <summary>
/// 어빌리티 프리셋 전체 정보
/// </summary>
/// <param name="AbilityPresetGrade"> 어빌리티 프리셋의 어빌리티 등급 </param>
/// <param name="AbilityInfo"> 어빌리티 프리셋 정보 리스트 </param>
public record AbilityPreset(string? AbilityPresetGrade, List<AbilityInfo>? AbilityInfo);