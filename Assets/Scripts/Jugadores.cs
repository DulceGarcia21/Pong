using UnityEngine;

public class Jugadores : MonoBehaviour
{
    public KeyCode teclaArriba, teclaAbajo;
    private Rigidbody2D rb2D;

    void Start(){
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update(){
        
    }
}
