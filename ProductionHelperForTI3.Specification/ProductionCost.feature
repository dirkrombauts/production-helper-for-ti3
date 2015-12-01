Feature: Production Cost
    In order not to produce more units than I can afford
    I want to see how much the units I am building cost

Scenario Outline: Production Costs per Unit Type
    
    When I produce '<amount>' '<unit type>'
    Then I have to pay '<cost>' resource(s)

    Examples:
    | amount | unit type       | cost |
    | 2      | Ground Forces   | 1    |
    | 1      | Mechanized Unit | 2    |
    | 1      | PDS             | 2    |
    | 1      | Space Dock      | 4    |
    | 2      | Fighters        | 1    |
    | 1      | Destroyer       | 1    |
    | 1      | Cruiser         | 2    |
    | 1      | Carrier         | 3    |
    | 1      | Dreadnought     | 5    |
    | 1      | War Sun         | 12   |

Scenario: The Production Cost of a Single Ground Force is still 1

    Usually, Ground Forces are produced in pairs. Sometimes it is necessary to
    produce only one in order to respect the build limit. In those cases,
    the cost of producing one unit of Ground Forces is still a full Resource -
    it is not halved.

    When I produce '1' 'Ground Force'
    Then I have to pay '1' resource

Scenario: The Production Cost of a Single Fighter is still 1

    Usually, Fighters are produced in pairs. Sometimes it is necessary to
    produce only one in order to respect the build limit. In those cases,
    the cost of producing one unit of Fighters is still a full Resource -
    it is not halved.

    When I produce '1' 'Fighter'
    Then I have to pay '1' resource

Scenario Outline: The Sarween Tools Technology reduces the Production Costs by 1
    
    Given I have the 'Sarween Tools' Technology
    When I produce '<amount>' '<unit type>'
    Then I have to pay '<cost>' resource(s)

    Examples:
    | amount | unit type       | cost |
    | 2      | Ground Forces   | 0    |
    | 1      | Mechanized Unit | 1    |
    | 1      | PDS             | 1    |
    | 1      | Space Dock      | 3    |
    | 2      | Fighters        | 0    |
    | 1      | Destroyer       | 0    |
    | 1      | Cruiser         | 1    |
    | 1      | Carrier         | 2    |
    | 1      | Dreadnought     | 4    |
    | 1      | War Sun         | 11   |

Scenario: Combined Production Sums the Costs
An example of production of several units and the total cost, taking the Sarween Tools Technology into account.

    Given I have the 'Sarween Tools' Technology
    When I produce '1' 'War Sun'
    And I produce '10' 'Ground Forces'
    And I produce '2' 'Mechanized Units'
    And I produce '12' 'Fighters'
    And I produce '2' 'Carriers'
    Then I have to pay '32' resources

Scenario: The L1z1x Mindnet pays only 4 resources for a Dreadnought
One of the racial abilities of the L1z1x Mindnet is that they pay one less resource for a Dreadnought.

    Given my Race is the 'L1z1x Mindnet'
    When I produce '1' 'Dreadnought'
    Then I have to pay '4' resources

# Todo: Scenario Outline: Production Costs of Flagships