using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doma_spawn : MonoBehaviour
{
    public GameObject Doma;

    void Start()
    {
        StartCoroutine(DomaSpawn());
    }

    IEnumerator DomaSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(2f, -0.5f);
            GameObject newDoma = Instantiate(Doma, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newDoma, 10);
        }
    }
}
