# MapleStory.NET

[English](README.md) | 한국어

[![NuGet](https://img.shields.io/nuget/v/MapleStory.NET)](https://www.nuget.org/packages/MapleStory.NET)

MapleStory.NET은 넥슨의 MapleStory Open API 사용을 간소화하기 위한 래퍼 라이브러리로,  
캐릭터 세부 정보, 큐브 사용 결과 및 다양한 랭킹 등의 데이터를 조회하는 기능을 제공합니다.

## 설치

```xml
# 종속성 추가
dotnet add package Microsoft.Extensions.Logging
dotnet add package MapleStory.NET
```

## 사용 방법

### API Key 발급받기

[Nexon Open API 센터](https://openapi.nexon.com/my-application/)에서 애플리케이션을 등록하면 API Key가 발급됩니다.

### 예제 코드

```csharp
using System;
using System.Linq;
using System.Net.Http;
using MapleStory.NET;

const string ApiKey = "Your_api_key_here";
using var httpClient = new HttpClient();

var client = new MapleStoryClient(httpClient, ApiKey);
var dateYesterday = DateOnly.FromDateTime(DateTime.Now).AddDays(-1);

var overallRankingResult = await client.RankingApi.GetOverallRankingAsync(dateYesterday); //종합 랭킹 정보 조회

if (overallRankingResult.Data is null)
{
    Console.WriteLine(overallRankingResult.Error);
    return;
}

var top10 = overallRankingResult.Data.Ranking?.Take(10); //랭킹 10위까지 가져오기
var firstPlace = top10?.FirstOrDefault(); //랭킹 1위 가져오기

if (firstPlace?.CharacterName is null)
{
    Console.WriteLine("랭킹 1위 조회 실패");
    return;
}

var characterResult = await client.CharacterApi.GetAsync(firstPlace.CharacterName); //캐릭터 식별자(ocid) 조회

if (characterResult.Data is null)
{
    Console.WriteLine(characterResult.Error);
    return;
}

var ocid = characterResult.Data.Ocid;

if (ocid is null)
{
    Console.WriteLine("ocid 조회 실패");
    return;
}

var characterBasicResult = await client.CharacterApi.GetBasicAsync(ocid); //기본 정보 조회

if (characterBasicResult.Data is null)
{
    Console.WriteLine(characterBasicResult.Error);
    return;
}

var characterBasic = characterBasicResult.Data;
Console.WriteLine(characterBasic.ToJsonString());
```
