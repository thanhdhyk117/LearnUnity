using UnityEngine;

public class EnemyDamageReceiver :  DamageReceiver
{
    [Header("EnemyDamageSender")]
    public EnemyCtrl enemyCtrl; //Controller

    private void Awake() {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void Reset() {
        this.hp = 3;
    }

    public override void Receive(int damage)
    {
        base.Receive(damage);
        if(this.IsDead())
        {
            this.enemyCtrl.despwaner.Despwan();
            EffectManager.instance.SpawnVFX("Explosion_A", transform.position, transform.rotation);
        } 
    }
}