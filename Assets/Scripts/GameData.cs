using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class GameData
{
    public static string addToCartInstruction = "Press E to add to cart";
    public static string toggleCartInstruction = "Press C to toggle cart";
    public static string cartEquipText = "Press E to Equip cart";
    public static string cartAlreadyEquipedText = "Cart already equiped";
    public static string equipCartToAddItem = "Get a Cart to start shopping";
    public static string openItemInfoPanelInstruction = "Press Q to toggle Item Information Panel";
    public static string intakeNotCompletedInstruction = "Intake is incomplete";

    public static bool isCartEquiped = false;
    public static bool isCheckingOut = false;
    public static UnityEvent OnTimerOver = new UnityEvent();

    public static int currentLevel = 1, maxLevel = 3;

    public static void CopyScriptableObjectData<T>(T source, T destination) where T : ScriptableObject
    {
        JsonUtility.FromJsonOverwrite(JsonUtility.ToJson(source), destination);
    }
}
