using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Casilla : MonoBehaviour
{
    [SerializeField] private GestionarPersonajes gestionarPersonajes;
    private Animator animator;
    private Boolean ocupado;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void setOcupado(Boolean ocupado)
    {
        this.ocupado = ocupado;
    }
    private void OnMouseEnter()
    {
        animator.SetBool("Seleccionado", true);
    }

    private void OnMouseExit()
    {
        animator.SetBool("Seleccionado", false);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (!ocupado)
            {
                gestionarPersonajes.controlarJugadores(new Vector3(transform.position.x, transform.position.y, -2f));
            }
            else
            {
                print("Casilla ocupada");
            }
        }
    }
}
