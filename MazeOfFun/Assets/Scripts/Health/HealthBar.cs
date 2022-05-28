using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public int transtionSpeed;
    public float colorTranstionSpeed;
    public int TargetSlider;


    public Slider slider;
    public Image fill;
    public playerHealth playerHealth;


    public void Start()
    {
     
    }
    public void Update()
    {
   
  
      slider.value = (Mathf.MoveTowards(slider.value, TargetSlider, transtionSpeed * Time.deltaTime));
        if (TargetSlider >= 91)
        {
            fill.color = new Color(Mathf.MoveTowards(fill.color.r, 0f, colorTranstionSpeed * Time.deltaTime), Mathf.MoveTowards(fill.color.g, 1f, colorTranstionSpeed * Time.deltaTime), fill.color.b, fill.color.a);
        }
        if(TargetSlider <= 70 && TargetSlider >= 31)
        {
            fill.color = new Color(Mathf.MoveTowards(fill.color.r, 1f, colorTranstionSpeed * Time.deltaTime), Mathf.MoveTowards(fill.color.g, 1f, colorTranstionSpeed * Time.deltaTime), fill.color.b, fill.color.a);
        }
        /* if (TargetSlider <= 90)
         {
             fill.color = new Color(Mathf.MoveTowards(fill.color.r, 1f, colorTranstionSpeed * Time.deltaTime),fill.color.g, fill.color.b, fill.color.a);
         }*/
        if (TargetSlider <= 30)
        {
            fill.color = new Color(Mathf.MoveTowards(fill.color.r, 1f, colorTranstionSpeed * Time.deltaTime), Mathf.MoveTowards(fill.color.g, 0f, colorTranstionSpeed * Time.deltaTime), fill.color.b, fill.color.a);
        }

        /* if (TargetSlider <= 20)
        {
            fill.color = new Color(fill.color.r, Mathf.MoveTowards(fill.color.g, 0f, colorTranstionSpeed * Time.deltaTime), fill.color.b, fill.color.a);
        }*/



    }
public void SetMaxHealth(int health)
{
slider.maxValue = health;
slider.value = health;
TargetSlider = health;
}

public void SetHealth(int health)
{
 TargetSlider = health;
//slider.value = health;
}
}
