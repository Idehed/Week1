using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;

    private void OnGUI()
    {
        Rect r = new Rect(10, 10, 600, 64);
        GUI.color = Color.white;
        

        if (score > 5)
        {
            GUI.Label(r, "you win!!");
        }
        else
        {
            GUI.Label(r, $"Score: {score}");
        }
    }
}
