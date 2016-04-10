using UnityEngine;
using System.Collections;

public class triggerBehaviour : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vessel")
            Debug.Log("Pretty hit");
    }
}
