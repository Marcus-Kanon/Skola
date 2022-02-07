using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class YearlySalaryStepDefinitions
    {
        [Given(@"that the working months per year is (.*) \(exc vacation etc\)")]
        public void GivenThatTheWorkingMonthsPerYearIsExcVacationEtc(int months)
        {
            int workingMonths = months;
        }

        [Then(@"the yearly salary will be (.*)")]
        public void ThenTheYearlySalaryWillBe(Decimal sek)
        {
            Decimal yearlySalary = sek;
        }
    }
}
