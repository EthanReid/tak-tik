using UnityEngine;
using System.Collections;

public class PLayerMove : MonoBehaviour {
	Animator animator;	
	//public Sprite sprite1;
	//public Sprite sprite2;
	public bool isFacingRight = true;	
	public bool wait = false;
	public float speed = 10.5f;
	//public Sprite sprite3;
	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator>();
	}
	
	 void Update () {
	
	
		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime * 3;
			wait = true;
		}

		if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime * 3;
			wait = true;
		}
		if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime * 3;
			wait = true;
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime * 3;
			wait = true;
		}



		
		
		
	}
}


