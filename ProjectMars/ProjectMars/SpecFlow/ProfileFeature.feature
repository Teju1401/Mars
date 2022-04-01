Feature: ProfileFeature
I would like to launch the Mars web portal with valid credentials and add,edit and update the Languages,Skills<Education and Certifications on profile home page


@tag1
Scenario: I logged into the Mars web portal and navigated to profile home page
	Given Loggin to the Mars web portal with valid credentials
	And navigated to the profile home page
	When I Edit the First and Last Name in the profile home page
	Then I could see the updated profile


	Scenario Outline: I succesfully loggin to the Mars web portal, navigated to the profile home page where i can add and delete the Languages
	Given Loggin to the Mars web portal with valid credentials
	And navigate to profile home page to update the languages
	When I add and delete the languages '<Languages>' on the profile page
	Then I could see the updated languages '<Languages>' on profile home page

	Examples: 
	| Languages |
	| English   |
	| Hindi     |


	Scenario Outline: I succesfully loggin to the Mars web portal, navigated to the profile home page where i can add and delete the Skills
	Given Logiin to the Mars web portal with valid credentials
	And navigate to profile home page to update the Skills
	When I add and delete the Skills '<Skills>' on the profile page
	Then I could see the updated Skills '<Skills>' on profile home page

	Examples: 
	| Skills    |
	| Painting  |
	| Listening |

	Scenario Outline: I succesfully loggin to the Mars web portal, navigated to the profile home page where i can add and delete the Education
	Given Logiin to the Mars web portal with valid credentials
	And navigate to profile home page to update the Education
	When I add and delete the College and Degree '<College>''<Degree>' on the profile page
	Then I could see the updated College and Degree '<College>''<Degree>' on profile home page

	Examples: 
	| College | Degree        |
	| ABC     | Post Graduate |
	| XYZ     | Graduate      |

	Scenario Outline: I succesfully loggin to the Mars web portal, navigated to the profile home page where i can add and delete the Certifications
	Given Logiin to the Mars web portal with valid credentials
	And navigate to profile home page to update the Certifications
	When I add and delete the Certificates and Certified '<Certificate>''<Certified>' on the profile page
	Then I could see the updated Certificates and Certified '<Certificate>''<Certified>' on profile home page

	Examples: 
	| Certificate | Certified |
	| Baking      | Bakers    |
	| Swimming    | athelet   |