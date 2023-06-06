using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TextGameManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, hpTextMeshPro, staminaTextMeshPro;
    public string storyText;
    public int hpValue, staminaValue;
    public GameObject startScreenPanel, startScreenChoices, level1_Choices, level1_Continue;

    // Start is called before the first frame update
    void Start()
    {
        startScreenPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        hpTextMeshPro.text = hpValue.ToString();
        staminaTextMeshPro.text = staminaValue.ToString();
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void StartButton()
    {
        startScreenPanel.SetActive(false);
    }

    public void l1C1_PerceiveIt()
    {
        storyText = "You open your eyes and see a massive wolf on top of you pressing its paw against your chest, staring down at you snarling and drool dripping down its maw. You close your eyes again.";
        level1_Choices.SetActive(false);
        level1_Continue.SetActive(true);
    }

    public void L1C1_FeelIt()
    {
        storyText = "You feel something rough and heavy like a boulder. The weight press on you harder.";

        if(hpValue == 0)
        {
            storyText = "YOU DIED!!!";
            level1_Choices.SetActive(false);
        } else
        {
            hpValue -= 1;

            if (hpValue == 0)
            {
                storyText = "YOU DIED!!!";
                level1_Choices.SetActive(false);
            }
        }
    }

    public void L1C1_MoveIt()
    {
        storyText = "You tried pushing it off you but you hands just go through air. The weight press on you harder.";
        if (staminaValue == 0)
            storyText = "NO MORE STAMINA!!! \n\nYou tried pushing it off you but you hands just go through air. The weight press on you harder.";
        else
        {
            staminaValue -= 1;
            storyText = "You tried pushing it off you but you hands just go through air. The weight press on you harder.";
        }

        if(hpValue == 0)
        {
            storyText = "YOU DIED!!!";
            level1_Choices.SetActive(false);
        } else
        {
            hpValue -= 1;

            if (hpValue == 0)
            {
                storyText = "YOU DIED!!!";
                level1_Choices.SetActive(false);
            }
        }
    }

    public void L1_Continue()
    {
        storyText = "The nightly howls becons around you as you lay on the ground unconscious.\nYou slowly regain your senses but felt something pressing you against the floor.\n\nNow try combing actions!";
    }
}
