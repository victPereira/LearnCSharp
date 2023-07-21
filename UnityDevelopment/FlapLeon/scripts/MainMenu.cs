using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public PlayerController player;
    public GameObject menu;
    public GameObject hud;
    public GameObject credits;
    public GameObject gameEnvironemnt;




    [Space]
    public Button startButton;
    public Button creditsButton;
    public Button quitGameButton;
    public Button quitCreditsButton;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        player.gameObject.SetActive(false);
        hud.gameObject.SetActive(false);
        gameEnvironemnt.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);


        quitGameButton.onClick.AddListener(Quit);

        creditsButton.onClick.AddListener(Credits);
        quitCreditsButton.onClick.AddListener(QuitCredits);
    }


    void StartGame()
    {

        player.gameObject.SetActive(true);
        menu.gameObject.SetActive(false);


        hud.gameObject.SetActive(true);
        gameEnvironemnt.gameObject.SetActive(true);



    }

    void Quit()
    {
        Application.Quit();
    }

    void Credits()
    {
        credits.gameObject.SetActive(true);
        menu.gameObject.SetActive(false);
    }

    void QuitCredits()
    {
        credits.gameObject.SetActive(false);
        menu.gameObject.SetActive(true);
    }
}