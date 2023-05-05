using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverObjeto : MonoBehaviour
{
    [SerializeField]
    private posicionMouse PosicionMouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            transform.position = (new Vector3(PosicionMouse.posicionDelMouse.x, PosicionMouse.posicionDelMouse.y, transform.position.z));
        }
    }
}
