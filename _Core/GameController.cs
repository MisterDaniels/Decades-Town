using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Town.Controller
{
    public class GameController : MonoBehaviour
    {

        [Header("Initial Variables")]
        [SerializeField] float money = 200f;
        [SerializeField] int citizens = 5;
        [SerializeField] int houses = 0;
        [SerializeField] int farms = 0;
        [SerializeField] int orchards = 0;
        [SerializeField] float timeBetweenMoneyGive = 2f;

        ValuesController valuesController;

        private float currentMoney = 0;
        private int currentCitizens = 0;
        private int currentHouses = 0;
        private int currentFarms = 0;
        private int currentOrchards = 0;

        public float GetCurrentMoney()
        {
            return this.currentMoney;
        }

        public void SetCurrentMoney(float quantity)
        {
            this.currentMoney += quantity;
            valuesController.changeMoneyText(currentMoney);
        }

        public float GetCurrentCitizens()
        {
            return this.currentCitizens;
        }

        public void SetCurrentCitizens(int quantity)
        {
            this.currentCitizens += quantity;
            valuesController.changeCitizensText(currentCitizens);
        }

        public float GetCurrentHouses()
        {
            return this.currentHouses;
        }

        public void SetCurrentHouses(int quantity)
        {
            this.currentHouses += quantity;
        }

        public float GetCurrentFarms()
        {
            return this.currentFarms;
        }

        public void SetCurrentFarms(int quantity)
        {
            this.currentFarms += quantity;
        }

        public float GetCurrentOrchards()
        {
            return this.currentOrchards;
        }

        public void SetCurrentOrchards(int quantity)
        {
            this.currentOrchards += quantity;
        }

        // Use this for initialization
        void Start()
        {
            valuesController = GameObject.FindGameObjectWithTag("Values Controller").GetComponent<ValuesController>();
            ResetCurrentValues();
        }

        public void ResetCurrentValues()
        {
            this.currentMoney = this.money;
            this.currentCitizens = this.citizens;
            this.currentHouses = this.houses;
            this.currentFarms = this.farms;
            this.currentOrchards = this.orchards;
            valuesController.changeAllTexts(currentMoney, currentCitizens);
        }

        // Update is called once per frame
        void Update()
        {
            StartCoroutine(GiveMoney());
        }

        IEnumerator GiveMoney()
        {
            currentMoney += currentCitizens;
            Debug.Log("Você recebeu " + currentCitizens + "$!");
            valuesController.changeMoneyText(currentMoney);
            yield return new WaitForSecondsRealtime(timeBetweenMoneyGive);
        }
    }
}
