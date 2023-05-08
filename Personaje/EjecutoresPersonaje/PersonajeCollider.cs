using UnityEngine;

public class PersonajeCollider : MonoBehaviour
{
    [SerializeField] private GameObject personaje;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        other.gameObject.GetComponent<Casilla>().setOcupado(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        other.gameObject.GetComponent<Casilla>().setOcupado(false);
    }
}