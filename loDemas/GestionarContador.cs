using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionarContador : MonoBehaviour
{
    private int numero = 0;
    
    public void aumentarContador(){
        numero++;
    }

    public void ceroContador(){
        numero = 0;
    }

    public int getNumero(){
        return numero;
    }
}
