using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

	public GameObject Player;

	public Animator Cat;

	public float speed;

	void FixedUpdate()
	{
		if (Input.GetKey (KeyCode.UpArrow)) {
			//Player.GetComponent<Animation> ().Play ();
			Cat.SetBool("walk",true);
			Player.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			Player.transform.localPosition = new Vector3 (Player.transform.localPosition.x, Player.transform.localPosition.y, (Player.transform.localPosition.z + speed));
			Debug.Log ("Up");
		}
		else if(Input.GetKey (KeyCode.DownArrow))
		{
			//Player.GetComponent<Animation> ().Play ();
			Cat.SetBool("walk",true);
			Player.transform.localRotation = Quaternion.Euler(0f, 180f, 0f);
			Player.transform.localPosition = new Vector3 (Player.transform.localPosition.x, Player.transform.localPosition.y, (Player.transform.localPosition.z - speed));
			Debug.Log ("Down");
		}
		else if(Input.GetKey (KeyCode.LeftArrow))
		{
			//Player.GetComponent<Animation> ().Play ();
			Cat.SetBool("walk",true);
			Player.transform.localRotation = Quaternion.Euler(0f, 270f, 0f);
			Player.transform.localPosition = new Vector3 ((Player.transform.localPosition.x - speed), Player.transform.localPosition.y, Player.transform.localPosition.z);
			Debug.Log ("Left");
		}
		else if(Input.GetKey (KeyCode.RightArrow))
		{
			//Player.GetComponent<Animation> ().Play ();
			Cat.SetBool("walk",true);
			Player.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
			Player.transform.localPosition = new Vector3 ((Player.transform.localPosition.x + speed), Player.transform.localPosition.y, Player.transform.localPosition.z);
			Debug.Log ("Right");
		}
		else {
			Cat.SetBool("walk",false);
		//	Player.GetComponent<Animation> ().Stop ();
		}
	}


}
