using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoSaludAleatoria : MonoBehaviour
{
    public SaludAleatoria saludAleatoria;
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "Salud: " + saludAleatoria.getSalud();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "Salud: " + saludAleatoria.getSalud();

        if (Input.GetMouseButtonUp(0))
        {
            saludAleatoria.reducirSalud();
        }

        if (saludAleatoria.getSalud() <= 0)
        {
            texto.text = "Has ganado";
        }
    }
}
