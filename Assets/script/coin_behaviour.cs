using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_behaviour : MonoBehaviour
{
    int coinScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            collision.gameObject.SetActive(false);
            coinScore = coinScore + 1;
            Debug.Log(coinScore);
        }
            
    }
}



    





