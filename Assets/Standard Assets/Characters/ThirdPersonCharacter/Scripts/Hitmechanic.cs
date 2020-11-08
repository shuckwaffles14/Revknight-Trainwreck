using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitmechanic : MonoBehaviour
{
    public GameObject hitcolider;
    public bool isattacking;
    public GameObject aitarget;
    public float meledamageamount = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //    hitcolider.SetActive(true);
            isattacking = true;
            if (aitarget != null)
            {
                aitarget.GetComponent<AIhealthcontroller>().RecieveDamage(meledamageamount);
                
            }    
        }
        else if (Input.GetMouseButtonUp (0))
        {
            //    hitcolider.SetActive(false);
            isattacking = false;

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print(other.transform.name);
        if(other.transform.tag=="enemy")
        {
            aitarget = other.transform.gameObject;
        }
       


        if (isattacking == true)
        {
           

        }
          
    }
    private void OnTriggerExit(Collider other)
    {
        if (aitarget != null)
        {
            if (aitarget.transform.gameObject == other.gameObject)
            {
                aitarget = null;

            }
        }
       



        
    }
                


}
