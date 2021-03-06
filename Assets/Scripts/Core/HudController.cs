using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    [SerializeField] private Image gameOverImage;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button startButton;
    //[SerializeField] public GameManager gameManager;

    [SerializeField] FloatingJoystick floatingJoystick;
    void Update()
    {
        if (GameManager.Instance.isWin)
        {
            
            GetWinImage();
        }

        if(GameManager.Instance.isLose)
        {
            GetLoseImage();
        }
        if(!GameManager.Instance.isWin && !GameManager.Instance.isLose && GameManager.Instance.isGameStarted)
        {
            EnableHud();
        }

    }

    private void EnableHud()
    {
        restartButton.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        gameOverImage.gameObject.SetActive(false);
        floatingJoystick.gameObject.SetActive(true);
    }

    private void GetLoseImage()
    {
        floatingJoystick.gameObject.SetActive(false);
        gameOverImage.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    private void GetWinImage()
    {
        
        floatingJoystick.gameObject.SetActive(false);
        gameOverImage.gameObject.SetActive(true);
        nextLevelButton.gameObject.SetActive(true);
    }
}
