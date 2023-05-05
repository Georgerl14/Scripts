using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GenerarMapa : MonoBehaviour
{
    [SerializeField] private Cuadricula[] cuadriculas;
    [SerializeField] private string rutaFichero;
    private List<Cuadricula> listaTile = new List<Cuadricula>();
    
    private void Start()
    {
        generateGrid();
    }
    private void generateGrid()
    {
        int[,] arrayMapa = new GenerarArrayMapa(rutaFichero).crearArrayMapa();

        for (int x = 0; x <= arrayMapa.GetUpperBound(0); x++)
        {
            for (int y = 0; y <= arrayMapa.GetUpperBound(1); y++)
            {
                //Vaya por dios, las coordenadas del unity son inversas a las del array.
                Cuadricula cuadriculaNecesario = cuadriculas[int.Parse(arrayMapa.GetValue(x, y).ToString())];
                Cuadricula cuadriculaGenerada = Instantiate(cuadriculaNecesario, new Vector3(transform.position.x + y, transform.position.y + x), Quaternion.identity);
                cuadriculaGenerada.name = $"Tile{x}{y}";

                listaTile.Add(cuadriculaGenerada);
            }
        }

    }

    public List<Cuadricula> getListaTitle()
    {
        return listaTile;
    }
}
