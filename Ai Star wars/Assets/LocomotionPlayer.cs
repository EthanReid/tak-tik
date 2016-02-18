 /// <summary>
/// 
/// </summary>

using UnityEngine;
using System;
using System.Collections;
  
[RequireComponent(typeof(Animator))]  

//Name of class must be name of file as well

public class LocomotionPlayer : MonoBehaviour {

    protected Animator animator;

    private float speed = 0;
    private float direction = 0;
    private Locomotion locomotion = null;
    
	// Use this for initialization
	void Start () 
	{   
        animator = GetComponent<Animator>(); //animator of gameobject that has this script
        locomotion = new Locomotion(animator);
	}
    
	void Update () 
	{    //either one why one method has advantage over the other???
		speed=GetComponent<NavMeshAgent>().desiredVelocity.magnitude;
		//speed = Vector3.Project(GetComponent<NavMeshAgent>().desiredVelocity, transform.forward).magnitude;
        animator.SetFloat("Speed", speed);
		
		animator.SetFloat("AngularSpeed", speed);
		animator.SetFloat("Direction", GetComponent<NavMeshAgent>().velocity.x);
		animator.rootPosition=GetComponent<NavMeshAgent>().desiredVelocity;
	}
}
