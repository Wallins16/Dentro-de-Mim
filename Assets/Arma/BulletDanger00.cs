using UnityEngine;

public class BulletDanger00 : MonoBehaviour
{
    public float speed = 60f;
    public int damage = 1;

    void Update()
    {
        // movimenta a bala para frente sempre
        void Update()
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy e = other.GetComponent<Enemy>();
            if (e != null)
                e.TakeDamage(damage);
        }

        // destrói a bala quando colidir com qualquer coisa
        Destroy(gameObject);
    }
}
