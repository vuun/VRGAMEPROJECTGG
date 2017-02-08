using UnityEngine;
using System.Collections;

public class SpawnCreep : MonoBehaviour {

    public int spawnTime;
    public float speed;
    int time;
    public GameObject enemy;
    GameObject director;
    Rigidbody movementControl;

	// Use this for initialization
	void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time += 1;
        if(time == spawnTime)
        {
            director = Instantiate(enemy);
            movementControl = director.GetComponent<Rigidbody>();
            director.transform.position = Random.onUnitSphere*50;
            movementControl.velocity = Vector3.MoveTowards(director.transform.position, transform.position, speed).normalized*speed*-1;
            time = 0;
            
        }
	}
}
