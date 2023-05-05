using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class modificarText : MonoBehaviour
{
    public Text texto;
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            contador ++;
            texto.text = contador+"";
        }
        
        if (Input.GetMouseButtonUp(1))
        {
            contador --;
            texto.text = contador+"";
        }

        if (Input.GetMouseButtonUp(2))
        {
            contador = 0;
            texto.text = contador+"";
        }

    }
}
