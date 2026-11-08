using UnityEngine;
using UnityEngine.Events;

public class SpawnHealthPickup : MonoBehaviour
{
    
    public GameObject[] pickupPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPickup()
    {
        Instantiate(pickupPrefab[Random.Range(0, pickupPrefab.Length)], new Vector3(transform.position.x, transform.position.y+0.5f, transform.position.z), transform.rotation);
    }
}
