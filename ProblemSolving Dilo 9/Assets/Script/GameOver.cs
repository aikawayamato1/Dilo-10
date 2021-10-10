using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private KeyCode restart = KeyCode.R;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(restart))
        {
            SceneManager.LoadScene(0);
        }
    }
}
