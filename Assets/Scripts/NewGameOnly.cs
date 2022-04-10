using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameOnly : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.N) == true) {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
