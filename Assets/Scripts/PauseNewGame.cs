using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        } else if (Input.GetKey(KeyCode.N) == false && Input.anyKey) {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }

        if (Input.GetKey(KeyCode.N) == true) {
            pauseMenu.SetActive(false);
            Time.timeScale = 0f;
            newGameMenu.SetActive(true);
        } else if (Input.GetKey(KeyCode.H) == false && Input.anyKey) {
            if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1)) {
                return;
            }

            Time.timeScale = 1;
            newGameMenu.SetActive(false);
        }
    }
    
    public void noNewGame() 
    {
        Time.timeScale = 1f;
        newGameMenu.SetActive(false);
    }

    public void newGame() {
        SceneManager.LoadScene("Trial of Ordeals");
    }
}
