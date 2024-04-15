using System;
using System.Linq;
using System.Net.Http;
using MapleStory.NET;

const string ApiKey = "Your_api_key_here";
using var httpClient = new HttpClient();

var client = new MapleStoryClient(httpClient, ApiKey);
var dateYesterday = DateOnly.FromDateTime(DateTime.Now).AddDays(-1);

var overallRankingResult = await client.RankingApi.GetOverallRankingAsync(dateYesterday); //fetch overall ranking

if (overallRankingResult.Data is null)
{
    Console.WriteLine(overallRankingResult.Error);
    return;
}

var top10 = overallRankingResult.Data.Ranking?.Take(10); //get top 10 characters
var firstPlace = top10?.FirstOrDefault(); //get first place

if (firstPlace?.CharacterName is null)
{
    Console.WriteLine("Unable to get first place.");
    return;
}

var characterResult = await client.CharacterApi.GetAsync(firstPlace.CharacterName); //fetch character identifier(ocid)

if (characterResult.Data is null)
{
    Console.WriteLine(characterResult.Error);
    return;
}

var ocid = characterResult.Data.Ocid;

if (ocid is null)
{
    Console.WriteLine("Unable to get ocid.");
    return;
}

var characterBasicResult = await client.CharacterApi.GetBasicAsync(ocid); //fetch basic data

if (characterBasicResult.Data is null)
{
    Console.WriteLine(characterBasicResult.Error);
    return;
}

var characterBasic = characterBasicResult.Data;
Console.WriteLine(characterBasic.ToJsonString());