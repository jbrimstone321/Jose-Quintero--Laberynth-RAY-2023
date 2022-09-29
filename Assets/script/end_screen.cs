using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class end_screen : MonoBehaviour
{
    [SerializeField]
    GameObject endScreen;

    [SerializeField]
    TextMeshProUGUI textScore;

    float gameScore = 0.0f;
    bool isPlaying = true;

    // Player Score (Score = Time to finish the level, the lowest the better).
    private void Update()
    {
        if (isPlaying == true)
        {
            gameScore = gameScore + Time.deltaTime;
        }
    }

    // Completion UI.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hello world");
            endScreen.SetActive(true);
            other.GetComponent<character_movement>().enabled = false;
            isPlaying = false;
            Debug.Log(gameScore);
            textScore.text = gameScore.ToString();

        }
    }
}
