using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject player;
    public float force;
    public GameObject But_death;
    Rigidbody2D rb;
    public Sprite fish1;
    public Sprite fish2;
    public Sprite fish3;
    public GameObject trig;
    public float health;
    public Image fill;
    public bool IsStun;
    void Start()
    {
        IsStun = false;
        rb = GetComponent<Rigidbody2D>();
        if (PlayerPrefs.GetFloat("Num") == 0)
        {
            health = 7f;
        }
        if (PlayerPrefs.GetFloat("Num") == 1)
        {
            health = 3f;
        }
        if (PlayerPrefs.GetFloat("Num") == 2)
        {
            health = 5f;
        }
    }

   
    void Update()
    {
        if (IsStun)
        {
            GetComponent<CapsuleCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<CapsuleCollider2D>().enabled =true;
        }
        if (PlayerPrefs.GetFloat("Num") == 0)
        {
            fill.fillAmount = health / 7;
            GetComponent<SpriteRenderer>().sprite = fish1;
        }
        if (PlayerPrefs.GetFloat("Num") == 1)
        {
            fill.fillAmount = health / 3;
            GetComponent<SpriteRenderer>().sprite = fish2;
        }
        if (PlayerPrefs.GetFloat("Num") == 2)
        {
            fill.fillAmount = health / 5;
            GetComponent<SpriteRenderer>().sprite = fish3;
        }
        if (health <= 0f)
        {
            ScoreScene.score1 = trig.GetComponent<Score>().Score_game;
            if (trig.GetComponent<Score>().Score_game > ScoreScene.score2)
            {
                ScoreScene.score2 = trig.GetComponent<Score>().Score_game;
            }
            SceneManager.LoadScene("Menu");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            health--;
            IsStun = true;
            StartCoroutine(Cooldown(2f));
        }

    }
    public void OnClick()
    {
        rb.velocity = Vector2.up * force;
    }
    public IEnumerator Cooldown(float sec)
    {
        yield return new WaitForSeconds(sec);
        IsStun = false;
    }
}
