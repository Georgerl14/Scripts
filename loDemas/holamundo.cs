using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holamundo : MonoBehaviour
{
    private int numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Al principio");   
    }

    // Update is called once per frame
    void Update()
    {
        numero ++;
        Debug.Log("Frame "+numero);
    }
}
