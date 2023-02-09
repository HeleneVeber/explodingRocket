using UnityEngine;
using UnityEngine.UI;

public class SocialHealthBar : MonoBehaviour
{ 
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetInitialSocialHealth(int health)
    {
        slider.maxValue = 100;
        slider.value = 50; 
        fill.color = gradient.Evaluate(1f);
    }
      
    public void SetSocialHealth(int health)
    {
      fill.color = gradient.Evaluate(slider.normalizedValue);
      slider.value = health;
    }
}

