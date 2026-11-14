using UnityEngine;
using Gamekit3D;

public class HealthPickup : MonoBehaviour
{
    public bool hungerActivate;
    public bool hungerCancel;
    public bool fullRegen;
    public int healAmount;
    
    private MeshCollider itemCollider;
    private HungerManager hungerManager;
    private Damageable damageable;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        itemCollider = GetComponent<MeshCollider>();
        hungerManager = GameObject.Find("HungerManager").GetComponent<HungerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        damageable = other.GetComponent<Damageable>();
        hungerManager.damageTimer = 0;
        if (hungerActivate)
            hungerManager.hungerActive = true;
        if (hungerCancel)
            hungerManager.hungerActive = false;
        if (fullRegen)
        {
            damageable.ResetDamage();
        }
        else if (!fullRegen)
        {
            damageable.Heal(healAmount);
        }
        GameObject.Destroy(gameObject);
    }
}
