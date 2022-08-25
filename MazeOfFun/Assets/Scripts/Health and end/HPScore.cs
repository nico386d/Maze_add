using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPScore : MonoBehaviour
{
    public Text hpscore;
    public int thehpscore ;
    // Start is called before the first frame update



    void Start()
    {
        // Set the hp in the begining 
        thehpscore = playerHealth.instance.currentHealth;
        hpscore.text = thehpscore.ToString() + " HP";
    }
    public void Update()
    {
        // keeps the hp updated
        thehpscore = playerHealth.instance.currentHealth;
        hpscore.text = thehpscore.ToString() + " HP";
    }
   


}
