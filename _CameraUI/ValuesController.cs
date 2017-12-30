using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Town.Controller
{
    public class ValuesController : MonoBehaviour
    {

        [Header("Values Texts")]
        [SerializeField] Text moneyText;
        [SerializeField] Text citizensText;
        [SerializeField] Text housesText;
        [SerializeField] Text farmsText;
        [SerializeField] Text orchardsText;

        public void changeAllTexts(float currentMoney, int currentCitizens)
        {
            changeMoneyText(currentMoney);
            changeCitizensText(currentCitizens);
        }

        public void changeMoneyText(float currentMoney)
        {
            moneyText.text = currentMoney.ToString();
        }

        public void changeCitizensText(int currentCitizens)
        {
            citizensText.text = currentCitizens.ToString();
        }

    }
}
