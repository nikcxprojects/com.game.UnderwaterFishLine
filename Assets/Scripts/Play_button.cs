using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_button : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("game");
    }
    public void Score()
    {
        SceneManager.LoadScene("Score");
    }
    public void Selected()
    {
        SceneManager.LoadScene("Choose");
    }
}
