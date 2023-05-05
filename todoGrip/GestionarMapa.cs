using System.Collections.Generic;
using UnityEngine;

public class GestionarMapa : MonoBehaviour
{
    [SerializeField] private List<Ficha> listaFichas;
    [SerializeField] private GenerarMapa mapa;


    public Ficha comprobarSeleccionado()
    {
        foreach (Ficha ficha in listaFichas)
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
        Ficha fichaSeleccionada = comprobarSeleccionado();
        if (fichaSeleccionada != null)
        {
            fichaSeleccionada.moverPosicion(posicionCuadricula);
            fichaSeleccionada.deseleccinar();
        }
        else
        {
            print("No hay nadie seleccionado");
        }

    }

    public void modificarColorTerreno(Color colorNuevo)
    {
        foreach (var cuadricula in mapa.getListaTitle())
        {
            cuadricula.GetComponent<SpriteRenderer>().color = colorNuevo;
        }
    }

    public void gestionarSeleccionFichas(Ficha fichaSeleccionada)
    {
        foreach (Ficha ficha in listaFichas)
        {
            if (ficha.Equals(fichaSeleccionada))
            {
                ficha.seleccinar();
            }
            else
            {
                ficha.deseleccinar();
            }
        }

    }

    public void comprobarCasillas(GameObject gameObject, int movilidad)
    {
        Vector3 posicionHorizontal = new Vector3(gameObject.transform.position.x - movilidad, gameObject.transform.position.y, gameObject.transform.position.z);
        RaycastHit2D[] rayCastHitHorizontal = Physics2D.RaycastAll(posicionHorizontal, Vector2.right, movilidad * 2);

        Vector3 posicionVertical = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - movilidad, gameObject.transform.position.z);
        RaycastHit2D[] rayCastHitVertical = Physics2D.RaycastAll(posicionVertical, Vector2.up, movilidad * 2);

        /*
            Vector2 direccionDiagonal = new Vector2(1, 1);
            Vector3 posicionDiagonal = new Vector3(transform.position.x - movilidad, transform.position.y - movilidad, transform.position.z); 
            RaycastHit2D [] rayCastHitDiagonal  = Physics2D.RaycastAll(transform.position, direccionDiagonal, movilidad);
        */

        Color rayColor = Color.green;
        Debug.DrawRay(posicionHorizontal, Vector2.right * movilidad * 2, rayColor, 5);
        Debug.DrawRay(posicionVertical, Vector2.up * movilidad * 2, rayColor, 5);

        foreach (RaycastHit2D hit in rayCastHitHorizontal)
        {
            if (hit.collider.gameObject.tag.Equals("Cuadricula"))
            {
                hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }

        foreach (RaycastHit2D hit in rayCastHitVertical)
        {
            if (hit.collider.gameObject.tag.Equals("Cuadricula"))
            {
                hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }

        /*
        foreach (RaycastHit2D hit in rayCastHitDiagonal)
        {
            hit.collider.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }
        */
    }
}