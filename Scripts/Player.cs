using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private float directionY;
    private float directionX;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {   //get input from the input manager in unity
        directionY = Input.GetAxis("Vertical");
        //only need to move in the y axis
        rb.velocity = new Vector2(rb.velocity.x, directionY * speed);

        //for horixontal movement
        //  directionX = Input.GetAxis("Horizontal");
        // //only need to move in the x axis
        // rb.velocity = new Vector2(directionX * speed, rb.velocity.y);

    }
}
