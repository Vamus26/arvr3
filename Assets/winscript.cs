using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class winscript : MonoBehaviour {
    public GameObject cube1;
    public GameObject cube2;
    public GameObject podest;
    private Vector3 target1;
    private Vector3 t1_rot;
    private Vector3 t2_rot;
    private Vector3 target2;
    public Texture textl;
    // Use this for initialization
    void Start () {
       target1 = new Vector3(-4.326f, 0.88f, -0.379f);
       t1_rot = new Vector3(0, 90.0f, 0);
       target2 = new Vector3(-4.305f, 0.88f, 0.129f);
       t2_rot = new Vector3(0, 0, 90.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(cube1.transform.position, target1) < 0.1)
        {
           //  if (Vector3.Angle(cube1.transform.rotation.eulerAngles, t1_rot) < 0.1)
            {
                float tmp = Vector3.Angle(cube1.transform.forward, Vector3.right);
                float tmp1 = Vector3.Angle(cube1.transform.forward, Vector3.up);
                float tmp2 = Vector3.Angle(cube1.transform.forward, Vector3.forward);
                // float tmp = Vector3.Angle(cube1.transform.position, Vector3.right);
                Debug.Log("Step 1: "+ tmp2);
                if ((tmp > -2.0f) &&(tmp < 2.0f) && (88.0f < tmp1) && (tmp1 < 92.0f))
                {
                    Debug.Log("Cube1 correct: " + tmp2);
                    if (Vector3.Distance(cube2.transform.position, target2) < 0.1)
                    {
                        float tmp3 = Vector3.Angle(cube2.transform.forward, Vector3.right);
                        float tmp4 = Vector3.Angle(cube2.transform.forward, Vector3.up);
                        float tmp5 = Vector3.Angle(cube2.transform.forward, Vector3.forward);
                        // float tmp = Vector3.Angle(cube1.transform.position, Vector3.right);
                           Debug.Log("Step2: "+ tmp3+"temp4: "+tmp4);
                        if ((88.0f < tmp3) && (tmp3 < 92.0f) && (88.0f < tmp4) && (tmp4 < 92.0f))
                        {

                    //        if (Vector3.SignedAngle(cube2.transform.rotation.eulerAngles, t2_rot, Vector3.up) < 0.1)
                     //   {
                            podest.SetActive(false);
                            GetComponent<Renderer>().material.mainTexture = textl;
                            Debug.Log("You win");

                            //TODO print values for check
                            // angle_z = Vector3.Angle(transform.up, distance);
                            //  angle_x = Vector3.Angle(transform.right, distance);
                            //   angle_y = Vector3.Angle(transform.forward, distance);
                            //   Vector3.SignedAngle();
                            //
                        }
                    }
                }
            }
        }
	}
}
