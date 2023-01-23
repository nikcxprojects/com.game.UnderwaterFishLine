using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScene : MonoBehaviour
{
    public Text txt1;
    public Text txt2;
    public static float score1;
    public static float score2;
    void Start()
    {
        txt1.text = "Your last Score is: " + score1;
        txt2.text = "Your Best Score is: " + score2;
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
