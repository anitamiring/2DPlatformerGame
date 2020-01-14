using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D playerRigidbody;

    [SerializeField]
    private float movementForce;

    [SerializeField]
    private float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float x_movement = Input.GetAxis("Horizontal");

        if (playerRigidbody.velocity.magnitude < maxSpeed)
        {
            Vector2 movement = new Vector2(x_movement, 0);
            playerRigidbody.AddForce(movementForce * movement);
        }
        
    }
}
