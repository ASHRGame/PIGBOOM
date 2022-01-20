using UnityEngine;

public class BigSetBomb : MonoBehaviour
{

    [SerializeField] private GameObject bomb;

    [SerializeField] private Bomb bombCheck;

    public void SetBomb()
    {
        if (bombCheck.isCheck)
        {
            var position = GetComponent<Transform>().position;
            var newBomb = Instantiate(bomb, position, Quaternion.identity);
            newBomb.SetActive(true);
            bombCheck.isCheck = false;
        }
    }
}
