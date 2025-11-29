using UnityEngine;

public class TIROOO : MonoBehaviour
{
    public GameObject bullet;          // Prefab da bala
    public Transform spawn;            // Ponto de saída da bala
    public AudioSource audioSrc;       // Som do tiro
    public ParticleSystem flash;       // Muzzle Flash (fogo da arma)

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Cria a bala
            Instantiate(bullet, spawn.position, spawn.rotation);

            // Som do tiro
            if (audioSrc != null)
                audioSrc.Play();

            // Flash da arma
            if (flash != null)
                flash.Play();
        }
    }
}
