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

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(5);
         
        }
       if (currentHealth <= 0)
        {
            MazeInfo.mazeInfo = null;
            SceneManager.LoadScene("Game Over");
        }
        healthBar.SetHealth(currentHealth);

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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            TakeDamage(2);
        }
      
         if (collision.gameObject.tag == "Point")
           {
                HPScore.instance.AddPoint();
                Destroy(collision.gameObject);
           }
        
    }

}
