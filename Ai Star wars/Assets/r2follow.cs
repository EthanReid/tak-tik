using UnityEngine;
using System.Collections;

public class r2follow : MonoBehaviour {
	public bool playerInSight= false; //enemyAI script will need this  variable to determine: patrol or state agent
	
	public float fieldOfViewAngle  = 110f; //number of degree centered in forward direction - angle sight of enemy
	// Use this for initialization
	private Animator anim;  //to set playerInSight boolean in Animator
	//private LastPlayer lastPlayerSeen; //script needed?
	private GameObject player; //needed?
	private Animator animPlayer;
	private SphereCollider col;
	private Vector3 lastPlayerSighting;
	
	void Awake () {
		player = GameObject.FindGameObjectWithTag("Player");
		anim = GetComponent<Animator>(); //the enemies animator
		animPlayer = player.GetComponent<Animator>();
		col = GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		print (playerInSight); 
	}
	
	void OnTriggerStay (Collider other)
	{
		// If the player has entered the trigger sphere...
		if(other.gameObject == player)
		{
			// By default the player is not in sight.
			playerInSight = false;
			
			// Create a vector from the enemy to the player and store the angle between it and forward.
			Vector3 direction = other.transform.position - transform.position;
			float angle = Vector3.Angle(direction, transform.forward);
			
			// If the angle between forward and where the player is, is less than half the angle of view...
			if(angle < fieldOfViewAngle * 0.5f)
			{
				RaycastHit hit;
				
				// ... and if a raycast towards the player hits something...
				if(Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius))
				{
					// ... and if the raycast hits the player...
					if(hit.collider.gameObject == player)
					{
						// ... the player is in sight.
						playerInSight = true;
						
						// Set the last global sighting is the players current position.
						// lastPlayerSighting.position = player.transform.position;
					}
				}
			}
		}
	}
	void OnTriggerExit (Collider other)
	{
		// If the player leaves the trigger zone...
		if(other.gameObject == player)
			// ... the player is not in sight.
			playerInSight = false;
	}
	
	/*
void OnTriggerExit (Collider other)
    {
        // If the player leaves the trigger zone...
        if(other.gameObject.tag == "Player")
            // ... the player is not in sight.
            playerInSight = false;
    }
    */
	
	
}
