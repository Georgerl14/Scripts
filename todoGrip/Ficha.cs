using UnityEngine;

public class Ficha : MonoBehaviour
{
    [SerializeField] private GestionarMapa controlarPosicion;
    [SerializeField] private int desplazamiento;

    private bool seleccionada;
    private bool movible;

    private SpriteRenderer spriteRenderer;
    private Color oldColor;
    

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        oldColor = spriteRenderer.color;
        seleccionada = false;
        movible = true;
    }

    public void setSeleccionado(bool seleccionado)
    {
        this.seleccionada = seleccionado;
    }

    public bool getSeleccionado()
    {
        return seleccionada;
    }

    public void setMovilidad(int movilidad)
    {
        this.desplazamiento = movilidad;
    }

    public int getMovilidad()
    {
        return desplazamiento;
    }

    public void moverPosicion(Vector3 posicionCasilla)
    {
        if (seleccionada)
        {
            transform.position = posicionCasilla;
        }
    }

    public void seleccinar()
    {
        spriteRenderer.color = Color.white;
        seleccionada = true;

        controlarPosicion.comprobarCasillas(gameObject,desplazamiento);
    }

    public void deseleccinar()
    {
        spriteRenderer.color = oldColor;
        seleccionada = false;

        //controlarPosicion.modificarColorTerreno(Color.white);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (!seleccionada)
            {
                controlarPosicion.gestionarSeleccionFichas(this);
            }
            else
            {
                deseleccinar();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        other.gameObject.GetComponent<Cuadricula>().setOcupado(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        other.gameObject.GetComponent<Cuadricula>().setOcupado(false);
    }
}