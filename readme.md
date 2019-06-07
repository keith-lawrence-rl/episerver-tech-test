Rufus Leonard Episerver 

-----------------------------------------

You have 1 hour to accomplish as much as possible. Bonus marks for SOLID development and unit-testing. Give some thought to how you would improve your solution for discussion after.

-----------------------------------------

User story: 

As a web-editor, I want to be able to drop a component onto a page which will allow me to showcase content relating to a pre-defined search term. 
As a web-editor, I want to be able to show a custom header and paragraph of text above the search results.

Functional requirements:

 - Create an Episerver component which can be customised and dropped onto the homepage
 - Component should contain at minimum the following CMS-editable properties:
    - Title (h1 header)
	- Precis (paragraph text)
	- Number of results to return (number)
	- Search string (one-line text)
 - The component should perform a content lookup or search within existing Episerver content, retrieving any pages which match the predefined 'Search' string in title or content. Search result data should be output in a simple unordered list. 
 
Example scenario:
 - The web-editor wants to showcase blog entries within a sidebar panel on the site. She drops the component onto the site, configures it with 5 maximum results and a search-term of 'blog'. The component displays 5 entries matching 'blog' in the title.
 ----------------------------------------- 
 
 Testable criteria:
  - Good use of SOLID 
  - Episerver Find is not necessary
  - Bonus marks for unit tests

----------------------------------------- 
 
 Project info:
 
 Git repo: https://gitlab.com/RufusLeonard/rl-episerver-tech-test-2018.git
 Git username: keith@codespring.co.uk
 Git password: _Passw0rd!
 
 Episerver admin credentials:
 Username: admin
 Password: Passw0rd!
 
 Define a new feature branch using your name as the branch name, commit all changes there. Commits received after the exam cut-off time will not be accepted. 
 
 ----------------------------------------- 