using UnityEngine;

public class BombDamageReceiver :  DamageReceiver
{   public override void Receive(int damage)
    {
        base.Receive(damage);
        if(this.IsDead())
        {
            Destroy(gameObject);
            EffectManager.instance.SpawnVFX("Explosion_B", transform.position, transform.rotation);
        } 
    }
}