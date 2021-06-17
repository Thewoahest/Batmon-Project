using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
           Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void addPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        Debug.Log("Score: " + score);
    }
}
