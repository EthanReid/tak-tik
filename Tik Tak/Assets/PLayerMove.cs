using UnityEngine;
using System.Collections;

public class PLayerMove : MonoBehaviour {
	Animator animator;	
	//public Sprite sprite1;
	//public Sprite sprite2;
	public bool isFacingRight = true;	
	public float jumpSpeed = 3f;
	public float superSpeed = 7;
	public float superJump = 3f;
	public bool wait = false;
	public float speed = 1.5f;
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
			transform.position += Vector3.left * speed * Time.deltaTime * 3;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime * 3;
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * jumpSpeed * Time.deltaTime * 3
			;
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

