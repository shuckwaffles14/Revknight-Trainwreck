using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIhealthcontroller : MonoBehaviour

{
    public float maxhealth = 100;
    public float currenthealth = 0;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RecieveDamage(float amount )
    {
        currenthealth -= amount;
        if(currenthealth <= 0)
        {
            Destroy(this.gameObject);

        }
    }
}
