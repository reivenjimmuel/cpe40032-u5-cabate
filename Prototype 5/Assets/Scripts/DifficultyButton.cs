using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        button.onClick.AddListener(SetDifficiculty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficiculty()
    {
        Debug.Log(button.gameObject + " was clicked");
        gameManager.StartGame(difficulty);
    }
}
