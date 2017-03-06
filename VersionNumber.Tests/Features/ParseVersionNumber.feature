Feature: Parse Version Number
    Parse version number from a provided string

Scenario Outline: Parse version number from a string
    Given Version number to be parsed is <parseable>
    When It is parsed
    Then The major version should be <major>
    Then The minor version should be <minor>

	Examples:
        | parseable       | major | minor |
        | "1.0.1.5"       | 1     | 5     |
        | "1.0.2.4"       | 2     | 4     |
        | "1.0.3.3"       | 3     | 3     |
        | "1.0.4.2"       | 4     | 2     |
        | "1.0.5.1"       | 5     | 1     |
        | "0.0.1.5"       | 1     | 5     |
        | "0.0.2.4"       | 2     | 4     |
        | "0.0.3.3"       | 3     | 3     |
        | "0.0.4.2"       | 4     | 2     |
        | "0.0.5.1"       | 5     | 1     |
        | "10.0.111.5"    | 111   | 5     |
        | "10.0.112.4"    | 112   | 4     |
        | "10.0.113.3"    | 113   | 3     |
        | "10.0.114.2"    | 114   | 2     |
        | "10.0.115.1"    | 115   | 1     |
        | "10.0.115.1024" | 115   | 1024  |