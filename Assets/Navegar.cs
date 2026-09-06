using UnityEngine;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour
{
    public void IrAEscena(string nombreEscena)
    {
        Debug.Log("Intentando abrir la escena: " + nombreEscena);
        SceneManager.LoadScene(nombreEscena);
    }
}
