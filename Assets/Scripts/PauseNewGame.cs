using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseNewGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject newGameMenu;
    [SerializeField] AudioSource pauseSound;

    void Update()
    {
        if (Input.GetKey(KeyCode.H) == true) {
            newGameMenu.SetActive(false);
            pauseSound.Play();
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        } else if (Input.anyKey) {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }

        if (Input.GetKey(KeyCode.N) == true) {
            Time.timeScale = 0f;
            newGameMenu.SetActive(true);
        }
    }
}
