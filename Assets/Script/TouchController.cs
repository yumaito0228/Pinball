using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

	public GameObject leftup;
	public GameObject leftdown;
	public GameObject rightup;
	public GameObject rightdown;

	public GameObject leftfripper;
	public GameObject rightfripper;

	private Rect rect;

	// Use this for initialization
	void Start () {
		Vector3 point_leftup = leftup.transform.position;
		Vector3 point_leftdown = leftdown.transform.position;
		Vector3 point_rightup = leftup.transform.position;
		rect = new Rect(point_leftup.x,point_leftup.y,Screen.height,Screen.width);

	}
	
	// Update is called once per frame
	void Update () {

		int count = Input.touchCount;

		for (int i = 0; i < count; i++) {
			Touch touch = Input.GetTouch (i);
			Vector2 Vec = new Vector2 (touch.position.x, Screen.height - touch.position.y);
			if (touch.phase == TouchPhase.Began) {
				//右側
				if (Vec.x <= rect.width / 2 && Vec.y >= rect.yMin) {
					FripperController leftfc = leftfripper.GetComponent<FripperController> ();
					leftfc.SetAngle (leftfc.flickAngle);
				}
				//左側
				if (Vec.x >= rect.width / 2 && Vec.y >= rect.yMin) {
					FripperController rightfc = rightfripper.GetComponent<FripperController> ();
					rightfc.SetAngle (rightfc.flickAngle);
				}
				if (Input.touchCount > 1) {
				}
			}
			if (touch.phase == TouchPhase.Ended) {
				FripperController leftfc = leftfripper.GetComponent<FripperController> ();
				leftfc.SetAngle (leftfc.defaultAngle);
				FripperController rightfc = rightfripper.GetComponent<FripperController> ();
				rightfc.SetAngle (rightfc.defaultAngle);
			}
		}
	}
}
