using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneGlobalManager : Singleton<SceneGlobalManager>
{
    public string characterSelection;
    public string scenaGame;
    public string scenaResult;

    public GameObject characterSceneGO;
    public GameObject gameSceceGO;
    public GameObject resutlSceneGO;

    public InsertionSort puntaje;
    //Fade
    public float durationAnimation;
    public Image imageAnimation;
    public NotificationSimple notification1;
    public NotificationSimple notification2;

    private void Start()
    {
        StartFadeAnimation();
        Invoke("ActivarEscenaSelection", durationAnimation);
        notification1.Start();
        notification2.Start();
    }
    public void ActivarEscenaSelection()
    {
        if (SceneManager.GetSceneByName(characterSelection).isLoaded == false)
        {
            SceneManager.LoadScene(characterSelection, LoadSceneMode.Additive);
        }
        StartCoroutine(BuscarObjectScene(characterSelection));
    }
    public void ActivarEscenaGame()
    {
        if (SceneManager.GetSceneByName(scenaGame).isLoaded == false)
        {
            SceneManager.LoadScene(scenaGame, LoadSceneMode.Additive);
        }
        StartCoroutine(BuscarObjectScene(scenaGame));
        StartFadeAnimation();
    }
    public void ActivarEscenaResult()
    {
        if (SceneManager.GetSceneByName(scenaResult).isLoaded == false)
        {
            SceneManager.LoadScene(scenaResult, LoadSceneMode.Additive);
        }
        StartCoroutine(BuscarObjectScene(scenaResult));
        StartFadeAnimation();
    }

    IEnumerator DesactivarEscenaResult()
    {
        yield return new WaitForSeconds(0.2f);
        resutlSceneGO.SetActive(false);
    }
    IEnumerator DesactivarEscenaGame()
    {
        yield return new WaitForSeconds(0.2f);
        gameSceceGO.SetActive(false);
    }
    IEnumerator DesactivarEscenaSelection()
    {
        yield return new WaitForSeconds(0.2f);
        characterSceneGO.SetActive(false);
    }
    IEnumerator BuscarObjectScene(string referencesScene)
    {
        yield return new WaitForSeconds(0.1f);
        if (referencesScene == "CharacterSelection")
        {
            characterSceneGO = GameObject.Find(referencesScene);
        }
        else if(referencesScene == "MainGame") {
            gameSceceGO = GameObject.Find(referencesScene);
        }
        else if (referencesScene == "Results") {
            resutlSceneGO = GameObject.Find(referencesScene);
        }
    }
    public void StartFadeAnimation()
    {
        if (imageAnimation != null)
        {
            imageAnimation.color = new Color(imageAnimation.color.r, imageAnimation.color.g, imageAnimation.color.b, 1f);
        }
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        float timer = 0f;
        while (timer < durationAnimation)
        {
            timer += Time.deltaTime;
            float progress = Mathf.Clamp01(timer / durationAnimation);
            if (imageAnimation != null)
            {
                imageAnimation.color = new Color(imageAnimation.color.r - progress, imageAnimation.color.g - progress, imageAnimation.color.b - progress, 1f - progress);
            }
            yield return null;
        }
    }

    public void SelectionAndGame() {
        ActivarEscenaGame();
        ActivarEscenaResult();
        StartCoroutine(DesactivarEscenaResult());
        StartCoroutine(DesactivarEscenaSelection());
    }
    public void DescargarEscenas()
    {
        characterSceneGO.SetActive(true);
        SceneManager.UnloadSceneAsync(scenaGame);
        SceneManager.UnloadSceneAsync(scenaResult);
    }

}
