using UnityEngine;
using UnityEngine.UI;

public class EcologyHealthBar : MonoBehaviour
{ 
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    
    public void SetInitialEcologyHealth(int health)
    {
        slider.maxValue = 100;
        slider.value = 50; 
        fill.color = gradient.Evaluate(1f);
    }
      
      public void SetEcologyHealth(int health)
      {
        fill.color = gradient.Evaluate(slider.normalizedValue);
        slider.value = health;
      }

}