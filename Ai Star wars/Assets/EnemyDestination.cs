using UnityEngine;
using System.Collections;

public class EnemyDestination : MonoBehaviour {
	
      private  NavMeshAgent enemyAgent; //need a NavMesh object so we can call it's method
	 public GameObject target; //made target public so you can assign ANY gameobject as a target
	// Use this for initialization
	 void Awake () {
		//Player = GameObject.FindGameObjectWithTag("Player");
     // enemyAgent is the agent this is applied to, need it's Navmesh component
	 enemyAgent = GetComponent<NavMeshAgent>();  // this script is on enemy get his navmesh
	}
	
	// Update is called once per frame
	void Update () {
		   
		// so simple method of navmesh agent type , pass in a vector 3 , in our case
		// position of target assigned in inspector - VIOLA finds the Path!
		enemyAgent.SetDestination(target.transform.position);
	
				}
}