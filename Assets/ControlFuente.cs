using UnityEngine;
using TMPro;

public class ControlFuente : MonoBehaviour
{
    public TMP_Text texto;

    public void CambiarTexto(string nuevoTexto)
    {
        texto.text = nuevoTexto;
    }

    // Método que recibe un nombre de color como string
    public void CambiarColorPorNombre(string nombreColor)
    {
        switch (nombreColor.ToLower())
        {
            case "rojo":
                texto.color = Color.red;
                break;
            case "azul":
                texto.color = Color.blue;
                break;
            case "verde":
                texto.color = Color.green;
                break;
            default:
                texto.color = Color.black;
                break;
        }
    }
}
