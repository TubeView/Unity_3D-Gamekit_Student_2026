using UnityEngine;

public class HungerAreas : MonoBehaviour
{
    private Collider playerCollider;
    private HungerManager hungerManager;
    public bool strongerHunger;
    public bool fasterHunger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerCollider = GameObject.Find("Player").GetComponent<Collider>();
        hungerManager = GameObject.Find("HungerManager").GetComponent<HungerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (fasterHunger)
                hungerManager.fasterDamage = true;

            if (strongerHunger)
                hungerManager.extraDamage = true;
        }
        else
        {
            hungerManager.fasterDamage = false;
            hungerManager.extraDamage = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hungerManager.fasterDamage = false; 
            hungerManager.extraDamage = false;
        }
    }
}
