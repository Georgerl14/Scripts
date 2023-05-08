using UnityEngine;

public class PersonajeSeleccion : MonoBehaviour
{
    [SerializeField] private GameObject objetoPersonaje;
    private Personaje personaje;
    private SpriteRenderer spriteRenderer;
    private void Start() {
        personaje = objetoPersonaje.GetComponent<Personaje>();
        spriteRenderer = objetoPersonaje.GetComponent<SpriteRenderer>();
    }

    public void seleccinar()
    {
        personaje.setSeleccionado(true);

        //controlarPosicion.comprobarCasillas(gameObject, desplazamiento);
    }

    public void deseleccinar()
    {
        personaje.setSeleccionado(false);

        //controlarPosicion.modificarColorTerreno(Color.white);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (!personaje.getSeleccionado())
            {
                //controlarPosicion.gestionarSeleccionFichas(this);
            }
            else
            {
                deseleccinar();
            }
        }
    }
}