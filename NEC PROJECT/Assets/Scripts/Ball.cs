using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

    public string LevelName;
    public Rigidbody2D ball;
    public Vector3 ball_position;
    float actual_time;
    float speed;
    bool velocity;
    bool shield;

	// Use this for initialization
	void Start () 
    {
        ball.AddForce(new Vector3(80.0f, 0.0f, 0.0f));
        speed = 5.0f;
	}
	
    public void ResetActualScene()
    {
        SceneManager.LoadScene(LevelName);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Spikes")
        {
            if (shield == false)
            {
   
                ResetActualScene();
 
            }
            else shield = false;
        }
        
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
      
        if (col.gameObject.name == "Portal")
        {
            ball.velocity = Vector3.zero;
        }
        else if (col.gameObject.name == "Power-up01")
        {
            actual_time = Time.time;
            velocity = true;
            Destroy(col.gameObject);
        }
        else if(col.gameObject.name == "Shield")
        {
            shield = true;
            Destroy(col.gameObject);
            
        }

    }

    // Update is called once per frame
    void Update ()
    {
        ball.velocity = ball.velocity.normalized * speed;
       

        if (shield == true)
        {
            
            //Instantiate(this, ball.position, ball.transform.rotation);
            //shield = false; 
            
        }


        //Velocity PowerUp
        if (velocity == true)
        {
            speed = 10.0f;
            ball.AddForce(ball.velocity.normalized * speed);

            if((Time.time - actual_time) > 2.0f)
            {
                velocity = false;
                speed = 5.0f;
            }
        }

	}
}
