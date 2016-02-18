using UnityEngine;
using System.Collections;

public class PLayerMove : MonoBehaviour {
	Animator animator;	
	//public Sprite sprite1;
	//public Sprite sprite2;
	public bool isFacingRight = true;	
	public float jumpSpeed = 1.5f;
	public float superSpeed = 10;
	public float superJump = 4f;
	public bool wait = false;
	public float speed = 10.5f;
	//public Sprite sprite3;
	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator>();
	}
	
	 void Update () {
	
	

		/*if (Input.GetKey(KeyCode.RightArrow)){
			gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
			float h = Input.GetAxis("Horizontal");
			
			animator.SetFloat("Speed", Mathf.Abs (speed));
			print (speed);
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
		}*/
		if (Input.GetMouseButtonDown (0)){
			transform.position += Vector3.up * speed * Time.deltaTime * 3;
		}
		
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * jumpSpeed * Time.deltaTime * 3;
			wait = true;
		}
		/*if (wait == true) {

				yield return new WaitForSeconds(5);
				
			}*/

	 if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}

		


		
		
		
	}
}


