using UnityEngine;

public class rocketMove : MonoBehaviour
{
    public float velocity = 6;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void goRight () 
    {
            rb.velocity = Vector2.right * velocity;
    }   

    public void goLeft ()
    {   
            rb.velocity = Vector2.left * velocity;
    }
}
