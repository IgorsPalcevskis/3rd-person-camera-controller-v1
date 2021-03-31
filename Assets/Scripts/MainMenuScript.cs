using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlatTheGame()
    {
        SceneManager.LoadScene("3rd person camera controller v1");
    }

    public void QuitTheGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit();
    }
}
