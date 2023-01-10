using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class PointsAnim : MonoBehaviour
{
    GameObject TheCanvas;
    Vector3 pos;
    public float duration;
    // can ignore the update, it's just to make the coroutines get called for example
    void Update()
    {
    /*    if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(FadeTextToFullAlpha(1f, GetComponentInChildren<TextMeshProUGUI>()));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

        } */
    }

    private void Start()
    {
     
        TheCanvas = GameObject.Find("Canvas");
       // gameObject.transform.SetParent(TheCanvas.transform);
        gameObject.transform.SetParent(TheCanvas.transform, true);

        //StartCoroutine(FadeTextToZeroAlpha(0.1f, GetComponentInChildren<TextMeshProUGUI>()));
        StartCoroutine(FadeTextToFullAlpha(0.1f, GetComponentInChildren<TextMeshProUGUI>()));
       
    }
    public void StartAnim()
    {

       // 

    }


    public IEnumerator FadeTextToFullAlpha(float t, TextMeshProUGUI i)
    {
       // pos.x = 0f;
        pos.y = 853.5f;
        //pos.x = 0f;
        gameObject.transform.localPosition = pos;
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
        StartCoroutine(MoveDown());
        StartCoroutine(FadeTextToZeroAlpha(0.5f, GetComponentInChildren<TextMeshProUGUI>()));
    }

    IEnumerator MoveDown()
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * 500);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }

        float elapsedTime1 = 0f;
        while (elapsedTime1 < duration)
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * 500);
            elapsedTime1 += Time.deltaTime;

        }

        Destroy(gameObject);
    }
}