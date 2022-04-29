using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vision : MonoBehaviour
{
    public bool inRange;
   private void OnTriggerStay(Collider other) 
   {
        if(other.gameObject.CompareTag("Enemy"))
        {
            inRange = true;
        }    

        else
        {
            inRange = false;
        }
   }


}
