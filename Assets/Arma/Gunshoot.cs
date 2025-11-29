using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawn;
    public AudioSource audioSrc;
    public ParticleSystem flash;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, spawn.position, spawn.rotation);

            if (audioSrc) audioSrc.Play();
            if (flash) flash.Play();
        }
    }
}
