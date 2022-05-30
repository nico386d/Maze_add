using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int HealthLimit = 100;
    public HealthBar healthBar;
    

    // to do list
    // points give health

    // Start is called before the first frame update
    void Start()
    {
     
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // update health
        healthBar.SetHealth(currentHealth);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
            Debug.Log(healthBar.TargetSlider);
        }
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
       // targetslider dosent go up so the slider in the ui wont move 
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
