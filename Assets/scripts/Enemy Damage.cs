using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter3D(Collider3D collision)
    {

        collision.GetComponent<Health>().TakeDamage(damage);
    }
}