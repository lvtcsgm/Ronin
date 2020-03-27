using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject tile;

    // Start is called before the first frame update
    void Start()
    {
        for (int start = 0; start < 10; start += 1)
        {
            Instantiate(tile);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
