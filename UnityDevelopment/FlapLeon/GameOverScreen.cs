using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public PlayerController Player;
    public Transform RestartPoint;

    public Text ScoreText;
    public Button RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        HideGameOverScreen();

        Player.OnGameOver.AddListener(ShowGameOverScreen);
        RestartButton.onClick.AddListener(RestartLevel);
    }

    
    void ShowGameOverScreen()
    {
        ScoreText.text = $"SCORE : {Player.Score}";
        gameObject.SetActive(true);
    }

    void HideGameOverScreen()
    {
        gameObject.SetActive(false);
    }

    private void RestartLevel()
    {
        var _obstacles = FindObjectsOfType<Obstacle>();

        foreach (var obstacle in _obstacles)
        {
            Destroy(obstacle.gameObject);
        }

        Player.transform.position = RestartPoint.position;
        Player.enabled = true;
        Player.Score = 0;

        HideGameOverScreen();
    }
}
