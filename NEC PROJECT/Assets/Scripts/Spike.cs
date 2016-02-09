using UnityEngine;
using System.Collections;

public class Spike : MonoBehaviour {

    public Rigidbody2D spike;
    public Rigidbody2D square;
	// Use this for initialization
    void Start()
    {
        spike.transform.SetParent(square.transform);
    }

    void Update()
    {
        
    }
}
