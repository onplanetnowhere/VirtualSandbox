using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public GameObject Sphere;
    public Transform SphereStart;

    // Start is called before the first frame update
    void Start()
    {
        ResetPhysics();
    }

    private void StartPhysics()
    {
        Sphere.GetComponent<Rigidbody>().isKinematic = false;
        Sphere.GetComponent<Rigidbody>().useGravity = true;
    }

    private void ResetPhysics()
    {
        Sphere.transform.localPosition = SphereStart.localPosition;
        Sphere.GetComponent<Rigidbody>().isKinematic = true;
        Sphere.GetComponent<Rigidbody>().useGravity = false;
    }

    public void RunStartPhysics()
    {
        StartPhysics();
    }

    public void RunResetPhysics()
    {
        ResetPhysics();
    }
}
