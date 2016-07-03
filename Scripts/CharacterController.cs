using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    Rigidbody rigid;

    public float speed;

    Vector3 movement;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
	

	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigid.AddForce(movement * speed * Time.deltaTime);

    }
}
