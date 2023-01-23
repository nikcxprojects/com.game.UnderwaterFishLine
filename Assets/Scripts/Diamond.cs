using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public Sprite[] diam1;
    private int num;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = diam1[Random.Range(0, diam1.Length)];

    }

}
