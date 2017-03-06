Feature: Increment Major Version Number
    Increment major version number, resetting minor version to 0

Scenario Outline: Increment minor version
    Given The current minor version is <currentminor>
	Given The current major version is <currentmajor>
	When Major version is incremented
    Then The minor version should be <newminor>
	And The major version should be <newmajor>

	Examples:
        | currentminor | currentmajor | newmajor | newminor |
        | 1            | 0            | 1        | 0        |
        | 1            | 1            | 2        | 0        |
        | 2            | 2            | 3        | 0        |
        | 3            | 3            | 4        | 0        |
        | 20           | 21           | 22       | 0        |
        | 120          | 121          | 122      | 0        |
        | 220          | 221          | 222      | 0        |
        | 320          | 321          | 322      | 0        |
        | 420          | 421          | 422      | 0        |
        | 520          | 521          | 522      | 0        |