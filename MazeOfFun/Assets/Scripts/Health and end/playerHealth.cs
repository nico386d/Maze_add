using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int HealthLimit = 100;


    public static playerHealth instance;


    // to do list
    // points give health

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
     
        currentHealth = maxHealth;
        HealthBar.instance.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // update health
        HealthBar.instance.SetHealth(currentHealth);

      /*  if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
            Debug.Log(HealthBar.instance.TargetSlider);
        }*/

        // Death
       if (currentHealth <= 0)
        {
            MazeInfo.mazeInfo = null;
            SceneManager.LoadScene("Game Over");
        }
        

        //makes the max health 100 hp
        if (currentHealth > HealthLimit)
        {
            
            currentHealth = HealthLimit;
        }
        

    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

      //  healthBar.SetHealth(currentHealth);
    }

     void AddHealth(int heal)
   {
       
       currentHealth += heal;
 
   }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            TakeDamage(2);
        }
      
         if (collision.gameObject.tag == "Point")
         {
                AddHealth(10);
                Destroy(collision.gameObject);
         }
        
    }

}
