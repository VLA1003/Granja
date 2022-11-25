using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionMenuCrear : MonoBehaviour
{
    [SerializeField]
    public GameObject botonModoCrear, BotonModoCamara, fondo, titulo, botonSalir, botonArbol1, botonArbol2, botonCoche, botonBarril;

    public void ActivarMenu()
    {
        LeanTween.moveLocalY(botonModoCrear, -439.0f, 0.0f);
        LeanTween.moveLocalY(botonModoCrear, -700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalY(BotonModoCamara, -439.0f, 0.0f);
        LeanTween.moveLocalY(BotonModoCamara, -700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalX(fondo, 700.0f, 0.0f);
        LeanTween.moveLocalX(fondo, 385.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarTitulo);
    }

    public void ActivarTitulo()
    {
        LeanTween.moveLocalX(titulo, 700.0f, 0.0f);
        LeanTween.moveLocalX(titulo, 340.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonSalir);
    }

    public void ActivarBotonSalir()
    {
        LeanTween.moveLocalX(botonSalir, 700.0f, 0.0f);
        LeanTween.moveLocalX(botonSalir, 460.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonArbol1);
    }

    public void ActivarBotonArbol1()
    {
        LeanTween.moveLocalX(botonArbol1, 700.0f, 0.0f);
        LeanTween.moveLocalX(botonArbol1, 390.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonArbol2);
    }

    public void ActivarBotonArbol2()
    {
        LeanTween.moveLocalX(botonArbol2, 700.0f, 0.0f);
        LeanTween.moveLocalX(botonArbol2, 390.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonCoche);
    }

    public void ActivarBotonCoche()
    {
        LeanTween.moveLocalX(botonCoche, 700.0f, 0.0f);
        LeanTween.moveLocalX(botonCoche, 390.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonBarril);
    }

    public void ActivarBotonBarril()
    {
        LeanTween.moveLocalX(botonBarril, 700.0f, 0.0f);
        LeanTween.moveLocalX(botonBarril, 390.0f, 0.5f).setEaseOutExpo();
    }

    public void ReactivarMenus()
    {
        LeanTween.moveLocalX(fondo, 385.0f, 0.0f);
        LeanTween.moveLocalX(fondo, 700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalX(titulo, 385.0f, 0.0f);
        LeanTween.moveLocalX(titulo, 700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalX(botonSalir, 385.0f, 0.0f);
        LeanTween.moveLocalX(botonSalir, 700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalX(botonArbol1, 385.0f, 0.0f);
        LeanTween.moveLocalX(botonArbol1, 700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalX(botonArbol2, 385.0f, 0.0f);
        LeanTween.moveLocalX(botonArbol2, 700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalX(botonCoche, 385.0f, 0.0f);
        LeanTween.moveLocalX(botonCoche, 700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalX(botonBarril, 385.0f, 0.0f);
        LeanTween.moveLocalX(botonBarril, 700.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalY(botonModoCrear, -700.0f, 0.0f);
        LeanTween.moveLocalY(botonModoCrear, -439.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalY(BotonModoCamara, -700.0f, 0.0f);
        LeanTween.moveLocalY(BotonModoCamara, -439.0f, 0.5f).setEaseOutExpo();
    }
}
