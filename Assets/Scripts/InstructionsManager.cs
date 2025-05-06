using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InstructionsManager : MonoBehaviour
{
    public static InstructionsManager Instance;
    public List<TMP_Text> instructions;


    private void Start()
    {
        Instance = this;
    }


    public void AddInstruction(string instruction)
    {
        foreach(var instructionTxt in instructions)
        {
            if (instructionTxt.text == "")
            {
                instructionTxt.text = instruction;
                instructionTxt.gameObject.SetActive(true);
                break;
            }
        }
    }

    public void RemoveInstruction(string instruction)
    {
        foreach(var instructionTxt in instructions)
        {
            if(instructionTxt.text == instruction)
            {
                instructionTxt.text = "";
                instructionTxt.gameObject.SetActive(false);
                break;
            }
        }
    }
}
