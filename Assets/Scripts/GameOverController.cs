using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using TMPro;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    public void Start()
    {
        gameOverPanel.SetActive(true);

        if(GameManager.Instance)
        {
            scoreText.text = "Score: " + GameManager.Instance.score.ToString();
        }
    }

    // Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
