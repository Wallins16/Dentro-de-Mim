using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life = 3;
    public float speed = 2f;
    Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        // Anda sempre em direção ao player SEM NAVMESH
        Vector3 dir = (player.position - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;

        // Morrer
        if (life <= 0)
            Destroy(gameObject);
    }

    public void TakeDamage(int dmg)
    {
        life -= dmg;
    }
}
