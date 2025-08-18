using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public static UI Instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI ammoText;

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
}
