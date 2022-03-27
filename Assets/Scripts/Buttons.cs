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

    public void Begin() {
        SceneManager.LoadScene("Trial of Ordeals");
    }
}
