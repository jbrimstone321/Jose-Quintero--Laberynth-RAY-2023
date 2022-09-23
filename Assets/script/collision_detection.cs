using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detection : MonoBehaviour
{
    [SerializeField]
    Material world_walls;

    [SerializeField]
    Material tagged;

    bool wTriggered = false;

    float wTriggeredTime = 0.5f;
        
    private void Update()
    {
         if (wTriggered == true)
        {
            wTriggeredTime = wTriggeredTime - Time.deltaTime;
            if (wTriggeredTime < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = world_walls;
                wTriggered = false;
                wTriggeredTime = 0.5f;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = tagged;
            wTriggered = true; 
        }
    }

}
