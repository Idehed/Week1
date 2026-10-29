using UnityEngine;

public class Shoot  : MonoBehaviour
{
    [SerializeField] private GameObject ShootPrefab;
    [SerializeField] private Transform ShootPosition;
    [SerializeField] private float ShootForce = 20f;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootLogic();
            
        }
    }

    private void ShootLogic()
    {
        GameObject ShootPrefabs = Instantiate(ShootPrefab, ShootPosition.position, Quaternion.identity);
        Rigidbody2D rb = ShootPrefabs.GetComponent<Rigidbody2D>();
        rb.AddForce(ShootPosition.up * ShootForce, ForceMode2D.Force);
        Destroy(ShootPrefabs, 5f);
    }


    
}

