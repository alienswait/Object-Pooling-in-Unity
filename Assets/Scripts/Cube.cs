using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, IPooledObject
{
    public float UpForce = 1f;
    public float SideForce = .1f;
    
    public void OnObjectSpawn()
    {
        float XForce = Random.Range(-SideForce, SideForce);
        float YForce = Random.Range(UpForce / 2f, UpForce);
        float ZForce = Random.Range(-SideForce, SideForce);


        Vector3 force = new Vector3(XForce, YForce, ZForce);

        GetComponent<Rigidbody>().velocity = force;
    }

}
