using UnityEngine;
using System.Collections;

public class HitFlag : MonoBehaviour
{

    public bool cubeHit;
    
	void Start ()
    {
	
	}
	

	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        cubeHit = true;
    }
}
