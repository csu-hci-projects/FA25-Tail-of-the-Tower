using UnityEngine;
using UnityEngine.UI;

public class EndingPagesUI : MonoBehaviour
{
    public Sprite[] pages;
    public Image displayImage;

    private int index = 0;

    private void OnEnable()
    {
        index = 0;
        Refresh();
    }

    public void Next()
    {
        if (index < pages.Length - 1)
        {
            index++;
            Refresh();
        }
    }

    public void Previous()
    {
        if (index > 0)
        {
            index--;
            Refresh();
        }
    }

    private void Refresh()
    {
        displayImage.sprite = pages[index];
    }
}
