using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transladarObjeto : MonoBehaviour
{
    [SerializeField]
    private posicionMouse PosicionMouse;

    public float movimientoX;
    public float movimientoY;

    private bool apretado = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        comprobarBotonApretado();

        if (apretado)
        {
            float posicionCuboX = transform.position.x;
            float posicionCuboY = transform.position.y;

            calcularMovimientoX(posicionCuboX);
            calcularMovimientoY(posicionCuboY);

            if (posicionCuboX != PosicionMouse.posicionDelMouse.x)
            {
                transform.Translate(new Vector3(movimientoX, 0, 0) * Time.deltaTime);
            }

            if (posicionCuboY != PosicionMouse.posicionDelMouse.y)
            {
                transform.Translate(new Vector3(0, movimientoY, 0) * Time.deltaTime);
            }
        }
    }

    private void comprobarBotonApretado()
    {
        if (Input.GetMouseButtonUp(0) && !apretado)
        {
            apretado = true;
        }
        else
        {
            if (Input.GetMouseButtonUp(0) && apretado)
            {
                apretado = false;
            }
        }
    }

    private void calcularMovimientoX(float posicionCuboX)
    {
        if (posicionCuboX > PosicionMouse.posicionDelMouse.x && movimientoX > 0)
        {
            movimientoX *= -1;
        }
        else
        {
            if (posicionCuboX < PosicionMouse.posicionDelMouse.x)
            {
                movimientoX = Mathf.Abs(movimientoX);
            }
        }
    }

    private void calcularMovimientoY(float posicionCuboY)
    {
        if (posicionCuboY > PosicionMouse.posicionDelMouse.y && movimientoY > 0)
        {
            movimientoY *= -1;
        }
        
        else
        {
            if (posicionCuboY < PosicionMouse.posicionDelMouse.y)
            {
                movimientoY = Mathf.Abs(movimientoY);
            }
        }
    }
}
