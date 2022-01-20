using UnityEngine;
using UnityEngine.UI;


public class UpdateTextCountBomb : MonoBehaviour
{
    [SerializeField] private Bomb pigBomb;

    [SerializeField] private Text labelCountBomb;


    void Update()
    {

        if (pigBomb.isCheck)
        {
            labelCountBomb.text = "1";
        }
        else
        {
            labelCountBomb.text = "0";
        }
    }
}
