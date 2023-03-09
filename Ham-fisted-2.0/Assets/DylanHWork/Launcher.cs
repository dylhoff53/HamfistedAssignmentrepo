using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject target;
    public float launchForce;
    public Transform startPos;
    public GameObject missle;
    public void Fire()
    {
        FiringSolution fs = new FiringSolution();
        Nullable<Vector3> aimVector = fs.Calculate(transform.position, target.transform.position, launchForce, Physics.gravity);
        if (aimVector.HasValue)
        {
            GameObject missleObj = Instantiate(missle, startPos.position, Quaternion.identity);
            missleObj.GetComponent<Rigidbody>().AddForce(aimVector.Value.normalized * launchForce, ForceMode.VelocityChange);
        }
    }
}
