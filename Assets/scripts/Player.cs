using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
	}


	void TakeDamage(int damage)
	{
		currentHealth -= damage;
	}
}