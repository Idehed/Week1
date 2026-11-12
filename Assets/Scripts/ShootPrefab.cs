using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ShootPrefab : MonoBehaviour
{
    [SerializeField] private GameObject shootPrefab;
    [SerializeField] private ParticleSystem hitEffect;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coins"))
        {
            GameObject hitEffectInstance = Instantiate(hitEffect.gameObject, other.transform.position, Quaternion.identity);
            Destroy(hitEffectInstance, 1f);

            GameManager.score++;
            Destroy(other.gameObject);
        }
    }

}
