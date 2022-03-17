using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  
    public int startingHealth;

    
    private int currentHealth;

    
    void Awake()
    {
       
        currentHealth = startingHealth;
    }

 
    public void ChangeHealth(int changeAmount)
    {
        
        currentHealth = currentHealth + changeAmount;

        
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

      
        if (currentHealth == 0)
        {
          Kill();
        }
    }


    public void Kill()
    {
       Destroy(gameObject);
    }


    public int GetHealth()
    {
        return currentHealth;
    }


    public int GetMaxHealth()
    {
        return startingHealth;
    }
}