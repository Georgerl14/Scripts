using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuadricula : MonoBehaviour
{
    [SerializeField] private Sprite newSprite;
    [SerializeField] private GestionarMapa gestionarMapa;
    
    private Sprite oldSprite;
    private Boolean ocupado;

    private void Start()
    {
        oldSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    public void setOcupado(Boolean ocupado)
    {
        this.ocupado = ocupado;
    }
    private void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = oldSprite;
    }
    
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (!ocupado)
            {
                gestionarMapa.controlarJugadores( new Vector3(transform.position.x, transform.position.y, -2f));
            }
            else
            {
                print("Casilla ocupada");
            }
        }
    }

    private void OnCollisioEnter2D(Collision2D collider)
    {
        ocupado = true;
    }

    private void OnCollisionExit2D(Collision2D collider)
    {
        ocupado = false;
    }        
}
