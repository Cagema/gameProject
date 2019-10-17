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
        if (Time.deltaTime > nextChar)
        {
            Instantiate(newCharacter, new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3)), Quaternion.identity);
            nextChar = Time.deltaTime + delay;
        }
    }
}
