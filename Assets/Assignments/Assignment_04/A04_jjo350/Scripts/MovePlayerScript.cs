using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A04_jjo350 {
	public class MovePlayerScript : MonoBehaviour
    {

        public float maxSpeed;
        private Rigidbody myRb;
		private float speed;
        // Use this for initialization
       
        void Start()
        {
			speed = maxSpeed / 3;
            myRb = this.GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (Input.GetMouseButton(0)) {
                myRb.drag = 1;
                Vector3 force = Camera.main.transform.forward * speed;
                force.y = 0;
				if ((myRb.velocity + force).magnitude <= maxSpeed) {
					myRb.AddForce(force);
				}
            } else {
                myRb.drag = 5;
            }
        }
    }	
}

