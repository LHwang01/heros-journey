using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public void Story1 () {
        SceneManager.LoadScene("Story 1");
    }

    public void Story2 () {
        SceneManager.LoadScene("Story 2");
    }

    public void Story3 () {
        SceneManager.LoadScene("Story 3");
    }

    public void Story4 () {
        SceneManager.LoadScene("Story 4");
    }

    public void GameInfo () {
        SceneManager.LoadScene("Game Info");
    }

    public void GameInfo2 () {
        SceneManager.LoadScene("Game Info 2");
    }

    public void Begin() {
        SceneManager.LoadScene("Trial of Ordeals");
        Destroy(GameObject.Find("Main Menu Music"));
    }

    public void MainMenu() {
        if (GameObject.Find("4. Next Siegfried Ending Music") != null) {
            Destroy(GameObject.Find("4. Next Siegfried Ending Music"));
        }

        SceneManager.LoadScene("Main Menu");
    }

    public void NextSiegfried1() {
        SceneManager.LoadScene("4. Next Siegfried Ending 1");
    }

    public void NextSiegfried2() {
        SceneManager.LoadScene("4. Next Siegfried Ending 2");
    }

    public void NextSiegfried3() {
        SceneManager.LoadScene("4. Next Siegfried Ending Part 3");
    }
}
