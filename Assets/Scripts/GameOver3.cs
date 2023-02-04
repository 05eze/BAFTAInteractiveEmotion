using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver3");
    }

}
