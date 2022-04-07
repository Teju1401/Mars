Feature: ProfileFeature
I would like to launch the Mars web portal with valid credentials and perform CRUD operation for Languages,Skills,Education and Certifications on profile home page


@tag1
Scenario: I logged into the Mars web portal and navigated to profile home page
	Given Loggin to the Mars web portal with valid credentials
	And I navigated to the profile home page
	When I click on the Profile home page
	Then I could see the profile name


	Scenario Outline: I succesfully login to the web portal to perfom CRUD operations for Languages
	Given I Loggin to the Mars web portal succesfully with valid credentials to perform CRUD
	And I navigated to the profile home page to perform CRUD for languages 
	When I create language '<Languages>' on the profile page
	Then The language record should be able to create '<Languages>' 
	When I update the languages '<Updatelanguages>' on the profile home page
	Then The language record should be updated with '<Updatelanguages>' on th profile home page
	When I delete the Languages on the profile home page
	Then the language record should be deleted on the profile home page

	Examples: 
	| Languages | Updatelanguages |
	| English   | Hindi           |
	| French    | Mexicon         |



		

	Scenario Outline: I succesfully login to the web portal to perfom CRUD operations for Skills
	Given I Loggin to the Mars web portal succesfully to perform CRUD for skills
	And I navigate to the profile home page to perform CRUD for skills
	When I create Skills '<Skills>' on the profile page
	Then The skillsrecord should be able to create '<Skills>' 
	When I update the Skills '<Updateskills>' on the profile home page
	Then The skills record should be updated with '<Updateskills>' on th profile home page
	When I delete the Skills on the profile home page
	Then the Skills record should be deleted on the profile home page

	Examples: 
	| Skills    | Updateskills |
	| Painting  | Dancing      |
	| Listening | Swimming     |
	

	Scenario Outline: I succesfully login to the web portal to perfom CRUD operations for Education
	Given I Loggin to the Mars web portal succesfully to perform CRUD for Education
	And I navigate to the profile home page to perform CRUD for Education
	When I create College and Degree in Education '<College>','<Degree>' on the profile page
	Then The Education record should be to create '<College>','<Degree>' 
	When I update the College and Degree in Education '<updateCollege>','<updateDegree>' on the profile home page
	Then The Education record should be updated '<updateCollege>','<updateDegree>' on th profile home page
	When I delete the Education on the profile home page
	Then the Education record should be deleted on the profile home page

	Examples: 
	| College | Degree        | updateCollege | updateDegree |
	| ABC     | Post Graduate | QWERTY        | Begginer     |
	| XYZ     | Graduate      | EFG           | School       |

	

	

	