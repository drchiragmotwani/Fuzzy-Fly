using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreUpSound;
    public AudioSource gameBgSound;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreCard").GetComponent<TMP_Text>();
        scoreUpSound = GameObject.Find("ScoreCard").GetComponent<AudioSource>();
        gameBgSound = GameObject.Find("Canvas").GetComponent<AudioSource>();
        gameBgSound.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreUpSound.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        gameBgSound.Stop();
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
