using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public GameObject player;
    public GameObject bullet;
    public int speed;

    GameObject bullets;
    Rigidbody moveBullets;
    bool reload;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount == 0) reload = true;
        if ( (Input.touchCount != 0 || Input.GetKeyDown(KeyCode.Mouse0)) && reload == true)
        {
            bullets = Instantiate(bullet);
            moveBullets = bullets.GetComponent<Rigidbody>();
            bullets.transform.position = transform.position + transform.TransformDirection(new Vector3(0, 0, 3));
            moveBullets.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            reload = false;
        }
	}
}
