using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class WorkHoursPerMonthStepDefinitions
    {
        [Given(@"that a workday is (.*) hours")]
        public void GivenThatAWorkdayIsHours(int hours)
        {
            int workHours = hours;
        }

        [Given(@"that a working week is (.*) days")]
        public void GivenThatAWorkingWeekIsDays(int days)
        {
            int workingDays = days;
        }

        [Given(@"a standard month is (.*) weeks")]
        public void GivenAStandardMonthIsWeeks(int weeks)
        {
            int standardMonths = weeks;
        }

        [Then(@"there's (.*) work hours per month")]
        public void ThenTheresWorkHoursPerMonth(int hours)
        {
            //int monthlyHours = hours;
        }
    }
}
