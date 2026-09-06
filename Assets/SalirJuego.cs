using UnityEngine;

public class SalirJuego : MonoBehaviour
{
    public void Salir()
    {
        Debug.Log("Cerrando la aplicación...");
        Application.Quit();
    }
}
