using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameOnly : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.N) == true) {
            if (GameObject.Find("4. Next Siegfried Ending Music") != null) {
                Destroy(GameObject.Find("4. Next Siegfried Ending Music"));
            }

            SceneManager.LoadScene("Main Menu");
        }
    }
}
