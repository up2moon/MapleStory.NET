namespace MapleStory.NET.Objects.UnionModels;

/// <summary>
/// 유니온 공격대
/// </summary>
/// <param name="UnionRaiderStat"> 유니온 공격대원 효과 리스트 </param>
/// <param name="UnionOccupiedStat"> 유니온 공격대 점령 효과 리스트 </param>
/// <param name="UnionInnerStat"> 유니온 공격대 배치 리스트 </param>
/// <param name="UnionBlock"> 유니온 블록 정보 리스트 </param>
/// <param name="UsePresetNo"> 적용 중인 프리셋 번호 </param>
/// <param name="UnionRaiderPreset_1"> 유니온 프리셋 1번 정보 </param>
/// <param name="UnionRaiderPreset_2"> 유니온 프리셋 2번 정보 </param>
/// <param name="UnionRaiderPreset_3"> 유니온 프리셋 3번 정보 </param>
/// <param name="UnionRaiderPreset_4"> 유니온 프리셋 4번 정보 </param>
/// <param name="UnionRaiderPreset_5"> 유니온 프리셋 5번 정보 </param>
public record UnionRaider(
    List<string>? UnionRaiderStat,
    List<string>? UnionOccupiedStat,
    List<UnionInnerStat>? UnionInnerStat,
    List<UnionBlock>? UnionBlock,
    long? UsePresetNo,
    UnionRaiderPreset? UnionRaiderPreset_1,
    UnionRaiderPreset? UnionRaiderPreset_2,
    UnionRaiderPreset? UnionRaiderPreset_3,
    UnionRaiderPreset? UnionRaiderPreset_4,
    UnionRaiderPreset? UnionRaiderPreset_5)
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
/// 블록이 차지하고 있는 영역 좌표들 (null:미 배치 시)
/// </summary>
/// <param name="X"> 블록 X좌표 </param>
/// <param name="Y"> 블록 Y좌표 </param>
public record BlockPosition(long? X, long? Y);

/// <summary>
/// 블록 기준점 좌표.
/// <para>중앙 4칸 중 오른쪽 아래칸이 x: 0, y: 0 포지션</para>
/// <para>좌측으로 1칸씩 이동하면 x가 1씩 감소</para>
/// <para>우측으로 1칸씩 이동하면 x가 1씩 증가</para>
/// <para>아래로 1칸씩 이동하면 y가 1씩 감소</para>
/// <para>위로 1칸씩 이동하면 y가 1씩 증가</para>
/// </summary>
/// <param name="X"> 블록 기준점 X좌표 </param>
/// <param name="Y"> 블록 기준점 Y좌표 </param>
public record BlockControlPoint(long? X, long? Y);

/// <summary>
/// 유니온 블록 정보
/// </summary>
/// <param name="BlockType"> 블록 모양 (전사, 마법사, 궁수, 도적, 해적, 메이플m, 하이브리드) </param>
/// <param name="BlockClass"> 블록 해당 캐릭터 직업 </param>
/// <param name="BlockLevel"> 블록 해당 캐릭터 레벨 </param>
/// <param name="BlockControlPoint"> 블록 기준점 좌표 </param>
/// <param name="BlockPosition"> 블록이 차지하고 있는 영역 좌표들의 리스트(null: 미 배치 시) </param>
public record UnionBlock(string? BlockType, string? BlockClass, string? BlockLevel, BlockControlPoint? BlockControlPoint, List<BlockPosition>? BlockPosition);

/// <summary>
/// 유니온 공격대 배치
/// </summary>
/// <param name="StatFieldId"> 공격대 배치 위치 (11시 방향부터 시계 방향 순서대로 0~7) </param>
/// <param name="StatFieldEffect"> 해당 지역 점령 효과 </param>
public record UnionInnerStat(string? StatFieldId, string? StatFieldEffect);

/// <summary>
/// 유니온 프리셋 정보
/// </summary>
/// <param name="UnionRaiderStat"> 유니온 공격대원 효과 리스트 </param>
/// <param name="UnionOccupiedStat"> 유니온 공격대 점령 효과 리스트 </param>
/// <param name="UnionInnerStat"> 유니온 공격대 배치 리스트 </param>
/// <param name="UnionBlock"> 유니온 블록 정보 리스트 </param>
public record UnionRaiderPreset(List<string>? UnionRaiderStat, List<string>? UnionOccupiedStat, List<UnionInnerStat>? UnionInnerStat, List<UnionBlock>? UnionBlock);