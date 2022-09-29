using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class character_movement : MonoBehaviour
{
    int coinScore = 0;
    public float pMovementX;
    public float pMovementY;
    public float pMovementZ;
    public float pMovementSpeed = 10f;

    [SerializeField]
    TextMeshProUGUI textCoinScore;

    // Character Controls.
    void Start()
    {
        
    }

    void Update()
    {
        pMovementX = - Input.GetAxis("Horizontal") * Time.deltaTime * pMovementSpeed;
        pMovementZ = - Input.GetAxis("Vertical") * Time.deltaTime * pMovementSpeed;

        transform.Translate(pMovementX, pMovementY, pMovementZ); 
    }

    // Coin detection and Score
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            collision.gameObject.SetActive(false);
            coinScore = coinScore + 1;
            Debug.Log(coinScore);
            
            //coin score on the completion screen.
            textCoinScore.text = coinScore.ToString();
        }

    }
}