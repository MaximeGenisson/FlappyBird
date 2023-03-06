using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void addScore(int scoreToAdd){
        score = score + scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

    public void changeScene(){
        SceneManager.LoadScene("SampleScene");
    }
}
