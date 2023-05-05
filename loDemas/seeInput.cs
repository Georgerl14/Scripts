using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seeInput : MonoBehaviour
{
    int numberClicks = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            numberClicks++;
            print(numberClicks);
        }
    }
}
