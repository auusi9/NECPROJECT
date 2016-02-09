using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Rigidbody2D ball;
    public CircleCollider2D portal;
    public CircleCollider2D ball_collider;
    public PolygonCollider2D spike;
	// Use this for initialization
	void Start () 
    {
        ball.AddForce(new Vector3(80.0f, 0.0f, 0.0f));
	}
	
	// Update is called once per frame
	void Update ()
    {
        ball.velocity = ball.velocity.normalized * 5.0f;
        if(ball_collider.IsTouching(portal))
        {
            ball.velocity = Vector3.zero;
        }
        else if(ball_collider.IsTouching(spike))
        {
            ball.velocity = Vector3.zero;
        }
	}
}
