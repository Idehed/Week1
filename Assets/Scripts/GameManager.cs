using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int score = 0;
    [SerializeField] private Rect r1 = new Rect(20, 10, 600, 64);
    [SerializeField] private Rect r2 = new Rect(80, 10, 100, 32);
    [SerializeField] private Rect r3 = new Rect(80, 10, 100, 32);
    [SerializeField] private Rect r4 = new Rect(80, 10, 100, 32);
    [SerializeField] private Rect r5 = new Rect(80, 10, 100, 32);
    [SerializeField] private Rect r6 = new Rect(80, 10, 100, 32);

    private Shoot shoot;

    private void Awake()
    {
        shoot = FindFirstObjectByType<Shoot>();
    }



    private void OnGUI()
    {
        GUI.color = Color.lightBlue;
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.green;
        GUIStyle style1 = new GUIStyle();
        style1.normal.textColor = Color.red;

        if (score >= 7)
        {
            
            Time.timeScale = 0f;
            GUI.Label(r1, "You win!",style);
            PlayAgainButton();
        }
        else if(shoot.ShootCount >= 15)
        {
            Time.timeScale = 0f;
            GUI.Label(r1, "You lose!", style1);
            PlayAgainButton();
        }

        else
        {
            GUI.Label(r1, $"Score: {score}");
            GUI.Label(r3, "Controlls");
            GUI.Label(r4, "Left = A");
            GUI.Label(r5, "Right = D");
            GUI.Label(r6, "Shoot =  Left mouse button");
        }
    }

    private void PlayAgainButton()
    {
        GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
        buttonStyle.normal.textColor = Color.lightBlue;
        buttonStyle.hover.textColor = Color.blue;
        buttonStyle.fontSize = 12;

        if (GUI.Button(r2, "Play again", buttonStyle))
        {
            //GUI.backgroundColor = Color.red;
            score = 0;
            shoot.ShootCount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1f;

        }

    }
}
