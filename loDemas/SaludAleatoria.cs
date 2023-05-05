using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludAleatoria : MonoBehaviour
{
    private int salud = 0;
    // Start is called before the first frame update
    void Awake()
    {
        salud = Random.Range(1,20);
    }

    public void reducirSalud(){
        salud -= Random.Range(1,10);
    }

    public void setSalud(int salud){
        this.salud = salud;
    }

    public int getSalud(){
        return salud;
    }
}
