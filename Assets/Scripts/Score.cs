using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text txt;
    public float Score_game;

    void Update()
    {
        txt.text = "Score: " + Score_game + "PTS";
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Diamond")
        {
            Score_game++;
            Destroy(col.gameObject);
        }
    }
}
