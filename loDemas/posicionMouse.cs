using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posicionMouse : MonoBehaviour
{
    public Vector3 posicionDelMouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posicionDelMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //print(posicionDelMouse.ToString());
    }
}
