using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] private PersonajeCollider controladorCollider;
    [SerializeField] private PersonajeDesplazar desplazar;
    [SerializeField] private PersonajeSeleccion seleccion;
    [SerializeField] private int desplazamiento;

    private bool seleccionado;
    //private bool movible;

    private void Awake()
    {
        seleccionado = false;
        //movible = true;
    }

    public void setSeleccionado(bool seleccionado)
    {
        this.seleccionado = seleccionado;
    }

    public bool getSeleccionado()
    {
        return seleccionado;
    }
    public void setMovilidad(int movilidad)
    {
        this.desplazamiento = movilidad;
    }

    public int getMovilidad()
    {
        return desplazamiento;
    }

    public PersonajeCollider getPersonajeCollider()
    {
        return controladorCollider;
    }
    public PersonajeDesplazar getPersonajeDesplazar()
    {
        return desplazar;
    }
    public PersonajeSeleccion getPersonajeSeleccion()
    {
        return seleccion;
    }
}