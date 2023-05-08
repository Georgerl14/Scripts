using System.IO;
public class GenerarArrayTablero
{
    public int[,] crearArrayTablero(string rutaFichero, int alto, int ancho)
    {
        int[,] arrayTablero = new int[alto, ancho];
        arrayTablero = rellenarConFichero(arrayTablero, rutaFichero);
        return arrayTablero;
    }

    private int[,] rellenarConFichero(int[,] arrayTablero, string rutaFichero)
    {
        //Recibir el texto completo.
        StreamReader streamReader = new StreamReader(rutaFichero);
        string contenidoFichero = streamReader.ReadToEnd();
        streamReader.Close();

        string[] partesContenidoFichero = contenidoFichero.Split("\r\n");

        string contenidoFicheroInv = "";
        for (int i = partesContenidoFichero.Length - 1; i >= 0; i--)
        {
            contenidoFicheroInv += partesContenidoFichero[i];
        }

        //Se recorren los valores de atras a hacia delante para no 
        //tener fallos a la hora de crear el mapa, porque sino el mapa
        //Saldria invertido
        int numeroCaracterFichero = 0;

        for (int i = 0; i < arrayTablero.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < arrayTablero.GetUpperBound(1) + 1; j++)
            {
                if(numeroCaracterFichero < contenidoFicheroInv.Length){
                    arrayTablero[i, j] = int.Parse(contenidoFicheroInv.Substring(numeroCaracterFichero, 1));
                    numeroCaracterFichero++;
                }
            }
        }

        return arrayTablero;
    }

    /*
    private int[,] calcularDimensionTablero(string rutaFichero)
    {
        StreamReader streamReader = new StreamReader(rutaFichero);
        //Lee la cantidad de caracteres que hay en la primera linea del fichero
        int ancho = streamReader.ReadLine().Length;

        //Lee la cantidad de lineas del fichero, con la lontitud total del texto entre la anchura 
        //y sumando uno por que empieza a leer mas atras
        int alto = 1 + (streamReader.ReadToEnd().Length / ancho);

        streamReader.Close();
        return new int[alto, ancho];
    }
    */
}