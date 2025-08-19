using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public static UI Instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI ammoText;
    [SerializeField] private GameObject tryAgainButton;
    private int scoreValue;


    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {

    }


    void Update()
    {
        if (Time.time >= 1)
            timerText.text = Time.time.ToString("#,#");


    }
    public void AddScore()
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString("#,#");
    }

    public void UpdateAmmo(int currenBullets, int maxBullets)
    {
        ammoText.text = currenBullets + "/" + maxBullets;
    }


    public void OpenEndScreen()
    {
        Time.timeScale = 0;
        tryAgainButton.SetActive(true);
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
