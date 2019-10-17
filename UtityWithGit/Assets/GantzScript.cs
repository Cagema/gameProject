using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GantzScript : MonoBehaviour
{
    public float delay;
    private float nextChar;

    public GameObject newCharacter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextChar)
        {
            Instantiate(newCharacter, new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f)), Quaternion.identity);
            nextChar = Time.time + delay;
        }
    }
}
