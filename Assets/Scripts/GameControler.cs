using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject windSound;
    public GameObject pickupSound;

    public float easing = 0.05f;
    public int chipCount;

    private Vector3 destination;
    private GameObject activeDoor;

    // Start is called before the first frame update
    void Start()
    {
        chipCount = 0;
        activeDoor = null;
        windSound.SetActive(false);
        pickupSound.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (activeDoor != null)
        {
            Vector3 currentDestination = Vector3.Lerp(activeDoor.transform.position, destination, easing);
            activeDoor.transform.position = currentDestination;
        }
    }

    public void PickUpEvent()
    {
        Debug.Log("PickUpEvent fired");

        pickupSound.SetActive(true);

        if (chipCount == 1)
        {
            doorOpen(door1);
            windSound.SetActive(true);
        }
        else if (chipCount == 2)
        {
            doorOpen(door2);
        }

        Invoke("DisablePickupSound", 3f);
    }

    public void doorOpen(GameObject door)
    {
        float x, y, z;
        x = door.transform.position.x;
        y = door.transform.position.y;
        z = door.transform.position.z;

        destination = new Vector3(x, y-4, z);
        activeDoor = door;

        Debug.Log("x: " + destination.x + "   y: " + destination.y + "   z: " + destination.z);
    }

    void DisablePickupSound()
    {
        pickupSound.SetActive(false);
    }
}
