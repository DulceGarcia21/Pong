using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class InicioAConfiguracion : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current!= null && Keyboard.current.spaceKey.wasPressedThisFrame){
            SceneManager.LoadScene("Configuracion");
        }
    }
}
