using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Slider healthSlider;
    public Gradient colourChange;
    public Image colourFill;

    public void setPlayerHealth(float health)
    {
        healthSlider.value = health;
        colourFill.color = colourChange.Evaluate(healthSlider.normalizedValue);
    }

    public void setPlayerMaxHealth(float health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
        
        colourFill.color = colourChange.Evaluate(1f);
    }
}
