namespace MapleStory.NET.Objects.HistoryModels;

/// <summary>
/// 스타포스 히스토리 세부정보
/// </summary>
/// <param name="Count"> 결과 건수 </param>
/// <param name="NextCursor"> 페이징 처리를 위한 cursor </param>
/// <param name="StarforceHistoryDetails"> 스타포스 히스토리 세부정보 리스트 </param>
public record StarforceHistory(
    int? Count,
    string? NextCursor,
    [property: JsonPropertyName("starforce_history")]
    List<StarforceHistoryDetails>? StarforceHistoryDetails);

/// <summary>
/// 진행 중인 스타포스 강화 이벤트 정보
/// </summary>
/// <param name="SuccessRate"> 이벤트 성공 확률 </param>
/// <param name="CostDiscountRate"> 이벤트 비용 할인율 </param>
/// <param name="PlusValue"> 이벤트 강화 수치 가중값 </param>
/// <param name="StarforceEventRange"> 이벤트 적용 강화 시도 가능한 n성 범위 </param>
public record StarforceEventList(
    string? SuccessRate,
    string? CostDiscountRate,
    string? PlusValue,
    string? StarforceEventRange);

/// <summary>
/// 스타포스 히스토리 세부정보
/// </summary>
/// <param name="Id"> 스타포스 히스토리 식별자 </param>
/// <param name="ItemUpgradeResult"> 강화 시도 결과 </param>
/// <param name="BeforeStarforceCount"> 강화 시도 전 스타포스 수치 </param>
/// <param name="AfterStarforceCount"> 강화 시도 후 스타포스 수치 </param>
/// <param name="StarcatchResult"> 스타 캐치 </param>
/// <param name="SuperiorItemFlag"> 슈페리얼 장비 </param>
/// <param name="DestroyDefence"> 파괴 방지 </param>
/// <param name="ChanceTime"> 찬스 타임 </param>
/// <param name="EventFieldFlag"> 파괴 방지 필드 이벤트 </param>
/// <param name="UpgradeItem"> 사용 주문서 명  </param>
/// <param name="ProtectShield"> 프로텍트 실드 </param>
/// <param name="BonusStatUpgrade"> 보너스 스탯 부여 아이템 여부 </param>
/// <param name="CharacterName"> 캐릭터 명 </param>
/// <param name="WorldName"> 월드 명 </param>
/// <param name="TargetItem"> 대상 장비 아이템 명 </param>
/// <param name="StarforceEventList"> 진행 중인 스타포스 강화 이벤트 정보 리스트 </param>
public record StarforceHistoryDetails(
    string? Id,
    string? ItemUpgradeResult,
    long? BeforeStarforceCount,
    long? AfterStarforceCount,
    string? StarcatchResult,
    string? SuperiorItemFlag,
    string? DestroyDefence,
    string? ChanceTime,
    string? EventFieldFlag,
    string? UpgradeItem,
    string? ProtectShield,
    string? BonusStatUpgrade,
    string? CharacterName,
    string? WorldName,
    string? TargetItem,
    List<StarforceEventList>? StarforceEventList)
{
    private DateTimeOffset? _dateCreate;
    /// <summary>
    /// 강화 일시 (KST)
    /// </summary>
    public DateTimeOffset? DateCreate
    {
        get => _dateCreate?.ToOffset(TimeSpan.FromHours(9));
        set => _dateCreate = value;
    }
}