using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Player Settings")]
    [Tooltip("This is the name of the player")]
    [SerializeField] private string playerName;

    [Range(0, 100)]
    [SerializeField] private int playerHealth;
    [HideInInspector] public bool isPlayer;
    void Start()
    {

        Debug.Log("Hello World");
        Debug.Log("This is a test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
