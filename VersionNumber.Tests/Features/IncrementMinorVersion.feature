Feature: Increment Minor Version Number
    Increment minor version number but ignoring major version

Scenario Outline: Increment minor version
    Given The current minor version is <currentminor>
	Given The current major version is <currentmajor>
	When Minor version is incremented
    Then The minor version should be <newminor>
	And The major version should be <newmajor>

	Examples:
		| currentminor | currentmajor | newmajor | newminor |
		| 0            | 0            | 0        | 1        |
		| 1            | 0            | 0        | 2        |
		| 2            | 0            | 0        | 3        |
		| 3            | 0            | 0        | 4        |
		| 4            | 0            | 0        | 5        |
		| 10           | 1            | 1        | 11       |
		| 21           | 2            | 2        | 22       |
		| 32           | 3            | 3        | 33       |
		| 43           | 4            | 4        | 44       |
		| 54           | 5            | 5        | 55       |