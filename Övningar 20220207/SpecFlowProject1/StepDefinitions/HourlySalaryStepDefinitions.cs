using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class HourlySalaryStepDefinitions
    {
        [Given(@"that there's (.*) work hours per month")]
        public void GivenThatTheresWorkHoursPerMonth(int hours)
        {
            int workHours = hours;
        }

        [Given(@"that the monthly pay is (.*)")]
        public void GivenThatTheMonthlyPayIs(Decimal sek)
        {
            Decimal monthlyPay = sek;
        }

        [Then(@"the hourly pay should be (.*)")]
        public void ThenTheHourlyPayShouldBe(Decimal sek)
        {
            // Decimal hourlyPay = själva funktionen;
            // självafunktionen.Should().Be(sek);

        }
    }
}
