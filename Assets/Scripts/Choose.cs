using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Choose : MonoBehaviour
{
    public float num;
    public GameObject fish;
    public GameObject panel;
    public Sprite Fish;
    public Sprite Fish1;
    public Sprite Fish2;
    public Sprite Panel;
    public Sprite Panel1;
    public Sprite Panel2;
    public Text txt;
    void Start()
    {
        num = PlayerPrefs.GetFloat("Num");
    }

    void Update()
    {
        PlayerPrefs.SetFloat("Num", num);
        if (num == 0)
        {
            fish.GetComponent<Image>().sprite = Fish;
            panel.GetComponent<Image>().sprite = Panel;
            txt.text = "MR. REDDY";
        }
        if (num == 1)
        {
            fish.GetComponent<Image>().sprite = Fish1;
            panel.GetComponent<Image>().sprite = Panel1;
            txt.text = "TWINKLE";
        }
        if (num == 2)
        {
            fish.GetComponent<Image>().sprite = Fish2;
            panel.GetComponent<Image>().sprite = Panel2;
            txt.text = "GOLDIE";
        }
    }
    public void OnRight()
    {
        if (num < 2)
        {
            num++;
        }
    }
    public void OnLeft()
    {
        if (num > 0)
        {
            num--;
        }
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
