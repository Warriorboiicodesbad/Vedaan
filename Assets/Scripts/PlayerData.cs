using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Game/Player")]
public class PlayerData : ScriptableObject
{
    public int day = 1, maxDays;
    public ItemData day1, day2, day3;

    public ItemData GetCurrentDayData()
    {
        if(day == 1) return day1;
        else if (day == 2) return day2;
        else if (day == 3) return day3;

        return null;
    }
}
