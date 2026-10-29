using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ShootPrefab : MonoBehaviour
{
    [SerializeField] private GameObject shootPrefab;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coins"))
        {
            GameManager.score++;
            print("added score");
            Destroy(other.gameObject);
        }
    }

}
