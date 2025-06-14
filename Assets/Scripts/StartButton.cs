
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    public CanvasGroup action;
    public CanvasGroup caution;
    private bool isCompetitiveMode;
    private bool isActionMode;
    public Sprite start;
    public Sprite compStart;

    public Image startButton;

    public RectTransform button;
    public void Start()
    {
        // Preveri, če Instance obstaja
        if (Prefrences.Instance != null)
        {
            isCompetitiveMode = Prefrences.Instance.competitiveOn;
            isActionMode = Prefrences.Instance.actionOn;
            UpdateButtonSprite();

            if (isActionMode)
            {
                action.alpha = 1f;
                caution.alpha = 1f;
            }
            else
            { 
                action.alpha = 0f;
                caution.alpha = 0f;
            }
        }
        

    }

    private void UpdateButtonSprite()
    {
        if (!isCompetitiveMode)
        {
            startButton.sprite = start;
            button.sizeDelta = new Vector2(600, 250);
            button.anchoredPosition = new Vector2(0, -170);
        }
        else
        {
            startButton.sprite = compStart;
            button.sizeDelta = new Vector2(700, 450);
            button.anchoredPosition = new Vector2(0, -60);
        }
    }

    public void StartClick()
    {
        SceneManager.LoadScene("Coma");
    }
}
