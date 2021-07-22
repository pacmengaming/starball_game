using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayScript : MonoBehaviour
{
    public void PlayGame1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void PlayGame2()
    {
        SceneManager.LoadScene("Level2");
    }
}
