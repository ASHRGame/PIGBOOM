using UnityEngine;
using UnityEngine.UI;


public class StartGame : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    [SerializeField] private Button startBtn;

    [SerializeField] private GameObject canvasEndGame;


    void Start() 
    {
        Time.timeScale = 0;    
    }

    public void StartNewGame()
    {
        Time.timeScale = 1; 
        canvasEndGame.SetActive(false);
        canvas.enabled = false;
    }
}
