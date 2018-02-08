using UnityEngine;
using System.Collections;

public class NewBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("hello");
		print ("how are you");

		int max = 1000;
		int min = 1;

		print ("the highest number you can pick is " + max);
		print ("the lowest number you can pick is " + min);

		print ("is the number higher or lower than " + (max / 2));
		print ("up = higher, down = lower, return = equal");

	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			print("up arrow pressed");
	}
}
