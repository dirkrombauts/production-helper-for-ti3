Feature: Build Limit
While producing at a Space Dock, the number of plastic units that can be produced is limited.
It is governed by the Resource Value of the planet around which the Space Dock is orbiting.

Scenario: The Build Limit is equal to the Resource Value of the planet plus two

    Given I have a planet with Resource Value '1'
    When I produce units at the space dock of that planet
    Then the build limit is '3'

Scenario: The Enviro Compensator Technology Increases the Build Limit by one

    Given I have a planet with Resource Value '1'
    And I have the 'Enviro Compensator' Technology
    When I produce units at the space dock of that planet
    Then the build limit is '4'