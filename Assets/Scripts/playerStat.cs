using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStat : MonoBehaviour
{
    public float health; //health float
    public float maxHealth; //public float declared for the players max health
    public Slider sldHealth; //slider bar reference
    public GameObject player; //reference to player on unity

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth; //player has max health on spawn
        sldHealth.value = maxHealth; //slider = maxhealth basically
    }

    public void dealDamage(float damage)
    {
        health -= damage; //health is decreased when damage is taken 
        death(); //player dead when it reach 0
    }

    void death()
    {
        sldHealth.value = calculateHealthPercentage(); //health slider value is calculated
        if(health <= 0) //if loop on IF health is = or greater then 0
        {
            Destroy(player); //player object is destroyed
        }
    }

    float calculateHealthPercentage()
    {
        return (health / maxHealth) * 100; //player health is multiplied by 100 to find percentage
    }

    public void gainHealth(float increaseHealth)
    {
        health += increaseHealth; //the health is increased to player health when medpack is picked up
        death(); //i tihnk this speaks for itself
    }
}
