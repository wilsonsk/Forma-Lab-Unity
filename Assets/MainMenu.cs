using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        // Create a Canvas
        GameObject canvasGO = new GameObject("MainMenuCanvas");
        Canvas canvas = canvasGO.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        CanvasScaler canvasScaler = canvasGO.AddComponent<CanvasScaler>();
        canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvasScaler.referenceResolution = new Vector2(1920, 1080);
        canvasGO.AddComponent<GraphicRaycaster>();

        // Create a Panel
        GameObject panelGO = new GameObject("MainMenuPanel");
        panelGO.transform.SetParent(canvasGO.transform);
        RectTransform panelRT = panelGO.AddComponent<RectTransform>();
        panelRT.sizeDelta = new Vector2(600, 800);
        panelRT.anchoredPosition = Vector2.zero;
        Image panelImage = panelGO.AddComponent<Image>();
        panelImage.color = new Color(0.94f, 0.85f, 0.69f); // Light beige color

        // Create Title Text
        GameObject titleGO = new GameObject("Title");
        titleGO.transform.SetParent(panelGO.transform);
        RectTransform titleRT = titleGO.AddComponent<RectTransform>();
        titleRT.sizeDelta = new Vector2(500, 100);
        titleRT.anchoredPosition = new Vector2(0, 300);
        Text titleText = titleGO.AddComponent<Text>();
        titleText.text = "FORMA LAB\nForce Playgrounds";
        titleText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        titleText.fontSize = 40;
        titleText.alignment = TextAnchor.MiddleCenter;
        titleText.color = new Color(0.4f, 0.48f, 0.28f); // Green color

        // Create Buttons
        string[] buttonLabels = { "Stretchy Fabric", "Squishy Shapes", "Fold Creatures", "Designer Mode" };
        Color buttonColor = new Color(0.85f, 0.63f, 0.39f); // Dark beige color

        for (int i = 0; i < buttonLabels.Length; i++)
        {
            GameObject buttonGO = new GameObject(buttonLabels[i]);
            buttonGO.transform.SetParent(panelGO.transform);
            RectTransform buttonRT = buttonGO.AddComponent<RectTransform>();
            buttonRT.sizeDelta = new Vector2(400, 80);
            buttonRT.anchoredPosition = new Vector2(0, 150 - (i * 100));
            Button button = buttonGO.AddComponent<Button>();
            Image buttonImage = buttonGO.AddComponent<Image>();
            buttonImage.color = buttonColor;

            GameObject buttonTextGO = new GameObject("Text");
            buttonTextGO.transform.SetParent(buttonGO.transform);
            RectTransform buttonTextRT = buttonTextGO.AddComponent<RectTransform>();
            buttonTextRT.sizeDelta = new Vector2(400, 80);
            buttonTextRT.anchoredPosition = Vector2.zero;
            Text buttonText = buttonTextGO.AddComponent<Text>();
            buttonText.text = buttonLabels[i];
            buttonText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            buttonText.fontSize = 24;
            buttonText.alignment = TextAnchor.MiddleCenter;
            buttonText.color = Color.black;
        }
    }
}
