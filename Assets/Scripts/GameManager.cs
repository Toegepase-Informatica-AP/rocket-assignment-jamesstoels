using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text pointsText;
    public RocketMove rocket;
    public GameObject mainCanvas;
    public GameObject GameOverCanvas;
    void Start()
    {
        rocket = FindObjectOfType<RocketMove>();

    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = ("Coins: "+rocket.points );
        if (rocket.finished)
        {
            mainCanvas.SetActive(false);
            GameOverCanvas.SetActive(true);
        }
    }
}
