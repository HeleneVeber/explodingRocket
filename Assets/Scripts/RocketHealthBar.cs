using UnityEngine;
using UnityEngine.UI;

public class RocketHealthBar : MonoBehaviour
{ 
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    
    public void SetInitialRocketHealth(int health)
    {
        slider.minValue = health;
        slider.value = 0;
        fill.color = gradient.Evaluate(1f);
    }
    
    public void SetRocketHealth(int health)
      {
        fill.color = gradient.Evaluate(slider.normalizedValue);
        slider.value = health;
      }

}