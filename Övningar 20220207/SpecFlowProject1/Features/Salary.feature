Feature: Salary


@mytag
Scenario: Work hours per month
	Given that a workday is 8 hours
	And that a working week is 5 days
	And a standard month is 4 weeks
	Then there's 160 work hours per month

Scenario: Hourly salary
	Given that there's 160 work hours per month
	And that the monthly pay is 33 000
	Then the hourly pay should be 206.25

Scenario: Yearly salary
	Given that the working months per year is 12 (exc vacation etc)
	And that the monthly pay is 33 000
	Then the yearly salary will be 396 000
