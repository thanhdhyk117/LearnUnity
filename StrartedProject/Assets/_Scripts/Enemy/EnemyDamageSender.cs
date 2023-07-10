using UnityEngine;

public class EnemyDamageSender : DamageSender 
{
    [Header("EnemyDamageSender")]
    [SerializeField] protected EnemyCtrl enemyCtrl; //Controller

    private void Awake() {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    protected override void ColliderSendDamage(Collider2D collision)
    {
        base.ColliderSendDamage(collision);
        this.enemyCtrl.damageReceiver.Receive(1);
    }
}