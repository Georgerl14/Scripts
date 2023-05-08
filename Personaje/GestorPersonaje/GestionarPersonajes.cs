using System.Collections.Generic;
using UnityEngine;

public class GestionarPersonajes : MonoBehaviour
{
    [SerializeField] private List<Personaje> listaPersonajes;

    public Personaje comprobarSeleccionado()
    {
        foreach (Personaje ficha in listaPersonajes)
        {
            if (ficha.getSeleccionado())
            {
                return ficha;
            }
        }

        return null;
    }

    public void controlarJugadores(Vector3 posicionCuadricula)
    {
        Personaje personajeSeleccionado = comprobarSeleccionado();
        if (personajeSeleccionado != null)
        {
            personajeSeleccionado.getPersonajeDesplazar().moverPosicion(posicionCuadricula);
            personajeSeleccionado.getPersonajeSeleccion().deseleccinar();
        }
        else
        {
            print("No hay nadie seleccionado");
        }

    }

    public void gestionarSeleccionFichas(Personaje personajeSeleccionado)
    {
        foreach (Personaje personaje in listaPersonajes)
        {
            if (personaje.Equals(personajeSeleccionado))
            {
                personaje.getPersonajeSeleccion().seleccinar();
            }
            else
            {
                personaje.getPersonajeSeleccion().deseleccinar();
            }
        }

    }
}