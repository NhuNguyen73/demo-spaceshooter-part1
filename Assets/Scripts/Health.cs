using UnityEngine;
using System; // Cần thiết nếu chưa có

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint;
    // THÊM: Action sẽ được gọi khi đối tượng chết
    public System.Action onDead; //

    private int healthPoint;

    private void Start()
    {
        healthPoint = defaultHealthPoint;
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        if (healthPoint <= 0) Die();
    }

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation); //
        Destroy(explosion, 1); //
        Destroy(gameObject); //
        onDead?.Invoke(); // THÊM: Gọi event onDead
    }
}