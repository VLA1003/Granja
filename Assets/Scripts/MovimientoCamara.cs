using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Vector3 posicionInicial;
    public enum EstadoSelector
    {
        EnEspera,
        EstadoTransicion,
        MoviendoCamara,
    }

    void Update()
    {
        switch (estadoActual)
        {
            case EstadoSelector.EnEspera:
                estadoActual = EstadoSelector.EnEspera;
                break;
            case EstadoSelector.MoviendoCamara:
                DesplazamientoCamara();
                break;
            case EstadoSelector.EstadoTransicion:
                estadoActual = EstadoSelector.MoviendoCamara;
                break;
        }
    }

    [SerializeField]
    EstadoSelector estadoActual = EstadoSelector.EnEspera;

    public GameObject menuSeleccion;
    public GameObject botonRegresar;
    public GameObject camara;

    public void DesplazamientoCamara()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posicionInicial = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 delta = posicionInicial - Input.mousePosition;
            camara.transform.position += new Vector3(delta.x, 0f, delta.y);
            posicionInicial = Input.mousePosition;
        } 
    }

    public void CambioEstadoMovimiento()
    {
        estadoActual = EstadoSelector.EstadoTransicion;
        menuSeleccion.SetActive(false);
        botonRegresar.SetActive(true);
    }

    public void CambioEstadoEspera()
    {
        estadoActual = EstadoSelector.EnEspera;
        menuSeleccion.SetActive(true);
        botonRegresar.SetActive(false);
    }
}
