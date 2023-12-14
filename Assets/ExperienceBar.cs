using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] TMPro.TextMeshProUGUI levelText;

    public void UpdateExperienceSlider(float current, float target)
    {
        slider.maxValue = target;
        slider.value = current;
    }

    public void SetLevelText(float level)
    {
        levelText.text = "Level: " + level.ToString();
    }
}
