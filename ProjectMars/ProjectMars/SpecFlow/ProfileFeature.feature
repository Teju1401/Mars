Feature: ProfileFeature
I would like to launch the Mars web portal with valid credentials and add,edit and update the Languages,Skills<Education and Certifications on profile home page


@tag1
Scenario: I logged into the Mars web portal and navigated to profile home page
	Given Loggin to the Mars web portal with valid credentials
	And navigated to the profile home page
	When I Edit the First and Last Name in the profile home page
	Then I could see the updated profile


	Scenario Outline: I succesfully loggin to the Mars web portal, navigated to the profile home page where i can add,edit and delete the Languages
	Given Loggin to the Mars web portal with valid credentials
	And navigate to profile home page to update the languages
	When I add,edit and delete the languages '<AddLanguages>','<EditLanguages>' on the profile page
	Then I could see the updated languages '<AddLanguages>','<EditLanguages>' on profile home page

	Examples: 
	| AddLanguages | EditLanguages |
	| English      | Hindi         |
	| Mexicon      | French        |
	
	

	Scenario Outline: I succesfully loggin to the Mars web portal, navigated to the profile home page where i can add,edit and delete the Skills
	Given Logiin to the Mars web portal with valid credentials
	And navigate to profile home page to update the Skills
	When I add,edit and delete the Skills '<AddSkills>','<EditSkills>' on the profile page
	Then I could see the updated Skills '<AddSkills>','<EditSkills>' on profile home page

	Examples: 
	| AddSkills | EditSkills |
	| Painting  | Cricket    |
	| Listening | Swimming   |

	Scenario Outline: I succesfully loggin to the Mars web portal, navigated to the profile home page where i can add,edit and delete the Education
	Given Logiin to the Mars web portal with valid credentials
	And navigate to profile home page to update the Education
	When I add,edit and delete the College and Degree '<AddCollege>','<AddDegree>','<EditCollege>','<EditDegree>' on the profile page
	Then I could see the updated College and Degree '<AddCollege>','<AddDegree>','<EditCollege>','<EditDegree>' on profile home page

	Examples: 
	| College | Degree        |
	| ABC     | Post Graduate |
	| XYZ     | Graduate      |

	Scenario Outline: I succesfully loggin to the Mars web portal, navigated to the profile home page where i can add,edit and delete the Certifications
	Given Logiin to the Mars web portal with valid credentials
	And navigate to profile home page to update the Certifications
	When I add,edit and delete the Certificates and Certified '<AddCertificate>','<AddCertified>','<EditCertificate>','<EditCertified>' on the profile page
	Then I could see the updated Certificates and Certified '<AddCertificate>','<AddCertified>','<EditCertificate>','<EditCertified>' on profile home page

	Examples: 
	| Certificate | Certified |
	| Baking      | Bakers    |
	| Swimming    | Athelet   |