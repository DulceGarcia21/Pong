using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class Configuracion : MonoBehaviour
{
    public TMP_Text op1,op2;
    public static int tipoJuego = 1; //1 contra la computadora, 2 contra otra persona


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake(){
        tipoJuego = 1;
        op1.gameObject.SetActive(true);
        op2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        if (Keyboard.current != null && Keyboard.current.digit1Key.wasPressedThisFrame){
            BorrarSubrrayado();
            op1.gameObject.SetActive(true);
            tipoJuego = 1;
        }
        if (Keyboard.current != null && Keyboard.current.digit2Key.wasPressedThisFrame){
            BorrarSubrrayado();
            op2.gameObject.SetActive(true);
            tipoJuego = 2;
        }
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame){
            SceneManager.LoadScene("Main");
        }
    }

    public void BorrarSubrrayado(){
        op1.gameObject.SetActive(false);
        op2.gameObject.SetActive(false);
    }
}
