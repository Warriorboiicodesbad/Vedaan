using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerData : MonoBehaviour
{
    public TMP_Text Calories;

    public void PressedIEvent(ScriptableObjecte Dataitem)
    {
        Calories.text = Dataitem.calories.ToString();
        Calories.text = Dataitem.calories.ToString();
        Calories.text = Dataitem.calories.ToString();
        Calories.text = Dataitem.calories.ToString();
        Calories.text = Dataitem.calories.ToString();
        Calories.text = Dataitem.calories.ToString();
        Calories.text = Dataitem.calories.ToString();
        Calories.text = Dataitem.calories.ToString();
        Calories.text = Dataitem.calories.ToString();

    }
    public void PressedEEvent(ScriptableObject Dataitem)
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
