using UnityEngine;
using System.Collections;

public class BulletLife : MonoBehaviour {
    public int life;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        life -= 1;
        if(life == 0)
        {
            Destroy(gameObject);
        }
	}
}
