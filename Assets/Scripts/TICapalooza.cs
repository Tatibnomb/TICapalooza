using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza : MonoBehaviour
{
    public int entradasCampo;
    public int entradasPlatea;
    float totalRecaudacion;
    int totalCampo;
    int totalPlatea;
    int totalEntradas;
    int capacidadTotal;

    // Start is called before the first frame update
    void Start()
    {
        totalEntradas = entradasCampo + entradasPlatea;
        capacidadTotal = 20400 + 16200;
        if (entradasCampo < 0 || entradasCampo > 20400 || entradasPlatea < 0 || entradasPlatea > 16200)
        {
            Debug.Log("Cantidad de entradas no válida");
            return;
        }

        totalCampo = entradasCampo * 1200;
        totalPlatea = entradasPlatea * 2000;
        totalRecaudacion = totalCampo + totalPlatea;

        Debug.Log("La recaudación por campo fue $" + totalCampo);
        Debug.Log("La recaudación por platea fue $" + totalPlatea);
        Debug.Log("La recaudación total fue $" + totalRecaudacion);

        if (totalEntradas == capacidadTotal)
        {
            Debug.Log("Sold Out!");
        }
        else
        {
            Debug.Log("Capacidad vacante: " + (capacidadTotal - totalEntradas));
        }
        if (totalEntradas > capacidadTotal / 2)
        {
            Debug.Log("El festival fue un éxito!");
        }
        else
        {
            Debug.Log("Debemos mejorar la convocatoria");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
