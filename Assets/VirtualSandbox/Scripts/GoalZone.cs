using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalZone : MonoBehaviour
{
    public GameObject CurrentLevel;
    public GameObject NextLevel;

    //Detect collisions between the GameObjects with Colliders attached
    void OnTriggerEnter(Collider other)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (other.gameObject.CompareTag("Player"))
        {
            //If the GameObject has the same tag as specified, output this message in the console
            //Debug.Log("Do something else here");
            other.gameObject.GetComponent<SphereController>().RunResetPhysics();
            CurrentLevel.SetActive(false);
            NextLevel.SetActive(true);
        }
    }
}
