using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPScore : MonoBehaviour
{
    public Text hpscore;
    public static HPScore instance;
    public playerHealth playerHealth;
    public int thehpscore ;
    // Start is called before the first frame update


    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        thehpscore = playerHealth.currentHealth;
        hpscore.text = thehpscore.ToString() + " HP";
    }
    public void Update()
    {
        thehpscore = playerHealth.currentHealth;
        hpscore.text = thehpscore.ToString() + " HP";
    }
   

    public void AddPoint()
    {
        // targetslider dosent go up so the slider in the ui wont move 
        playerHealth.currentHealth += 10;
        hpscore.text = thehpscore.ToString() + " HP";
    }
}
