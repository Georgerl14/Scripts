using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GenerarTablero : MonoBehaviour
{
    [SerializeField] private Casilla[] casillas;
    [SerializeField] private string rutaFichero;
    [SerializeField] private int alto;
    [SerializeField] private int ancho;
    

    private List<Casilla> listaCasillas = new List<Casilla>();
    
    private void Awake()
    {
        generarCasillas();
    }
    private void generarCasillas()
    {
        int[,] arrayTablero = new GenerarArrayTablero().crearArrayTablero(rutaFichero, alto, ancho);

        for (int x = 0; x <= arrayTablero.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= arrayTablero.GetUpperBound(1); y++)
            {
                //Vaya por dios, las coordenadas del unity son inversas a las del array.
                Casilla casillaNecesaria = casillas[int.Parse(arrayTablero.GetValue(x, y).ToString())];
                Casilla casillaGenerada = Instantiate(casillaNecesaria, new Vector3(transform.position.x + y, transform.position.y + x), Quaternion.identity);
                casillaGenerada.name = $"Casilla{x}{y}";

                listaCasillas.Add(casillaGenerada);
            }
        }

    }

    public List<Casilla> getListaCasillas()
    {
        return listaCasillas;
    }
}
