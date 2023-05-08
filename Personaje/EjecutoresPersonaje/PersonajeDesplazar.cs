using UnityEngine;

public class PersonajeDesplazar : MonoBehaviour
{
    [SerializeField] private GameObject objetoPersonaje;
    private Personaje personaje;
    private void Start() {
        personaje = objetoPersonaje.GetComponent<Personaje>();
    }

    public void moverPosicion(Vector3 posicionCasilla)
    {
        if (personaje.getSeleccionado())
        {
            transform.position = posicionCasilla;
        }
    }
}