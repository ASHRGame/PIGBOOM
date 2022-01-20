using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject canvas;

    [SerializeField] private Button endBtn;

    [SerializeField] private Text winText;
    [SerializeField] private Text falseText;
    [SerializeField] private NavMeshAgent agentDog;
    [SerializeField] private NavMeshAgent agentFarmer;
    [SerializeField] private GameObject pig;
    void Update()
    {
        if(agentDog.enabled == false && agentFarmer.enabled == false)
        {
            canvas.SetActive(true);
            falseText.enabled = false;
            Time.timeScale = 0;   
        }
        else if(pig.activeSelf == false)
        {
            canvas.SetActive(true);
            winText.enabled = false;
            Time.timeScale = 0;
        }
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
