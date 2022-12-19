using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChipPickUp : MonoBehaviour
{
    public GameObject gameControler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameControler.GetComponent<GameControler>().chipCount++;
        gameControler.GetComponent<GameControler>().PickUpEvent();
        Destroy(this.gameObject);
    }
}
