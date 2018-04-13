using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeScript : MonoBehaviour {

    public float sightlength = 100f;
    public GameObject selectedObj;
    public float hoverSpeed = 0.5f;
    public GameObject cub1;
    public GameObject cub2;
    public AudioClip jingle;
    private AudioSource audioSource { get { return GetComponent<AudioSource>(); } }
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = jingle;
    }
    // Update is called once per frame
    void FixedUpdate () {
        RaycastHit seen;
        Ray raydirection = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(raydirection, out seen, sightlength))
        {
            if (seen.collider.tag == "Button")
            {
                if ((cub1.active == false)&&(cub2.active ==false)) {
                    audioSource.PlayOneShot(jingle, 0.7F);
                    //  Debug.Log("found");
                    cub1.SetActive(true);
                cub2.SetActive(true);
                }
                /*    if(selectedObj!= null && selectedObj != seen.transform.gameObject)
                    {
                                GameObject hitObject = seen.transform.gameObject;
                              MoveMenuButton(hitObject);

                    }
                    selectedObj = seen.transform.gameObject;*/
            }
        }
	}
    private void MoveMenuButton(GameObject hitObject)
    {
        Debug.Log("found");
     //   cubi.SetActive(true);
        Vector3 newZ = hitObject.transform.position;
        newZ.z -= hoverSpeed;
        selectedObj.transform.position = newZ;

        newZ.z += hoverSpeed * 2;
        hitObject.transform.position = newZ;
    }
}
