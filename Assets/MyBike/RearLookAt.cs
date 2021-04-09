using UnityEngine;
using System.Collections;

public class RearLookAt : MonoBehaviour
{


    public Transform target;
    public Vector3 position;

	void Update () {

        Vector3 dist = transform.localPosition - target.localPosition;
        Quaternion rot = Quaternion.LookRotation(dist + position);
        transform.localRotation = rot;
	}
}
