using System.Reflection.Emit;
using UnityEngine;

public class Shoot  : MonoBehaviour
{
    [SerializeField] private Rect r2 = new Rect(20, 40, 600, 64);
    [SerializeField] private GameObject ShootPrefab;
    [SerializeField] private Transform ShootPosition;
    [SerializeField] private float ShootForce = 20f;
    public int ShootCount = 0;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(ShootCount >=15)
            {
                print("No more shots left");
                return;
            }
            ShootLogic();
            
        }
    }

    private void ShootLogic()
    {
        ShootCount++;
        GameObject ShootPrefabs = Instantiate(ShootPrefab, ShootPosition.position, Quaternion.identity);
        Rigidbody2D rb = ShootPrefabs.GetComponent<Rigidbody2D>();
        rb.AddForce(ShootPosition.up * ShootForce, ForceMode2D.Force);
        Destroy(ShootPrefabs, 5f);
    }
    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.red;
        GUI.color = Color.white;
        GUI.Label(r2, $"Shots Left: {15 - ShootCount}", style);
    }
    
}

