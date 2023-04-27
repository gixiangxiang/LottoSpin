using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatioTest : MonoBehaviour{

    public InputField num1;
    public InputField num2;
    public InputField num3;

    void Start () {
        num1.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
        num2.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
        num3.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }

    public void ValueChangeCheck () {
        int n1 = int.Parse(num1.text);
        int n2 = int.Parse(num2.text);
        int n3 = int.Parse(num3.text);

        int sum = n1 + n2 + n3;

        if (sum != 100) {
            int diff = 100 - sum;
            if (n1 == Mathf.Max(n1, Mathf.Max(n2, n3))) {
                n1 += diff;
            } else if (n2 == Mathf.Max(n1, Mathf.Max(n2, n3))) {
                n2 += diff;
            } else {
                n3 += diff;
            }
            num1.text = n1.ToString();
            num2.text = n2.ToString();
            num3.text = n3.ToString();
        }
    }
}
