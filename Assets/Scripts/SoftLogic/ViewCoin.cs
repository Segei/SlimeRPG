using System.Collections;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace SoftLogic
{
    public class ViewCoin : MonoBehaviour
    {
        [SerializeField] private TMP_Text coinValue;
        [SerializeField] private Color positiveColor, negativeColor;
        [SerializeField] private float secondToDestroy;
        [SerializeField] private Vector3 offset;


        public void SetValue(bool positive, int count)
        {
            string result = positive ? "+ " : "- ";
            result += count.ToString();

            coinValue.color = positive ? positiveColor : negativeColor;
            coinValue.text = result;
            RectTransform rectTransform = GetComponent<RectTransform>();
            rectTransform.DOMove(rectTransform.position + offset, secondToDestroy);
            StartCoroutine(DestroyWithDelay(secondToDestroy));
        }

        private IEnumerator DestroyWithDelay(float second)
        {
            yield return new WaitForSecondsRealtime(second);
            Destroy(this.gameObject);
            yield return null;
        }

    }
}