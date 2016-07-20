using UnityEngine;
using System.Collections;

public class TopDownCotnroller : MonoBehaviour {

    Rigidbody rigidBody;
    public float speed = 4;

    Vector3 lookPos;

    GameObject cam;

	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        cam = GameObject.FindWithTag("MainCamera");
	}

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, 100))
        {
            lookPos = hit.point;
        }

        Vector3 lookDir = lookPos - transform.position;
        lookDir.y = 0;

        transform.LookAt(transform.position + lookDir, Vector3.up);

        //cam.transform.position = new Vector3(transform.position.x, 10, transform.position.z);
    }
	
	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);
        rigidBody.AddForce(movement * speed / Time.deltaTime);
	}
}
