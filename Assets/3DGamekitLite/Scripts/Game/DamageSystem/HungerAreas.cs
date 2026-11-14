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
        if (other.tag == "Player")
        {
            if (fasterHunger)
                hungerManager.fasterDamage = true;

            if (strongerHunger)
                hungerManager.extraDamage = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (fasterHunger)
            hungerManager.fasterDamage = false;
        
        if (strongerHunger)
            hungerManager.extraDamage = false;
    }
}
