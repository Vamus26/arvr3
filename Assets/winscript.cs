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
             if (Vector3.Angle(cube1.transform.rotation.eulerAngles, t1_rot) < 0.1)
            {
                if (Vector3.Distance(cube2.transform.position, target2) < 0.1)
                {
                    if (Vector3.Angle(cube2.transform.rotation.eulerAngles, t2_rot) < 0.01)
                    {
                        podest.SetActive(false);
                        GetComponent<Renderer>().material.mainTexture = textl;
                        Debug.Log("You win");
                    }
                }
            }
        }
	}
}
