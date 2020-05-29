using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLineScript : MonoBehaviour
{
    public GameObject endPanel;

    float numberOfBallsReached = 0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ColouredBalls" || collision.gameObject.tag == "WhiteBalls") {

            numberOfBallsReached++;
                      
                       
        }
    }

    private void Update()
    {
        if (numberOfBallsReached > 3f) {
            Time.timeScale = 0f;
            endPanel.SetActive(true);
        }
    }
}
