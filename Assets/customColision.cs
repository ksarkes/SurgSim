using UnityEngine;
using System.Collections;

public class customColision : MonoBehaviour {

    Vector3 averageNormal;
    GameObject otherObj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionStay(Collision col)
    {
        Debug.Log("Collision motherfucker " + col.collider.gameObject.name);
        
        if (col.collider.gameObject.tag != "static")
        {   /*
            foreach (ContactPoint point in col.contacts)
            {
                otherObj = point.otherCollider.gameObject;
                averageNormal += point.normal;
            }*/
            Debug.Log("Collision detecting, adding force");
            //otherObj.GetComponent<Rigidbody>().AddRelativeForce(averageNormal);
        }
    }
}
