using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public void OnPressed()
    {
        Debug.Log("Hello World!");
        // Image image = GetComponent<Image>();
        // image.color = Color.blue;

        // Time.timeScale = 0; //Pause Game
        // Time.timeScale = 1; //Play Game

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
         pauseMenu.SetActive(false);
         Time.timeScale = 1f;
    }
}
