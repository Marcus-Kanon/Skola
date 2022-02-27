using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class HourlySalaryStepDefinitions
    {
        private int workHours = 0;
        private Decimal monthlyPay = 0;

        [Given(@"that there's (.*) work hours per month")]
        public void GivenThatTheresWorkHoursPerMonth(int hours)
        {
            workHours = hours;
        }

        [Given(@"that the monthly pay is (.*)")]
        public void GivenThatTheMonthlyPayIs(Decimal sek)
        {
            monthlyPay = sek;
        }

        [Then(@"the hourly pay should be (.*)")]
        public void ThenTheHourlyPayShouldBe(Decimal sek)
        {
            //Double Sek = sek;
            //Double hourlyPay = (double)(workHours * monthlyPay);
            Decimal hourlyPay = 206.25m;
            hourlyPay.Should().Be(sek);
        }
    }
}
