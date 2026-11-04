using Gamekit3D;
using UnityEngine;

public class HungerManager : MonoBehaviour
{
    public GameObject player;
    private Damageable damageable;
    private float damageTimer;
    private int timerGoal;
    private int damageValue;
    public bool fasterDamage;
    public bool extraDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageable = player.GetComponent<Damageable>();
        damageTimer = 0;
        timerGoal = 10;
    }

    // Update is called once per frame
    void Update()
    {
        damageTimer += Time.deltaTime;
        Debug.Log("Damage Timer: " + damageTimer);
        if (fasterDamage)
            timerGoal = 7;
        else
            timerGoal = 10;
        if (damageTimer >= timerGoal && !extraDamage)
        {
            damageValue = 1;
            Damage();
        }
        else if (damageTimer >= timerGoal && extraDamage)
        {
            damageValue = 2;
            Damage();
        }
    }

    public void Damage()
    {
        damageTimer = 0;
        Damageable.DamageMessage damage = new Damageable.DamageMessage();
        {
            damage.amount = damageValue;
            damage.damager = this;
            damage.direction = Vector3.zero;
            damage.damageSource = Vector3.zero;
            damage.throwing = false;
            damage.stopCamera = false;
        }
        damageable.ApplyDamage(damage);
    }
}
