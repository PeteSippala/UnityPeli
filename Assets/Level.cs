using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    float level = 1.0f;
    float experience = 0.0f;
    [SerializeField] ExperienceBar experienceBar;

    float TO_LEVEL_UP
    {
        get
        {
            return level * 1000.0f;
        }
    }

    private void Start()
    {
        experienceBar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
        experienceBar.SetLevelText(level);
    }

    public void AddExperience(float amount)
    {
        experience += amount;
        CheckLevelUp();
        experienceBar.UpdateExperienceSlider(experience, TO_LEVEL_UP);
    }
        
    public void CheckLevelUp()
    {
        if(experience >= TO_LEVEL_UP)
        {
            experience -= TO_LEVEL_UP;
            level += 1.0f;
            experienceBar.SetLevelText(level);
        }
    }
}
