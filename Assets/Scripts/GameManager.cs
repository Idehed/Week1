using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int score = 0;
    [SerializeField] private Rect r1 = new Rect(20, 10, 600, 64);
    [SerializeField] private Rect r2 = new Rect(20, 10, 600, 64);
    [SerializeField] private Rect r3 = new Rect(40, 10, 100, 32);

    private void OnGUI()
    {
        GUI.color = Color.white;
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.yellow;

        if (score >= 1)
        {
            GUI.Label(r2, "you win!!",style);
            if (GUI.Button(r3, "Restart"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                
            }
        }
        else
        {
            GUI.Label(r1, $"Score: {score}");
        }
    } 
}
