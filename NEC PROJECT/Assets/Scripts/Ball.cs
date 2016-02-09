using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Rigidbody2D ball;
    public CircleCollider2D portal;
    public CircleCollider2D ball_collider;
    public PolygonCollider2D spike;
    public PolygonCollider2D power_up_speed;
    public Vector3 ball_position;
    float actual_time;
    float speed;
    bool active;
	// Use this for initialization
	void Start () 
    {
        ball.AddForce(new Vector3(80.0f, 0.0f, 0.0f));
        speed = 5.0f;
	}
	
    void Reset()
    {
        ball.position = ball_position;
    }

	// Update is called once per frame
	void Update ()
    {
        ball.velocity = ball.velocity.normalized * speed;
        if(active == true)
        {
            speed = 10.0f;
            ball.AddForce(new Vector3(80.0f, 0.0f, 0.0f));
            if((Time.time - actual_time) > 2.0f)
            {
                active = false;
                speed = 5.0f;
            }
        }
        
        if(ball_collider.IsTouching(portal))
        {
            ball.velocity = Vector3.zero;
        }
        else if(ball_collider.IsTouching(spike))
        {
            Reset();
        }
        else if(ball_collider.IsTouching(power_up_speed))
        {
            actual_time = Time.time;
            active = true;
        }
	}
}
