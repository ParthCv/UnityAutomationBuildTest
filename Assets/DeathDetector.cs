using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDetector : MonoBehaviour
{
    public float deathTime = 0f;
    //Destroy player object after 2 seconds of being inside the object
    public void OnTriggerEnter() {
        deathTime = 0;
    }

    public void OnTriggerStay(Collider other)
    {   
        deathTime += Time.deltaTime;
        if (other.gameObject.tag == "Player" && deathTime > 2f)
            Destroy(other.gameObject);
            
    }
}
