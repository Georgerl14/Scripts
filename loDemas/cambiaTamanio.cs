using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiaTamanio : MonoBehaviour
{
    public Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale += scaleChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
