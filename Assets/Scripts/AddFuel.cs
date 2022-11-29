using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFuel : MonoBehaviour
{
    public CarController carController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collission)
    {
        carController.fuel = 1;
        Destroy(gameObject);
    }
}
