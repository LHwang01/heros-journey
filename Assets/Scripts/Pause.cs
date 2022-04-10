using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKey(KeyCode.H) == true) {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        } else if (Input.anyKey) {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
        }
    }
}
