using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medicalPack : MonoBehaviour
{
    public float health; //public float for players health
    public GameObject player; //ref to game object
    private playerStat stat; //ref to another script

    // Start is called before the first frame update
    void Start()
    {
        stat = player.gameObject.GetComponent<playerStat>(); //component ref to other script
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            stat.gainHealth(20); //players colission contacts with health vial will increase by 20
            Destroy(this.gameObject); //ref to medpack will be destroyed when collided with 
        }
    }
}
