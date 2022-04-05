Feature: ProfileFeature
I would like to launch the Mars web portal with valid credentials and add,edit and update the Languages,Skills,Education and Certifications on profile home page


@tag1
Scenario: I logged into the Mars web portal and navigated to profile home page
	Given Loggin to the Mars web portal with valid credentials
	And I navigated to the profile home page
	When I click on the Profile home page
	Then I could see the profile name


	Scenario Outline: Create Languages in profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to the profile home page 
	When I create languages '<Languages>' on the profile page
	Then the record should be created '<Languages>'

	Examples: 
	| Languages    | 
	| English      | 
	| Mexicon      | 

	Scenario Outline: Update the Languages on the profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to the profile home page 
	When I update languages '<Languages>' on the profile page
	Then I could see the updated language record '<Languages>'

	Examples:
	| Languages |
	| Hindi     |
	| French    |

Scenario: Delete the Languages in profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to the profile home page 
	When I Delete languages on the profile page
	Then the record should be deleted
	
	

	Scenario Outline:Create Skills on the profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigate to the profile home page 
	When I create Skills '<Skills>' on the profile page
	Then I could see the created '<Skills>'

	Examples: 
	| Skills   | 
	| Painting | 
	| Listening| 
	Scenario Outline:Update Skills on the profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to profile home page
	When I update the Skills '<Skills>' on the profile page
	Then I could see the updated skills record '<Skills>'

	Examples: 
	| Skills   |
	| Dancing  |
	| Swimming |

	Scenario: Delete the Skills in profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to the profile home page 
	When I Delete Skills on the profile page
	Then the Skills record should be deleted

	Scenario Outline:Create Education on the profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to profile home page
	When I create the College and Degree '<College>','<Degree>' on the profile page
	Then I could see the created'<College>','<Degree>'

	Examples: 
	| College | Degree        |
	| ABC     | Post Graduate |
	| XYZ     | Graduate      |

	Scenario Outline:Update Education on the profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to profile home page
	When I update the College and Degree '<College>','<Degree>' on the profile page
	Then I could see the updated education record '<College>','<Degree>'

	Examples: 
	| College | Degree        |
	| QWERTY  | Begginer      |
	| EFG     | School        |

	Scenario: Delete Education on profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to the profile home page 
	When I Delete Education record on the profile page
	Then the Education record should be deleted

	Scenario Outline: Create Certifications on the profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to profile home page
	When I create the Certificates and Certified '<Certificate>','<Certified>' on the profile page
	Then I could see the created record '<Certificate>','<Certified>'
	Examples: 
	| Certificate | Certified |
	| Baking      | Bakers    |
	| Swimming    | Athelet   |

	Scenario Outline: Update Certifications on the profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to profile home page
	When I update the Certificates and Certified '<Certificate>','<Certified>' on the profile page
	Then I could see the updated certificates and certfied record '<Certificate>','<Certified>'

	Examples: 
	| Certificate | Certified  |
	| Painting    | XYZ college|
	| Dancing     | Studio     |
	
	Scenario: Delete Certifications on profile home page
	Given I Loggin to the Mars web portal succesfully
	And I navigated to the profile home page 
	When I Delete Certifications record on the profile page
	Then the Certifications and certified record should be deleted