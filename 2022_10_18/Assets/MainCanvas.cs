using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainCanvas : MonoBehaviour
{
    public GameObject starCountText;
    public int starCount = 0;
    public GameObject endingImage;

    public GameObject[] Star;

    private void Start()
    {
        Star = GameObject.FindGameObjectsWithTag("Star");
    }

    private void Update() //매프레임마다 한번씩 실행됨
    {
        starCountText.GetComponent<TextMeshProUGUI>().text = "" + starCount + "/" + Star.Length;
    }

    public void Ending()
    {
        endingImage.SetActive(true);
    }

}
